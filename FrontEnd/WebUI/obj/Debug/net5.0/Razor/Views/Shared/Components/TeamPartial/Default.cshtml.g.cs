#pragma checksum "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\TeamPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4270f35c0939c2b7c387dbeeab81e226032abd4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TeamPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TeamPartial/Default.cshtml")]
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
#line 1 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\TeamPartial\Default.cshtml"
using WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4270f35c0939c2b7c387dbeeab81e226032abd4d", @"/Views/Shared/Components/TeamPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TeamPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultStaffDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/hotel-html-template/img/team-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Our Team</h6>
            <h1 class=""mb-5"">Explore Our <span class=""text-primary text-uppercase"">Staffs</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 10 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\TeamPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 wow fadeInUp\" data-wow-delay=\"0.1s\">\r\n                <div class=\"rounded shadow overflow-hidden\">\r\n                    <div class=\"position-relative\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4270f35c0939c2b7c387dbeeab81e226032abd4d5380", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"position-absolute start-50 top-100 translate-middle d-flex align-items-center\">\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 972, "\"", 979, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1090, "\"", 1097, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1205, "\"", 1212, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center p-4 mt-3\">\r\n                        <h5 class=\"fw-bold mb-0\">");
#nullable restore
#line 23 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\TeamPartial\Default.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <small>");
#nullable restore
#line 24 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\TeamPartial\Default.cshtml"
                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\TeamPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultStaffDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591