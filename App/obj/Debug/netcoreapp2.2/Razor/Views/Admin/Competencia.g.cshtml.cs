#pragma checksum "c:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\Admin\Competencia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e97db23e3f026bed8ed5f6a06bd0f030c53b27c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Competencia), @"mvc.1.0.view", @"/Views/Admin/Competencia.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Competencia.cshtml", typeof(AspNetCore.Views_Admin_Competencia))]
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
#line 1 "c:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#line 2 "c:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#line 1 "c:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\Admin\Competencia.cshtml"
using App.Models.ViewModels;

#line default
#line hidden
#line 2 "c:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\Admin\Competencia.cshtml"
using App.Models.DataBaseModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e97db23e3f026bed8ed5f6a06bd0f030c53b27c2", @"/Views/Admin/Competencia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Competencia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompetenciaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "c:\Users\PC\Desktop\Programación .NET\proyecto-gutierrez-lopez-navarro-roque\App\Views\Admin\Competencia.cshtml"
 foreach (var competencia in Model.Competencias)
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompetenciaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
