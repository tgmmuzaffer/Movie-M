#pragma checksum "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67efb3dde748095dfc5dff9907d94c1631625eee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExtarnalLinks_GetExtarnalLinks), @"mvc.1.0.view", @"/Views/ExtarnalLinks/GetExtarnalLinks.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\_ViewImports.cshtml"
using Movie_M.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
using Movie_M.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67efb3dde748095dfc5dff9907d94c1631625eee", @"/Views/ExtarnalLinks/GetExtarnalLinks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312fb940a52337541805c6bed1987e97345363f0", @"/Views/_ViewImports.cshtml")]
    public class Views_ExtarnalLinks_GetExtarnalLinks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExtarnaLinks>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
  
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    #td {
        justify-content: end !important;
    }

    #th {
        justify-content: center !important;
    }
</style>
<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center"" style=""margin-top:20px;"">
            <div class=""col-md-6 text-center mb-5"">
                <h2 class=""heading-section"">""");
#nullable restore
#line 21 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                        Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" External Links</h2>
            </div>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-md-6"">
                <div class=""table-wrap"">
                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th id=""th"">Source</th>
                                <th id=""th"">Link</th>
                                <th id=""th"">#</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 37 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                              
                                if (Model.imDb != null && Model.imDb.url != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td id=\"td\">Imdb</td>\r\n                                        <td id=\"td\">");
#nullable restore
#line 42 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                               Write(Model.imDb.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td id=\"td\"><a");
            BeginWriteAttribute("href", " href=\"", 1430, "\"", 1452, 1);
#nullable restore
#line 43 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
WriteAttributeValue("", 1437, Model.imDb.url, 1437, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" target=\"_blank\">Go</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                }
                                if (Model.netflix != null && Model.netflix.url != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td id=\"td\">Netflix</td>\r\n                                        <td id=\"td\">");
#nullable restore
#line 50 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                               Write(Model.netflix.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td id=\"td\"><a");
            BeginWriteAttribute("href", " href=\"", 1948, "\"", 1973, 1);
#nullable restore
#line 51 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
WriteAttributeValue("", 1955, Model.netflix.url, 1955, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" target=\"_blank\">Go</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                }
                                if (Model.officialWebsite != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td id=\"td\">Offical Web site</td>\r\n                                        <td id=\"td\">");
#nullable restore
#line 58 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                               Write(Model.officialWebsite);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td id=\"td\"><a");
            BeginWriteAttribute("href", " href=\"", 2461, "\"", 2490, 1);
#nullable restore
#line 59 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
WriteAttributeValue("", 2468, Model.officialWebsite, 2468, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" target=\"_blank\">Go</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                }


                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
          
            if (Model.wikipediaUrls.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row justify-content-center"" style=""margin-top:20px;"">
                    <div class=""col-md-6 text-center mb-5"">
                        <h2 class=""heading-section"">Wikipedia Data Links</h2>
                    </div>
                </div>
                <div class=""row justify-content-center"">
                    <div class=""col-md-4"">
                        <div class=""table-wrap"">
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th id=""th"">No</th>
                                        <th id=""th"">Language</th>
                                        <th id=""th"">Link</th>
                                    </tr>
                                </thead>
");
#nullable restore
#line 89 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                 foreach (var item in Model.wikipediaUrls)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tbody>\r\n                                        <tr>\r\n                                            <th id=\"th\" scope=\"row\">");
#nullable restore
#line 93 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <td id=\"td\">");
#nullable restore
#line 94 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                                   Write(item.language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td id=\"td\"><a");
            BeginWriteAttribute("href", " href=\"", 4122, "\"", 4138, 1);
#nullable restore
#line 95 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
WriteAttributeValue("", 4129, item.url, 4129, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" target=\"_blank\">");
#nullable restore
#line 95 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                                                                                               Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                        </tr>\r\n                                    </tbody>\r\n");
#nullable restore
#line 98 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
                                    i++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 104 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\ExtarnalLinks\GetExtarnalLinks.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExtarnaLinks> Html { get; private set; }
    }
}
#pragma warning restore 1591
