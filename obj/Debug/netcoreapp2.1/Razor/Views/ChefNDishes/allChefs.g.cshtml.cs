#pragma checksum "/Users/maad/Desktop/C#_Folder/Web_Section/ChefsNDishes/Views/ChefNDishes/allChefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b71d0006efa4bb7e7cf248cd41896f0403256de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChefNDishes_allChefs), @"mvc.1.0.view", @"/Views/ChefNDishes/allChefs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChefNDishes/allChefs.cshtml", typeof(AspNetCore.Views_ChefNDishes_allChefs))]
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
#line 1 "/Users/maad/Desktop/C#_Folder/Web_Section/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b71d0006efa4bb7e7cf248cd41896f0403256de", @"/Views/ChefNDishes/allChefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f27cbdc516664a4fc1d71b8e34fb4ef396ce1d0", @"/Views/_ViewImports.cshtml")]
    public class Views_ChefNDishes_allChefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(19, 1204, true);
            WriteLiteral(@"
<div class=""container mt-5"">
    <div class=""text-center"">
        <a href=""allChefs"" class=""mt-3 btn btn-primary mr-5"">Chefs</a>
        <a href=""allDishes"" class=""mt-3 btn btn-success m1-5"">Chefs</a>
    </div>
    <a class=""btn btn-info"" data-toggle=""modal"" data-target=""#addChef"">Recruit a Chef</a>





<!-- Modal -->

    <div class=""modal fade"" id=""addChef"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addChef"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ...
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""m");
            WriteLiteral("odal\">Close</button>\n                <button type=\"button\" class=\"btn btn-primary\">Save changes</button>\n            </div>\n            </div>\n        </div>\n    </div>\n\n\n\n\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591