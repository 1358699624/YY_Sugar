#pragma checksum "D:\VS2019\Excel-Import\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f623c74a1ebe6bb9f31c9bca0952ce2f664e7c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\VS2019\Excel-Import\YY_Npoi_ExportAndImport\Views\_ViewImports.cshtml"
using YY_NpoiExportAndImport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS2019\Excel-Import\YY_Npoi_ExportAndImport\Views\_ViewImports.cshtml"
using YY_NpoiExportAndImport.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f623c74a1ebe6bb9f31c9bca0952ce2f664e7c4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0c8166817a9aff216813aeabf40d1778899c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/wordPicture.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("530"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\VS2019\Excel-Import\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "NPOI导出Word文档示例";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"layui-header header header-doc\" spring>\r\n    <div class=\"layui-main\">\r\n        <ul class=\"layui-nav\" id=\"nav\">\r\n            <li class=\"layui-nav-item layui-this\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 244, "\"", 278, 1);
#nullable restore
#line 8 "D:\VS2019\Excel-Import\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
WriteAttributeValue("", 251, Url.Action("Index","Home"), 251, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;\">使用NPOI导出Word文档</a>\r\n            </li>\r\n            <li class=\"layui-nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 408, "\"", 462, 1);
#nullable restore
#line 11 "D:\VS2019\Excel-Import\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
WriteAttributeValue("", 415, Url.Action("ExportExcelData","ExcelOperation"), 415, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;\">使用NPOI导出Excel文档</a>\r\n            </li>\r\n            <li class=\"layui-nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 593, "\"", 645, 1);
#nullable restore
#line 14 "D:\VS2019\Excel-Import\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
WriteAttributeValue("", 600, Url.Action("Index","ExcelDataImportAndLook"), 600, 45, false);

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
<div class=""text-center"">
    <button type=""button"" class=""layui-btn layui-btn-fluid"" onclick=""wordExport()"" style=""width: 600px;"">导出并保存如下图所示的Word文档</button>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f623c74a1ebe6bb9f31c9bca0952ce2f664e7c45941", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script type=""text/javascript"">
    function wordExport() {
        var index = layer.msg('Work文档努力生成中...', { icon: 16, shade: 0.8, time: false });
        $.ajax({
            async: true,
            dataType: ""json"",
            type: ""post"",
            url: """);
#nullable restore
#line 31 "D:\VS2019\Excel-Import\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
             Write(Url.Action("WordExport","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            success: function (res) {
                layer.close(index);
                if (res.code == 1) {
                    window.location.href = res.data;
                } else {
                    alert(res.data);
                }
            }
        });
    }
</script>");
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
