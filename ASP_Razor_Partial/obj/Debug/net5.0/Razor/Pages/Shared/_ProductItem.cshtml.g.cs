#pragma checksum "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\_ProductItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3632e2702a1967857a8df3a353c6b9c43b48126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASP_Razor_Partial.Pages.Shared.Pages_Shared__ProductItem), @"mvc.1.0.view", @"/Pages/Shared/_ProductItem.cshtml")]
namespace ASP_Razor_Partial.Pages.Shared
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
#nullable restore
#line 1 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\_ProductItem.cshtml"
using ASP_Razor_Partial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3632e2702a1967857a8df3a353c6b9c43b48126", @"/Pages/Shared/_ProductItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"640b0c3ff06627343e492adc58b8222f75930d88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__ProductItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card my-4 text-center\" style=\"width:350px\">\r\n    <h2 class=\"card-header text-info\">");
#nullable restore
#line 5 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\_ProductItem.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"card-body\">\r\n        <p class=\"card-text\">");
#nullable restore
#line 7 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\_ProductItem.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Giá: ");
#nullable restore
#line 8 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\_ProductItem.cshtml"
                             Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a href=\"#\" class=\"btn btn-info btn-sm\">Đặt hàng</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
