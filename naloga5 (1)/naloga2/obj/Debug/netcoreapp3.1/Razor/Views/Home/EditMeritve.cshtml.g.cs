#pragma checksum "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\EditMeritve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5986ecf91edf55f376a70f954f6d6083cae4cee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditMeritve), @"mvc.1.0.view", @"/Views/Home/EditMeritve.cshtml")]
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
#line 1 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\_ViewImports.cshtml"
using naloga2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\_ViewImports.cshtml"
using naloga2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5986ecf91edf55f376a70f954f6d6083cae4cee3", @"/Views/Home/EditMeritve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdb231934b92542ddf2fd26ac3004a40910e4c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditMeritve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<naloga2.Models.Meritve>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\EditMeritve.cshtml"
  
    ViewData["Title"] = "EditMeritve";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>EditMeritve</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\EditMeritve.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\EditMeritve.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\EditMeritve.cshtml"
                          ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <input type=\"submit\" value=\"Poslji\" />\r\n");
#nullable restore
#line 13 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\EditMeritve.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<naloga2.Models.Meritve> Html { get; private set; }
    }
}
#pragma warning restore 1591
