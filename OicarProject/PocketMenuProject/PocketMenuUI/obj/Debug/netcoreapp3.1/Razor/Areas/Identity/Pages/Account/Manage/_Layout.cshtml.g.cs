#pragma checksum "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b13779e1f59d37fada1de937b7ee1735ad9f21cc"
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
#line 1 "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\_ViewImports.cshtml"
using PocketMenuUI.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\_ViewImports.cshtml"
using PocketMenuUI.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PocketMenuUI.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using PocketMenuUI.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b13779e1f59d37fada1de937b7ee1735ad9f21cc", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae69fee8f4164f571fee624161213f0661e8675", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51883d23c721ec29d938f8cf5d7d1fb9455183f9", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0035e1ab64a23ddf914d638043f4776e6553c7f", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
    Layout = "/Areas/Identity/Pages/Account/Manage/_LayoutManage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""card teal"" style=""padding-top:1%;padding-bottom:2%;margin-top:2%"">
        <h3 class=""white-text center font-weight-bold"">Account Management</h3>
    </div>
</div>

<div>
    <div class=""row container center"" style=""min-height:55vh"">
        <div class=""col-md-8"">
            ");
#nullable restore
#line 13 "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\Jakov\Documents\Kafa-Newest\Kafa\OicarProject\PocketMenuProject\PocketMenuUI\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
