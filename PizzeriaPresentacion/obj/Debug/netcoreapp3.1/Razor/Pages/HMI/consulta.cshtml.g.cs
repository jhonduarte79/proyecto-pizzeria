#pragma checksum "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a033a3e4a237cf868f98fbf6859248dd6070182"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PizzeriaPresentacion.Pages.HMI.Pages_HMI_consulta), @"mvc.1.0.razor-page", @"/Pages/HMI/consulta.cshtml")]
namespace PizzeriaPresentacion.Pages.HMI
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
#line 1 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\_ViewImports.cshtml"
using PizzeriaPresentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a033a3e4a237cf868f98fbf6859248dd6070182", @"/Pages/HMI/consulta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ad9c3917378a2182adf9aba475ff4ba89f775f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HMI_consulta : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
  
     ViewData["Title"] = "consulta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class = \"table\">\r\n<thead>\r\n  <tr>\r\n    <td>Nombres</td>\r\n    <td>Apellidos</td>\r\n    <td>Email</td>\r\n    <td>Edad</td>\r\n    <td>Telefono</td>\r\n    <td>Direccion</td>\r\n  </tr>\r\n</thead>\r\n  \r\n");
#nullable restore
#line 19 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
     foreach (var c in Model.listaCliente)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <td>");
#nullable restore
#line 22 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
       Write(c.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
       Write(c.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
       Write(c.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
       Write(c.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
       Write(c.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
       Write(c.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      </tr>\r\n");
#nullable restore
#line 29 "C:\PROYECTOPIZZATECH\PizzeriaApp\PizzeriaPresentacion\Pages\HMI\consulta.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzeriaPresentacion.Pages.consultaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzeriaPresentacion.Pages.consultaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzeriaPresentacion.Pages.consultaModel>)PageContext?.ViewData;
        public PizzeriaPresentacion.Pages.consultaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
