#pragma checksum "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f6ee15bdac01d7129300d393dcba1499ab07da1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\_ViewImports.cshtml"
using PocketMenuUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\_ViewImports.cshtml"
using PocketMenuUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\_ViewImports.cshtml"
using PocketMenuUI.Models.ModelsDTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f6ee15bdac01d7129300d393dcba1499ab07da1", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643f081494c3f5d7a6a09193402a1101c5f19e4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WeatherForecastDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<div class=""form-horizontal"">

    <hr />
    <div class=""form-group"">


        <table class=""table table-responsive"" style=""width:400px"">
            <tr>
                <th>
                    ");
#nullable restore
#line 21 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\Home\Privacy.cshtml"
               Write(Html.DisplayNameFor(model => model.TemperatureC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\Home\Privacy.cshtml"
               Write(Html.DisplayNameFor(model => model.Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\Home\Privacy.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\Home\Privacy.cshtml"
                   Write(item.TemperatureC);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\Home\Privacy.cshtml"
                   Write(item.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\nikol\Desktop\OICAR\Kafa\Kafa\Nikola_Projekti\PocketMenuProject\PocketMenuUI\Views\Home\Privacy.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WeatherForecastDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
