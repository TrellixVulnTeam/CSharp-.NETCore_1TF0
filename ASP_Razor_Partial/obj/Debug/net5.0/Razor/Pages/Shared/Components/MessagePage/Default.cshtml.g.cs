#pragma checksum "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\MessagePage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d95eec28aca713b7e4c130fcaf9da8557548a8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASP_Razor_Partial.Pages.Shared.Components.MessagePage.Pages_Shared_Components_MessagePage_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/MessagePage/Default.cshtml")]
namespace ASP_Razor_Partial.Pages.Shared.Components.MessagePage
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
#line 1 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\_ViewImports.cshtml"
using ASP_Razor_Partial;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d95eec28aca713b7e4c130fcaf9da8557548a8d", @"/Pages/Shared/Components/MessagePage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"640b0c3ff06627343e492adc58b8222f75930d88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_MessagePage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_Razor_Partial.Pages.Shared.Components.MessagePage.MessagePage.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\MessagePage\Default.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = @Model.title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card m-4\">\r\n    <div class=\"card-header bg-danger text-light\">\r\n        <h4>");
#nullable restore
#line 8 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\MessagePage\Default.cshtml"
       Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
#nullable restore
#line 11 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\MessagePage\Default.cshtml"
   Write(Html.Raw(Model.htmlcontent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        Chuyển đến - <a");
            BeginWriteAttribute("href", " href=\"", 405, "\"", 430, 1);
#nullable restore
#line 14 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\MessagePage\Default.cshtml"
WriteAttributeValue("", 412, Model.urlredirect, 412, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\MessagePage\Default.cshtml"
                                             Write(Model.urlredirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_Razor_Partial.Pages.Shared.Components.MessagePage.MessagePage.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
