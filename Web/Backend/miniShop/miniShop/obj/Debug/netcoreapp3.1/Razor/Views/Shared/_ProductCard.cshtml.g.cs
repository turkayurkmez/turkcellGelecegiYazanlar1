#pragma checksum "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\miniShop\miniShop\Views\Shared\_ProductCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaf43f1bf01b60114cb7e93a34f05ac1b5cf7654"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductCard), @"mvc.1.0.view", @"/Views/Shared/_ProductCard.cshtml")]
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
#line 1 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\miniShop\miniShop\Views\_ViewImports.cshtml"
using miniShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\miniShop\miniShop\Views\_ViewImports.cshtml"
using miniShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf43f1bf01b60114cb7e93a34f05ac1b5cf7654", @"/Views/Shared/_ProductCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e89c7a1ffe5e5bc12468818da738b27fa24854d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 44, "\"", 65, 1);
#nullable restore
#line 3 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\miniShop\miniShop\Views\Shared\_ProductCard.cshtml"
WriteAttributeValue("", 50, Model.ImageUrl, 50, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Saat\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 5 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\miniShop\miniShop\Views\Shared\_ProductCard.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 6 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\miniShop\miniShop\Views\Shared\_ProductCard.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">");
#nullable restore
#line 7 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\miniShop\miniShop\Views\Shared\_ProductCard.cshtml"
                        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" yerine ");
#nullable restore
#line 7 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\miniShop\miniShop\Views\Shared\_ProductCard.cshtml"
                                             Write(Model.Price * (decimal)(1-Model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n        <a href=\"#\" class=\"btn btn-primary\">Sepete Ekle</a>\r\n    </div>\r\n</div>");
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
