#pragma checksum "C:\Users\Jakov\Documents\Kafa-Newest\yeet\OicarProject\PocketMenuProject\PocketMenuUI\Views\GoogleMaps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbbc487613afa358efecb3e0f6a538cb48141398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GoogleMaps_Index), @"mvc.1.0.view", @"/Views/GoogleMaps/Index.cshtml")]
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
#line 1 "C:\Users\Jakov\Documents\Kafa-Newest\yeet\OicarProject\PocketMenuProject\PocketMenuUI\Views\_ViewImports.cshtml"
using PocketMenuUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jakov\Documents\Kafa-Newest\yeet\OicarProject\PocketMenuProject\PocketMenuUI\Views\_ViewImports.cshtml"
using PocketMenuUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jakov\Documents\Kafa-Newest\yeet\OicarProject\PocketMenuProject\PocketMenuUI\Views\_ViewImports.cshtml"
using PocketMenuUI.Models.ModelsDTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbc487613afa358efecb3e0f6a538cb48141398", @"/Views/GoogleMaps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643f081494c3f5d7a6a09193402a1101c5f19e4e", @"/Views/_ViewImports.cshtml")]
    public class Views_GoogleMaps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GoogleMaps", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Disqus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jakov\Documents\Kafa-Newest\yeet\OicarProject\PocketMenuProject\PocketMenuUI\Views\GoogleMaps\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"map\" style=\"width: 400px; height: 400px;\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbc487613afa358efecb3e0f6a538cb481413984756", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbbc487613afa358efecb3e0f6a538cb481413986121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
        var map;
        function initMap() {
         var myLatLng = {lat: 43.736938, lng: 15.898590};

         var map = new google.maps.Map(document.getElementById('map'), {
           zoom: 4,
           center: myLatLng
         });
        $.get(""");
#nullable restore
#line 19 "C:\Users\Jakov\Documents\Kafa-Newest\yeet\OicarProject\PocketMenuProject\PocketMenuUI\Views\GoogleMaps\Index.cshtml"
          Write(Url.Action("GetAllLocation", "GoogleMaps"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
        function(data,status) {
          var marker = [];
           var contentString =[];
            var infowindow=[];
          for(var i=0;i<data.length;i++)
            {
                    marker[i] = new google.maps.Marker({
                    position: {lat:data[i].lat, lng: 
                    data[i].long}, map: map});
                               contentString[i] = '<div ' +
                                'id=""content"">'+
                              '<div id=""siteNotice"">'+
                              '</div>'+
                              '<h1 id=""firstHeading"" class=""firstHeading"">Uluru</h1>'+
                              '<div id=""bodyContent"">'+
                              '<p><b>Uluru</b>, also ' +
                               'referred to as <b>Ayers ' +
                                'Rock</b>Address:</p>'+
                                data[i].address+ 
                                '<p>Attribution: Uluru, <a href=""https://en.wikipedia.org/w/in");
            WriteLiteral(@"dex.php?title=Uluru&oldid=297882194"">'+
                              'https://en.wikipedia.org/w/index.php?title=Uluru</a> '+
                              '(last visited June 22, 2009).</p>'+
                              '</div>'+
                              '</div>';
                                infowindow[i] = new google
                                .maps.InfoWindow({
                                  content: contentString[i]
                                });
              var mdl = marker[i];
              google.maps.event.addListener(marker[i], 'click', (function (mdl, i) {
                  return function () {
                      infowindow[i].open(map, marker[i]);
                  }
              })(marker[i], i));
            }

        });

        }
</script>
<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDQZjR53_GfS-tlqD5xV50sf8rKYB2C4S8&callback=initMap"" async defer></script>");
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
