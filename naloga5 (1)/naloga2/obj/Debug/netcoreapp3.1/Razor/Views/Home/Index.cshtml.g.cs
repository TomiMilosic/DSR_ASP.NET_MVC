#pragma checksum "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cde20d98dca5c8239e58ac197ebe5a3da728abf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cde20d98dca5c8239e58ac197ebe5a3da728abf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdb231934b92542ddf2fd26ac3004a40910e4c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div id=""accordion"">
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                    Kaj je ""Meteorološka postaja""?
                </button>
            </h5>
        </div>

        <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
            <div class=""card-body"">
                Meteorološka postaja je ustanova meteorološke službe, ki služi za meteorološka opazovanja za preučevanje vremena in podnebja ter za druge znanstvene raziskave, pomembne za vse panoge človeške dejavnosti, zlasti kmetijstvo, gozdarstvo, gospodarjenje z vodami in promet. V okviru Svetovne meteorološke organizacije služijo za mednarodno izmenjavo podatkov za proučevanje Zemljine atmosfere kot celote.
            </div>
        </div>
    </div>
    <div class=""ca");
            WriteLiteral(@"rd"">
        <div class=""card-header"" id=""headingTwo"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                    Meteorologija
                </button>
            </h5>
        </div>
        <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
            <div class=""card-body"">
                Meteorologíja ali vremenoslóvje je znanost o ozračju, ki raziskuje vremenske procese in napoveduje vreme. Meteorološki fenomeni so opazovani vremenski dogodki in jih razlaga meteorologija. Te dogodke določajo spremenljivke Zemljinega ozračja (npr. temperatura, tlak in vodna para). Gradniki in odnosi med spremenljivkami se spreminjajo skozi čas. Večina opazovanega zemeljskega vremena se nahaja v troposferi.
            </div>
        </div>
    </div>
    <div class=""card"">
        <div class=""card-header"" id=""headin");
            WriteLiteral(@"gThree"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                    Samodejna vremenska postaja
                </button>
            </h5>
        </div>
        <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
            <div class=""card-body"">
                Avtomatska meteorološka postaja izvaja meritve glavnih meteoroloških pojavov (elementov) , nenehno (neprekinjeno) jih zapisuje v magnetne zapise in jih po radiu ali žici poroča po zbirnih centrih. Pomorske postaje na kopnem in ladjah izvajajo program sinoptičnih postaj s poudarkom na opazovanju stanja morja . Samodejne postaje na morju, na zasidranih ali premičnih bojevih poročajo ne le o meteoroloških, temveč tudi o oceanografskih podatkih (višina valov ,temperatura morja, morski tokovi in drugo).
            </div>
        </div>
    </div>");
            WriteLiteral(@"
</div>

<br />
<br />
<br />








<table id=""tabla-uporabnikov"" class=""table"">
    <tr>

        <th>Ime:</th>
        <th>Priimek:</th>
        <th>Rojstni dan:</th>
        <th>Kraj rojstva:</th>
        <th>Emso:</th>
        <th>Starost:</th>
        <th>Naslov:</th>
        <th>Postna st:</th>
        <th>Posta:</th>
        <th>Drzava:</th>
        <th>Email:</th>
    </tr>

");
#nullable restore
#line 83 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
      

        List<Uporabnik> uporabniks = new List<Uporabnik>();
        using (var db = new Baza())
        {
            uporabniks = db.uporabniki.ToList();
        }


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
         for (int i = 0; i < uporabniks.Count; i++)//pazi s cim se zacne z 0 or 1 pa db zazi
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 95 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].priimek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].RojstniDan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 98 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].KrajRojstva);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 99 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].emso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 100 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].starost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 101 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 102 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].PostnaStevilka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 103 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].Posta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 104 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].Drzava);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 105 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
               Write(uporabniks[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4432, "\"", 4482, 1);
#nullable restore
#line 107 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
WriteAttributeValue("", 4439, Url.Action("Edit", "Home", new { id = i }), 4439, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4561, "\"", 4612, 1);
#nullable restore
#line 110 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
WriteAttributeValue("", 4568, Url.Action("Delete", "Home", new { id = i}), 4568, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4693, "\"", 4750, 1);
#nullable restore
#line 113 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
WriteAttributeValue("", 4700, Url.Action("IzpisPregled", "Home", new { id = i}), 4700, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Podrobnosti</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 116 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n\r\n\r\n");
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
