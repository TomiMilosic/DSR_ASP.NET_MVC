#pragma checksum "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b815eba487d4b4968d65991ef53b99fad2011f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Izpis), @"mvc.1.0.view", @"/Views/Home/Izpis.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b815eba487d4b4968d65991ef53b99fad2011f2", @"/Views/Home/Izpis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdb231934b92542ddf2fd26ac3004a40910e4c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Izpis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<naloga2.Models.Uporabnik>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
  
    ViewData["Title"] = "Izpis";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Izpis: </h3>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div>Ime: </div><p>");
#nullable restore
#line 13 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
              Write(Model.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Priimek: </div><p>");
#nullable restore
#line 14 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                  Write(Model.priimek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Starost: </div><p>");
#nullable restore
#line 15 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                  Write(Model.starost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Rojstni dan: </div><p>");
#nullable restore
#line 16 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                      Write(Model.RojstniDan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Rojstni kraj: </div><p>");
#nullable restore
#line 17 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                       Write(Model.KrajRojstva);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>EMSO: </div><p>");
#nullable restore
#line 18 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
               Write(Model.emso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Naslov: </div><p>");
#nullable restore
#line 19 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                 Write(Model.Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Poštna številka:</div><p>");
#nullable restore
#line 20 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                         Write(Model.PostnaStevilka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Pošta: </div><p>");
#nullable restore
#line 21 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                Write(Model.Posta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Država: </div><p>");
#nullable restore
#line 22 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                 Write(Model.Drzava);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div>Email: </div><p>");
#nullable restore
#line 23 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Izpis.cshtml"
                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<naloga2.Models.Uporabnik> Html { get; private set; }
    }
}
#pragma warning restore 1591
