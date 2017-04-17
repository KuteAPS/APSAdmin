using System.Web;
using System.Web.Optimization;

namespace ManagementAdmin
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region CSS

            //-CSS  系统必备 
            bundles.Add(new StyleBundle("~/system/Content").Include(
                        "~/css/bootstrap.min14ed.css",
                        "~/css/animate.min.css",
                        "~/css/font-awesome.min93e3.css",
                        "~/css/style.min862f.css",
                        "~/css/plugins/sweetalert/sweetalert.css",
                         "~/css/plugins/toastr/toastr.min.css",
                         "~/css/plugins/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css",
                         "~/css/plugins/iCheck/custom.css",
                         "~/js/plugins/layer/skin/default/layer.css"
                        ));

            //-------------------------------各部分插件
            //-CSS  bootstraptable 
            bundles.Add(new StyleBundle("~/system/bootstraptablec").Include(
             "~/css/plugins/bootstrap-table/bootstrap-table.min.css"
            ));

            //-CSS  JQGridTable 
            bundles.Add(new StyleBundle("~/system/JQGridTablec").Include(
                         "~/css/plugins/jqgrid/ui.jqgridffe4.css"
                        ));

            #endregion

            #region JS

            //-Js  系统必备 
            bundles.Add(new ScriptBundle("~/system/jquery").Include(
                        "~/js/jquery.min.js",
                        "~/js/bootstrap.min.js",
                        "~/js/plugins/layer/layer.js",
                        "~/js/plugins/iCheck/icheck.min.js",
                        "~/js/plugins/sweetalert/sweetalert.min.js",
                        "~/js/plugins/toastr/toastr.min.js",
                        "~/js/Bom/Management.js"
                        ));


            //-------------------------------各部分插件
            //-JS  bootstraptable 
            bundles.Add(new ScriptBundle("~/system/bootstraptablej").Include(
                       "~/js/plugins/bootstrap-table/bootstrap-table.js",
                       "~/js/plugins/bootstrap-table/bootstrap-table-mobile.min.js",
                       "~/js/plugins/bootstrap-table/locale/bootstrap-table-zh-CN.min.js"
                       ));

            //-JS JQGridTable

            bundles.Add(new ScriptBundle("~/system/JQGridTablej").Include(
                       "~/js/plugins/peity/jquery.peity.min.js",
                       "~/js/plugins/jqgrid/i18n/grid.locale-cnffe4.js",
                       "~/js/plugins/jqgrid/jquery.jqGrid.minffe4.js",
                       "~/js/content.min.js"
                       ));



            //-JS  导出各种格式
            bundles.Add(new ScriptBundle("~/system/bootstraptableExport").Include(
                     "~/js/plugins/tableExport/libs/js-xlsx/xlsx.core.min.js",
                     "~/js/plugins/tableExport/libs/FileSaver/FileSaver.min.js",
                     "~/js/plugins/tableExport/libs/pdfmake/pdfmake.min.js",
                     "~/js/plugins/tableExport/libs/pdfmake/vfs_fonts.js",
                     "~/js/plugins/tableExport/libs/jsPDF/jspdf.min.js",
                     "~/js/plugins/tableExport/libs/jsPDF-AutoTable/jspdf.plugin.autotable.js",
                     "~/js/plugins/tableExport/libs/html2canvas/html2canvas.min.js",
                     "~/js/plugins/tableExport/tableExport.js"
                     ));

            #endregion

        }
    }
}
