#pragma checksum "C:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\Admin\Profesor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95c6e7a256390d25f2806ce7583ee72220b57200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Profesor), @"mvc.1.0.view", @"/Views/Admin/Profesor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Profesor.cshtml", typeof(AspNetCore.Views_Admin_Profesor))]
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
#line 1 "C:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#line 1 "C:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\Admin\Profesor.cshtml"
using App.Models.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\Admin\Profesor.cshtml"
using App.Models.DataBaseModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c6e7a256390d25f2806ce7583ee72220b57200", @"/Views/Admin/Profesor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Profesor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfesorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\Admin\Profesor.cshtml"
 foreach (var profesor in Model.Profesores)
{
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfesorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
