#pragma checksum "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\ExcelDataImportAndLook\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c470b1a3fc443230210c53dc9371a5ff62fd00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExcelDataImportAndLook_Index), @"mvc.1.0.view", @"/Views/ExcelDataImportAndLook/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\_ViewImports.cshtml"
using YY_NpoiExportAndImport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\_ViewImports.cshtml"
using YY_NpoiExportAndImport.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c470b1a3fc443230210c53dc9371a5ff62fd00", @"/Views/ExcelDataImportAndLook/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0c8166817a9aff216813aeabf40d1778899c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_ExcelDataImportAndLook_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\ExcelDataImportAndLook\Index.cshtml"
  
    ViewData["Title"] = "数据展示";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"layui-header header header-doc\" spring>\r\n    <div class=\"layui-main\">\r\n        <ul class=\"layui-nav\" id=\"nav\">\r\n            <li class=\"layui-nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 223, "\"", 257, 1);
#nullable restore
#line 8 "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\ExcelDataImportAndLook\Index.cshtml"
WriteAttributeValue("", 230, Url.Action("Index","Home"), 230, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;\">使用NPOI导出Word文档</a>\r\n            </li>&#xe9aa;\r\n            <li class=\"layui-nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 395, "\"", 449, 1);
#nullable restore
#line 11 "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\ExcelDataImportAndLook\Index.cshtml"
WriteAttributeValue("", 402, Url.Action("ExportExcelData","ExcelOperation"), 402, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;\">使用NPOI导出Excel文档</a>\r\n            </li>\r\n            <li class=\"layui-nav-item layui-this\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 591, "\"", 643, 1);
#nullable restore
#line 14 "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\ExcelDataImportAndLook\Index.cshtml"
WriteAttributeValue("", 598, Url.Action("Index","ExcelDataImportAndLook"), 598, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">将Excel文档数据数据批量导入到MySQL中</a>
            </li>
        </ul>
    </div>
</div>
<div style=""height: 20px;""></div>
    <div class=""layui-fluid"">
        <div class=""layui-row layui-col-space15"">
            <div class=""layui-col-md12"">
                <div class=""layui-card"">
                    <div class=""layui-card-header"">
                        <button class=""layui-btn layui-btn"" onclick=""openImportPage()""> <i class=""layui-icon"">&#xe62f;</i> Onclick数据导入</button>
                      
                        <button class=""layui-btn layui-btn layui-btn-danger"" onclick=""Download()""><i class=""layui-icon"">&#xe601;</i>Onclick导入模板下载</button>
                        <!--// 搜索：用户姓名-->
                        <div class=""layui-inline"">
                            <input class=""layui-input layui-icon-search"" name=""id"" id=""userName"" autocomplete=""off"" placeholder=""请输入用户名"">
                        </div>
                        <button class=""layui-btn layui-btn"" id=""q");
            WriteLiteral("ueryData\"><i class=\"layui-icon\">&#xe615;</i>查询</button>\r\n                        <button class=\"layui-btn layui-btn\" id=\"btn-refresh\"><i class=\"layui-icon\">&#xe9aa;</i>刷新</button>\r\n");
            WriteLiteral(@"                    </div>

                    <div class=""layui-card-body"">
                        <table class=""layui-hide"" id=""layUI_Table""></table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        //模板下载
        function Download()
        {
            window.location.href=""/ExcelFiles/Template.xlsx"";
        }

        //打开数据导入页面
        function openImportPage() {
            layer.open({
                type: 2,
                title: '数据导入',
                shadeClose: true,
                shade: false,
                maxmin: false, //开启最大化最小化按钮
                area: ['525px', '270px'],
                content: '");
#nullable restore
#line 61 "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\ExcelDataImportAndLook\Index.cshtml"
                     Write(Url.Action("ImportPage","ExcelDataImportAndLook"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
            });
        }

        function Export() {

        }

        //layui—table表格渲染和数据绑定
        layui.use('table', function () {
            var table = layui.table;

         // 表格渲染
         var tableIns=table.render({
               elem: '#layUI_Table'
              , url: '");
#nullable restore
#line 76 "E:\马连军\Excel-Import\YY_Npoi_ExportAndImport\Views\ExcelDataImportAndLook\Index.cshtml"
                 Write(Url.Action("GetUserInfo","ExcelDataImportAndLook"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
               loading: true,
               height: 505,//容器高度
               limit: 15,
               limits: [15, 30, 60, 90],
               cols: [
                   [
                       { fixed: 'id', type: 'checkbox', width: 100 },
                       { field: 'id', width: 110, title: '用户编号', sort: true },
                       { field: 'userName', width: 150, title: '用户名' },
                       { field: 'sex', width: 70, title: '性别' },
                       { field: 'phone', width: 150, title: '手机号' },
                       { field: 'description', width: 300, title: '个人介绍' },
                       { field: 'hobby', title: '爱好', minWidth: 150, width: 280 }
                   ]
               ],
               page: true
            });

            // 刷新
            $('#btn-refresh').on('click',
                function() {
                    tableIns.reload();
                });

            //search Data
            $(""#queryData"").on(""click"",
         ");
            WriteLiteral(@"       function() {

                    var userName = $(""#userName"").val();
                    /*if (userName == """") {
                        layer.msg(""用户名不能为空~"");
                        return false;
                    }
                    */
                    table.reload('layUI_Table', {
                        where: { //请求参数（注意：这里面的参数可任意定义，并非下面固定的格式）
                            userName: userName
                            //,order: obj.type //排序方式
                        }
                    });
            });
        });
    </script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
