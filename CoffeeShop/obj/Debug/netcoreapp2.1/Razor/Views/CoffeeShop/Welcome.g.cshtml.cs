#pragma checksum "C:\Users\YL\source\repos\CoffeeShop\CoffeeShop\Views\CoffeeShop\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15fb826ee42ed404b36267ad1eaf197df2ca09ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoffeeShop_Welcome), @"mvc.1.0.view", @"/Views/CoffeeShop/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoffeeShop/Welcome.cshtml", typeof(AspNetCore.Views_CoffeeShop_Welcome))]
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
#line 1 "C:\Users\YL\source\repos\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#line 2 "C:\Users\YL\source\repos\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15fb826ee42ed404b36267ad1eaf197df2ca09ca", @"/Views/CoffeeShop/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_CoffeeShop_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\YL\source\repos\CoffeeShop\CoffeeShop\Views\CoffeeShop\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(43, 59, true);
            WriteLiteral("\r\n<h2>Welcome</h2>\r\n\r\n<input type=\"button\" value=\"Register\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 102, "\"", 186, 2);
#line 7 "C:\Users\YL\source\repos\CoffeeShop\CoffeeShop\Views\CoffeeShop\Welcome.cshtml"
WriteAttributeValue("", 112, "window.location.href='" + @Url.Action("Register", "CoffeeShop") + "'", 112, 73, false);

#line default
#line hidden
            WriteAttributeValue("", 185, ";", 185, 1, true);
            EndWriteAttribute();
            BeginContext(187, 39, true);
            WriteLiteral(" />\r\n<input type=\"button\" value=\"Login\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 226, "\"", 307, 2);
#line 8 "C:\Users\YL\source\repos\CoffeeShop\CoffeeShop\Views\CoffeeShop\Welcome.cshtml"
WriteAttributeValue("", 236, "window.location.href='" + @Url.Action("Login", "CoffeeShop") + "'", 236, 70, false);

#line default
#line hidden
            WriteAttributeValue("", 306, ";", 306, 1, true);
            EndWriteAttribute();
            BeginContext(308, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
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
