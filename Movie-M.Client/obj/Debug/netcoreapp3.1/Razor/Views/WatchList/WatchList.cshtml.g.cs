#pragma checksum "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d291d88a56fde9f120a47707b94ae3d2eb221c9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WatchList_WatchList), @"mvc.1.0.view", @"/Views/WatchList/WatchList.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
using Movie_M.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d291d88a56fde9f120a47707b94ae3d2eb221c9b", @"/Views/WatchList/WatchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312fb940a52337541805c6bed1987e97345363f0", @"/Views/_ViewImports.cshtml")]
    public class Views_WatchList_WatchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .ptitle {
        margin-left: 9%;
        padding-top: 1%;
        padding-bottom: 1%;
        color: white;
    }

    fa-trash-o {
        display: block;
        color: darkorange;
        font-size: xx-large;
        z-index: 999;
    }

        fa-trash-o:hover {
            color: darkred;
            z-index: 999;
        }
</style>
");
#nullable restore
#line 23 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
   if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-page-area pd-bottom-80\" style=\"background-color: #102950\">\r\n            <div class=\"container\">\r\n                <h1 class=\"ptitle\">");
#nullable restore
#line 27 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
                              Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"row\">\r\n                    <h2 style=\"color:white;\">Your Watch List is Empty</h2>\r\n                    <a href=\"/\"></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
    }
    if (Model != null && Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-page-area pd-bottom-80\" style=\"background-color: #102950\">\r\n            <div class=\"container\">\r\n                <h1 class=\"ptitle\">");
#nullable restore
#line 39 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
                              Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 41 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-3"">
                            <div class=""blog-details-page-inner"">
                                <div class=""related-post"">
                                    <div class=""row justify-content-center"">
                                        <div class=""col-lg-12 col-md-6"">
                                            <div class=""single-post-wrap"">
                                                <div class=""thumb"">
                                                    <img loading=""lazy""");
            BeginWriteAttribute("src", " src=\"", 1728, "\"", 1746, 1);
#nullable restore
#line 50 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
WriteAttributeValue("", 1734, item.Poster, 1734, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\" style=\"max-height:450px;\" />\r\n                                                    <a");
            BeginWriteAttribute("id", " id=\"", 1842, "\"", 1859, 1);
#nullable restore
#line 51 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
WriteAttributeValue("", 1847, item.imdbID, 1847, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""tag-base tag-red"" onclick=""throwtotrash(this.id)""><i class=""fa fa-trash-o"" aria-hidden=""true""></i></a>
                                                </div>
                                                <div class=""details"">
                                                    <div class=""post-meta-single"">
                                                        <ul>
                                                            <li style=""color:white;""><i class=""fa fa-clock-o""></i>");
#nullable restore
#line 56 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
                                                                                                             Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li style=\"color:white;\"><i class=\"fa fa-user\"></i>");
#nullable restore
#line 57 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
                                                                                                          Write(item.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                        </ul>\r\n                                                    </div>\r\n                                                    <h6 class=\"title mt-2\" style=\"color:white;\"><a");
            BeginWriteAttribute("href", " href=\"", 2727, "\"", 2761, 2);
            WriteAttributeValue("", 2734, "search-imdb-id/", 2734, 15, true);
#nullable restore
#line 60 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
WriteAttributeValue("", 2749, item.imdbID, 2749, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"
                                                                                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h6>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 68 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 74 "C:\Users\MONSTER\source\repos\Movie-M\Movie-M.Client\Views\WatchList\WatchList.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    function throwtotrash(id) {
        var value = JSON.stringify(id);
        var xhr = new XMLHttpRequest;
        xhr.open('POST', '/deletefromlist');
        xhr.setRequestHeader('Content-type', 'application/json;')
        xhr.responseType = 'JSON';
        xhr.send(value);
        xhr.onload = function () {
            if (xhr.status == 200) {
                window.location('/Watch-List');
                alert('Removed Successfully');
            }
            else {
                alert('Somthink Went Wrong');
            }
        }
    }
</script>");
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
