#pragma checksum "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61bcd1e68b63ad2d9c46d670084ecc3f9f86545c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LastSearched_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LastSearched/Default.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\_ViewImports.cshtml"
using Movie_M.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
using Movie_M.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61bcd1e68b63ad2d9c46d670084ecc3f9f86545c", @"/Views/Shared/Components/LastSearched/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312fb940a52337541805c6bed1987e97345363f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LastSearched_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
  
    if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <div class=""section-title style-two"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        <h3 class=""title"" style=""color:white"">Last Investigation</h3>
                    </div>

                </div>
            </div>
        </div>
        <div class=""tranding-area pd-top-25 pd-bottom-50 post-slider post-slider owl-carousel owl-loaded owl-drag"">
            <div class=""container"">
                <div class=""tab-content"" id=""ex2-content"">
                    <div class=""tab-pane fade show active"" id=""ex2-tabs-1"" role=""tabpanel"">
                        <div class=""row"">
");
#nullable restore
#line 22 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-3 col-sm-6 "">
                                    <div class=""single-post-wrap style-overlay"">
                                        <div class=""thumb"">
                                            <img loading=""lazy"" style=""width:70%""");
            BeginWriteAttribute("src", " src=\"", 1160, "\"", 1178, 1);
#nullable restore
#line 27 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
WriteAttributeValue("", 1166, item.Poster, 1166, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\">\r\n                                            <a class=\"tag-base tag-green\">");
#nullable restore
#line 28 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
                                                                     Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </div>
                                        <div class=""details"">
                                            <div class=""post-meta-single"">
                                                <ul>
                                                    <li><i class=""fa fa-clock-o""></i>");
#nullable restore
#line 33 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
                                                                                Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                    <li><i class=\"fa fa-user\"></i>");
#nullable restore
#line 34 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
                                                                             Write(item.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                </ul>\r\n                                            </div>\r\n                                            <h6 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 1898, "\"", 1932, 2);
            WriteAttributeValue("", 1905, "search-imdb-id/", 1905, 15, true);
#nullable restore
#line 37 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
WriteAttributeValue("", 1920, item.imdbID, 1920, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
                                                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h6>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 41 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 69 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
                    
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""tranding-area pd-top-75 pd-bottom-50"">
            <div class=""container"">
                <div class=""section-title style-two"">
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <h6 class=""title"">Watch List</h6>
                        </div>

                    </div>
                </div>
                <div class=""tab-content"" id=""ex2-content"">
                    <div class=""tab-pane fade show active"" id=""ex2-tabs-1"" role=""tabpanel"">
                        <div class=""row"">
                            <h4>Your List Empty Now!</h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 96 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\Shared\Components\LastSearched\Default.cshtml"
                    
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
