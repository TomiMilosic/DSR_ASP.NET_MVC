#pragma checksum "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Shared\EditorTemplates\Int32.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e6f1301d00476808e00b2ea4f3a600205cdfe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Int32), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Int32.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e6f1301d00476808e00b2ea4f3a600205cdfe2", @"/Views/Shared/EditorTemplates/Int32.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdb231934b92542ddf2fd26ac3004a40910e4c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Int32 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Int32?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n    <label>\r\n        <input type=\"range\"");
            BeginWriteAttribute("name", " name=\"", 62, "\"", 105, 1);
#nullable restore
#line 6 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Shared\EditorTemplates\Int32.cshtml"
WriteAttributeValue("", 69, ViewData.ModelMetadata.PropertyName, 69, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 106, "\"", 147, 1);
#nullable restore
#line 6 "C:\Users\Tomi\Downloads\naloga5 (1)\naloga2\Views\Shared\EditorTemplates\Int32.cshtml"
WriteAttributeValue("", 111, ViewData.ModelMetadata.PropertyName, 111, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\" max=\"1000\" value=\"1\"\r\n               onchange=\"$(\'~ output\', this).val(value)\"\r\n               oninput=\"$(\'~ output\', this).val(value)\">\r\n        <output>1</output>\r\n    </label>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Int32?> Html { get; private set; }
    }
}
#pragma warning restore 1591