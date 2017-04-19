
//Ajax提交表单并 刷新表格
function AjaxResult(url, ajaxtype, data, refresh, o, refreshTable) {
    var msg = layer.msg('正在执行中...', { icon: 16, shade: 0.1, time: 0 });

    $.ajax({
        url: url,
        type: ajaxtype,
        data: data,
        timeout: 600000,
        success: function (result) {

            layer.close(msg);

            var json = eval('(' + result + ')');

            if (json.Success === "success" || json.Success === "warning") {
                if (refresh) {
                    o(refreshTable).bootstrapTable('refresh');
                }
            }

            AjaxDataToastShow(result);
        },
        error: function () {
            layer.close(msg);
            ToastShow("服务器异常", "超时未执行成功,请刷新页面后再次执行", 3000, "未知错误异常", "error");
        }
    }, "json");
}

//Toast 弹框的公共方法
function ToastShow(title, msg, timeOut, clickMsg, type) {
    var toastCount = 0;
    var toastIndex = toastCount++;
    toastr.options = {
        closeButton: true,
        progressBar: true,
        positionClass: "toast-bottom-right"
    };
    if (clickMsg.length > 0) {
        toastr.options.onclick = function () {
            layer.alert(clickMsg);
        }
    }

    toastr.options.showDuration = 100;
    toastr.options.hideDuration = 100;
    toastr.options.timeOut = timeOut;
    toastr.options.extendedTimeOut = 100;
    toastr.options.showEasing = "swing";
    toastr.options.hideEasing = "linear";
    toastr.options.showMethod = "fadeIn";
    toastr.options.hideMethod = "fadeOut";

    var $toast = parent.parent.toastr[type](msg, title);

    if ($toast.find("#okBtn").length) {
        $toast.delegate("#okBtn", "click", function () {
            alert("you clicked me. i was toast #" + toastIndex + ". goodbye!");
            $toast.remove();
        });
    }
    if ($toast.find("#surpriseBtn").length) {
        $toast.delegate("#surpriseBtn", "click", function () {
            alert("Surprise! you clicked me. i was toast #" + toastIndex + ". You could perform an action here.");
        });
    }
};

//post提交，将表格所选信息提交至后台
function PostData(tables, url, o, refreshTable) {

    var selects = $(tables).bootstrapTable('getSelections');

    if (selects.length < 1) {
        ToastShow("操作提示", "没有信息选中", 3000, "最少需选中一条数据", "warning");
        return;
    }

    swal({
        title: "您确定要处理这" + selects.length + "条信息吗",
        text: "处理后将无法恢复，请谨慎操作！",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "是的，我要处理！",
        cancelButtonText: "让我再考虑一下…"
    }, function (isConfirm) {
        if (isConfirm) {
            var data = { id: JSON.stringify(selects) }
            AjaxResult(url, "Post", data, true, o, refreshTable);
        } else {
            swal("已取消", "您取消了处理操作！", "error");
        }
    });
}

//表单提交
function FormSubmit(url, serialize) {
    var msg = layer.msg('正在执行中...', { icon: 16, shade: 0.1, time: 0 });
    $.post(url, serialize, function (data) {
        layer.close(msg);
        AjaxDataToastShow(data);
    });
}

//弹窗iframe，传入ID参数必须有一条数据被选中
function EditData(tables, url) {

    var selects = $(tables).bootstrapTable('getSelections');

    if (selects.length !== 1) {
        ToastShow("操作提示", "选择信息不符合要求", 3000, "必须选中一条数据", "warning");
        return;
    }

    var json = eval('(' + JSON.stringify(selects) + ')');

    //iframe窗 
    layer.open({
        type: 2,
        title: '编辑信息',
        shadeClose: true,
        shade: 0.8,
        area: ['100%', '100%'],
        content: url + '/' + json[0].Id + '.html' //iframe的url
    });
}

//Toast 解析返回提示数据
function AjaxDataToastShow(result) {

    var json = eval('(' + result + ')');

    if (json.Success === "success") {
        ToastShow("操作成功提示", json.JsonMsg, 3000, json.JsonMsg, "success");
    } else if (json.Success === "warning") {
        ToastShow("操作失败提示", json.JsonMsg, 3000, json.JsonMsg, "warning");
    } else if (json.Success === "error") {
        ToastShow("操作失败提示", json.JsonMsg, 3000, json.JsonMsg, "error");
    } else {
        ToastShow("信息提示", json.JsonMsg, 3000, json.JsonMsg, "info");
    }
}

//键盘监听 按下回车时触发某一个按钮的click事件
function keydowntrigger(obj) {
    document.onkeydown = function (event) {
        // ReSharper disable once CallerCalleeUsing
        var e = event || window.event || arguments.callee.caller.arguments[0];
        if (e && e.keyCode === 13) {
            obj.trigger("click");
        }
    }
}

//默认加载 btn_sub btn_submit
keydowntrigger($("#btn_submit"));


//表格导出
function doExport(selector, params) {
    var options = {
        //ignoreRow: [1,11,12,-2],
        //ignoreColumn: [0,-1],
        //pdfmake: {enabled: true},
        tableName: 'Countries',
        worksheetName: 'Countries by population'
    };

    $.extend(true, options, params);

    $(selector).tableExport(options);
}

function DoOnCellHtmlData(cell, row, col, data) {
    var result = "";
    if (data !== "") {
        var html = $.parseHTML(data);

        $.each(html, function () {
            if (typeof $(this).html() === 'undefined')
                result += $(this).text();
            else if ($(this).is("input"))
                result += $('#' + $(this).attr('id')).val();
            else if ($(this).is("select"))
                result += $('#' + $(this).attr('id') + " option:selected").text();
            else if ($(this).hasClass('no_export') !== true)
                result += $(this).html();
        });
    }
    return result;
}

function DoOnMsoNumberFormat(cell, row, col) {
    var result = "";
    if (row > 0 && col === 0)
        result = "\\@";
    return result;
}