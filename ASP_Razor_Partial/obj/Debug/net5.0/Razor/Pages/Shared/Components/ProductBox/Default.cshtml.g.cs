#pragma checksum "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\ProductBox\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e61ce205bdf66f17ada3f15dcf065b178859bb7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASP_Razor_Partial.Pages.Shared.Components.ProductBox.Pages_Shared_Components_ProductBox_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductBox/Default.cshtml")]
namespace ASP_Razor_Partial.Pages.Shared.Components.ProductBox
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
#line 1 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\ProductBox\Default.cshtml"
using ASP_Razor_Partial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e61ce205bdf66f17ada3f15dcf065b178859bb7f", @"/Pages/Shared/Components/ProductBox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"640b0c3ff06627343e492adc58b8222f75930d88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ProductBox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\"?>\r\n");
#nullable restore
#line 5 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\ProductBox\Default.cshtml"
     foreach(var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            ");
#nullable restore
#line 8 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\ProductBox\Default.cshtml"
       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong>");
#nullable restore
#line 8 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\ProductBox\Default.cshtml"
                             Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </li>\r\n");
#nullable restore
#line 10 "D:\.NET Core Projects\CSharp-.NETCore\ASP_Razor_Partial\Pages\Shared\Components\ProductBox\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
