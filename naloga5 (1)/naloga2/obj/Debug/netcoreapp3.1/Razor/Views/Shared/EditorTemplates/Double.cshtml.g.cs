#pragma checksum "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Shared\EditorTemplates\Double.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd6245ba10eb1e55e17649dbe4b5110b2edfaeed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Double), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Double.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd6245ba10eb1e55e17649dbe4b5110b2edfaeed", @"/Views/Shared/EditorTemplates/Double.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdb231934b92542ddf2fd26ac3004a40910e4c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Double : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<double>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    <label>\r\n        <input type=\"range\"");
            BeginWriteAttribute("name", " name=\"", 66, "\"", 109, 1);
#nullable restore
#line 7 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Shared\EditorTemplates\Double.cshtml"
WriteAttributeValue("", 73, ViewData.ModelMetadata.PropertyName, 73, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 110, "\"", 151, 1);
#nullable restore
#line 7 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Shared\EditorTemplates\Double.cshtml"
WriteAttributeValue("", 115, ViewData.ModelMetadata.PropertyName, 115, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\" max=\"100,00\" step=\"0.1\"  value=\"1\"\r\n               onchange=\"$(\'~ output\', this).val(value)\"\r\n               oninput=\"$(\'~ output\', this).val(value)\">\r\n        <output>1,0</output>\r\n    </label>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<double> Html { get; private set; }
    }
}
#pragma warning restore 1591
