#pragma checksum "C:\Users\khanh\source\repos\Lab3\Views\Home\DisplayPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70bf5d57102e4dc9fc3d1b38775d747ad60b49e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayPerson), @"mvc.1.0.view", @"/Views/Home/DisplayPerson.cshtml")]
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
#line 1 "C:\Users\khanh\source\repos\Lab3\Views\_ViewImports.cshtml"
using Lab3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70bf5d57102e4dc9fc3d1b38775d747ad60b49e6", @"/Views/Home/DisplayPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0026fa3d308ec0e5ca053f9f604abd473f8e3067", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab3.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\khanh\source\repos\Lab3\Views\Home\DisplayPerson.cshtml"
  
    Layout = "_Layout";
    ViewData["title"] = "Display Person";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <td>First Name: </td>\r\n        <td>");
#nullable restore
#line 10 "C:\Users\khanh\source\repos\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Last Name: </td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\khanh\source\repos\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Age: </td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\khanh\source\repos\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Email Address:</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\khanh\source\repos\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Date of Birth: </td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\khanh\source\repos\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Description: </td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\khanh\source\repos\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab3.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
