#pragma checksum "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c37374fea29965db6913658149d413a812353cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
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
#line 1 "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\_ViewImports.cshtml"
using PocketMenuUI.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\_ViewImports.cshtml"
using PocketMenuUI.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PocketMenuUI.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using PocketMenuUI.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37374fea29965db6913658149d413a812353cc7", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4fc09e9e5b2c8b8dc7c849dd1865f7c0f8793c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51883d23c721ec29d938f8cf5d7d1fb9455183f9", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c60074bc8f40d4b333cd64fd443e9323060991", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
    Layout = "/Areas/Identity/Pages/Account/Manage/_LayoutManage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Manage your account</h1>\n\n<div>\n    <h4>Change your account settings</h4>\n    <hr />\n    <div class=\"row container center\">\n        <div class=\"col-md-8\">\n            ");
#nullable restore
#line 12 "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 18 "C:\Users\koweratus\Desktop\OICAR\Kafa\Mate_Projekti\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
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