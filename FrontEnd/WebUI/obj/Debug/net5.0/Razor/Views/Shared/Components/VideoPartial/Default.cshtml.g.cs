#pragma checksum "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\VideoPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cefa0434e7ae3fdffa73a0e6a0c59fffdc4d05a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VideoPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VideoPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cefa0434e7ae3fdffa73a0e6a0c59fffdc4d05a", @"/Views/Shared/Components/VideoPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VideoPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl py-5 px-0 wow zoomIn"" data-wow-delay=""0.1s"">
    <div class=""row g-0"">
        <div class=""col-md-6 bg-dark d-flex align-items-center"">
            <div class=""p-5"">
                <h6 class=""section-title text-start text-white text-uppercase mb-3"">Luxury Living</h6>
                <h1 class=""text-white mb-4"">Discover A Brand Luxurious Hotel</h1>
                <p class=""text-white mb-4"">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet</p>
                <a");
            BeginWriteAttribute("href", " href=\"", 631, "\"", 638, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary py-md-3 px-md-5 me-3\">Our Rooms</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 718, "\"", 725, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-light py-md-3 px-md-5"">Book A Room</a>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""video"">
                <button type=""button"" class=""btn-play"" data-bs-toggle=""modal"" data-src=""https://www.youtube.com/embed/DWRcNpR6Kdc"" data-bs-target=""#videoModal"">
                    <span></span>
                </button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""videoModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content rounded-0"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Youtube Video</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <!-- 16:9 aspect ratio -->
                <div class=""ratio ratio-16x9"">
            ");
            WriteLiteral("        <iframe class=\"embed-responsive-item\"");
            BeginWriteAttribute("src", " src=\"", 1795, "\"", 1801, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"video\" allowfullscreen allowscriptaccess=\"always\"\r\n                            allow=\"autoplay\"></iframe>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
