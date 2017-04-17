keydowntrigger($("#btn_submit"));

$("#btn_submit").click(function () {
    layer.msg('正在验证中...', { icon: 16, shade: 0.01, time: 0 });
    $.post("/Home/CheckUsers", $("#from_login").serialize(), function (data) {
        layer.msg(data);
        if (data === ("登录成功,正在跳转...")) {
            location.href = "/Home/Index";
        }
    });
});
