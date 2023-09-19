#pragma checksum "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc8d2cb67e36ca127e697e10c7d082b845ffdf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RoomPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RoomPartial/Default.cshtml")]
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
#line 1 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml"
using WebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc8d2cb67e36ca127e697e10c7d082b845ffdf5", @"/Views/Shared/Components/RoomPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RoomPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultRoomDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Our Rooms</h6>
            <h1 class=""mb-5"">Explore Our <span class=""text-primary text-uppercase"">Rooms</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 12 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                <div class=""room-item shadow rounded overflow-hidden"">
                    <div class=""position-relative"">
                        <img class=""img-fluid"" src=""img/room-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 764, "\"", 770, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">");
#nullable restore
#line 18 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml"
                                                                                                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                    <div class=\"p-4 mt-2\">\r\n                        <div class=\"d-flex justify-content-between mb-3\">\r\n                            <h5 class=\"mb-0\">");
#nullable restore
#line 22 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                            <div class=""ps-2"">
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                            </div>
                        </div>
                        <div class=""d-flex mb-3"">
                            <small class=""border-end me-3 pe-3""><i class=""fa fa-bed text-primary me-2""></i>");
#nullable restore
#line 32 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml"
                                                                                                      Write(item.Bath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            <small class=\"border-end me-3 pe-3\"><i class=\"fa fa-bath text-primary me-2\"></i>");
#nullable restore
#line 33 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml"
                                                                                                       Write(item.BathCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                            <small><i class=""fa fa-wifi text-primary me-2""></i>Wifi</small>
                        </div>
                        <p class=""text-body mb-3""></p>
                        <div class=""d-flex justify-content-between"">
                            <a class=""btn btn-sm btn-primary rounded py-2 px-4""");
            BeginWriteAttribute("href", " href=\"", 2304, "\"", 2311, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml"
                                                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <a class=\"btn btn-sm btn-dark rounded py-2 px-4\"");
            BeginWriteAttribute("href", " href=\"", 2412, "\"", 2419, 0);
            EndWriteAttribute();
            WriteLiteral(@">Book Now</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.3s"">
                <div class=""room-item shadow rounded overflow-hidden"">
                    <div class=""position-relative"">
                        <img class=""img-fluid"" src=""img/room-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2811, "\"", 2817, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">$100/Night</small>\r\n                    </div>\r\n                    \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Shared\Components\RoomPartial\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultRoomDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
