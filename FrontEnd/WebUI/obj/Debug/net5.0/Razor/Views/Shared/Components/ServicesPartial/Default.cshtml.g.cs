#pragma checksum "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\ServicesPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f40e9c5026672967b8cdf48de5ff9e0f83da5084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ServicesPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ServicesPartial/Default.cshtml")]
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
#line 1 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\ServicesPartial\Default.cshtml"
using WebUI.Dtos.ServicesDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40e9c5026672967b8cdf48de5ff9e0f83da5084", @"/Views/Shared/Components/ServicesPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ServicesPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultServiceDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl py-5"">

    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Our Services</h6>
            <h1 class=""mb-5"">Explore Our <span class=""text-primary text-uppercase"">Services</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 11 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\ServicesPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 wow fadeInUp\" data-wow-delay=\"0.1s\">\r\n                    <a class=\"service-item rounded\"");
            BeginWriteAttribute("href", " href=\"", 638, "\"", 645, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"service-icon bg-transparent border rounded p-1\">\r\n                            <div class=\"w-100 h-100 border rounded d-flex align-items-center justify-content-center\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 888, "\"", 913, 1);
#nullable restore
#line 17 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\ServicesPartial\Default.cshtml"
WriteAttributeValue("", 896, item.ServiceIcon, 896, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                        </div>\r\n                        <h5 class=\"mb-3\">");
#nullable restore
#line 20 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\ServicesPartial\Default.cshtml"
                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"text-body mb-0\">");
#nullable restore
#line 21 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\ServicesPartial\Default.cshtml"
                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\ServicesPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultServiceDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
