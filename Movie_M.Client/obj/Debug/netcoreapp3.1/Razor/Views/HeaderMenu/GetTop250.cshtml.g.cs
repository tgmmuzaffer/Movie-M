#pragma checksum "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "853b6542b25e6dd353412a04398ff2b4cb1bce8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HeaderMenu_GetTop250), @"mvc.1.0.view", @"/Views/HeaderMenu/GetTop250.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
using Movie_M.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"853b6542b25e6dd353412a04398ff2b4cb1bce8d", @"/Views/HeaderMenu/GetTop250.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312fb940a52337541805c6bed1987e97345363f0", @"/Views/_ViewImports.cshtml")]
    public class Views_HeaderMenu_GetTop250 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Imdblist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .cumtomize-item {\r\n        font-size: 124px;\r\n        color: #A2DBFA;\r\n        opacity: 0.2;\r\n    }\r\n\r\n    .ptitle {\r\n        margin-left: 7%;\r\n        margin-top: 1%;\r\n    }\r\n</style>\r\n\r\n<h1 class=\"ptitle\">");
#nullable restore
#line 17 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
              Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 18 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
 foreach (var item in Model.items)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"single-post-list-wrap style-two\" style=\"background-color:aliceblue;\">\r\n        <div class=\"media\">\r\n            <div class=\"media-left mt-2 ml-2\">\r\n                <img loading=\"lazy\" style=\"height:200px;\"");
            BeginWriteAttribute("src", " src=\"", 550, "\"", 567, 1);
#nullable restore
#line 23 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
WriteAttributeValue("", 556, item.image, 556, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\">\r\n            </div>\r\n            <div class=\"media-body align-self-center\">\r\n                <div class=\"details\">\r\n                    <h4 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 736, "\"", 767, 2);
            WriteAttributeValue("", 743, "/search-imdb-id/", 743, 16, true);
#nullable restore
#line 27 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
WriteAttributeValue("", 759, item.id, 759, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
                                                                    Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    <div class=\"post-meta-single\">\r\n                        <ul>\r\n                            <li><b>Imdb Rate: </b>");
#nullable restore
#line 30 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
                                             Write(item.imDbRating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        </ul>\r\n                        <ul>\r\n                            <li><b>Rate Count: </b>");
#nullable restore
#line 33 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
                                              Write(item.imDbRatingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        </ul>\r\n                    </div>\r\n                    <p>");
#nullable restore
#line 36 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
                  Write(item.crew);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"media-body align-self-center\">\r\n                <div class=\"cumtomize-item\">");
#nullable restore
#line 40 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
                                       Write(item.rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 44 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\HeaderMenu\GetTop250.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Imdblist> Html { get; private set; }
    }
}
#pragma warning restore 1591
