#pragma checksum "C:\Users\DELL\Desktop\BizLand-21.11.2022\BizLand-21.11.2022\Views\Service\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97a867dd03c22a450b03b5075b9faa283c3c02d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Detail), @"mvc.1.0.view", @"/Views/Service/Detail.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\BizLand-21.11.2022\BizLand-21.11.2022\Views\_ViewImports.cshtml"
using BizLand_21._11._2022.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\BizLand-21.11.2022\BizLand-21.11.2022\Views\_ViewImports.cshtml"
using BizLand_21._11._2022.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97a867dd03c22a450b03b5075b9faa283c3c02d9", @"/Views/Service/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775d2a695da57113524a21bc5f7d4fb8ccc59a3d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Desktop\BizLand-21.11.2022\BizLand-21.11.2022\Views\Service\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n          <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch mb-4 ms-4 mt-4\" data-aos=\"zoom-in\" data-aos-delay=\"100\">\r\n            <div class=\"icon-box\">\r\n              <div class=\"icon\">");
#nullable restore
#line 8 "C:\Users\DELL\Desktop\BizLand-21.11.2022\BizLand-21.11.2022\Views\Service\Detail.cshtml"
                           Write(Html.Raw(Model.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n              <h4><a");
            BeginWriteAttribute("href", " href=\"", 313, "\"", 320, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\DELL\Desktop\BizLand-21.11.2022\BizLand-21.11.2022\Views\Service\Detail.cshtml"
                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n              <p>");
#nullable restore
#line 10 "C:\Users\DELL\Desktop\BizLand-21.11.2022\BizLand-21.11.2022\Views\Service\Detail.cshtml"
            Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n          </div>\r\n        ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
