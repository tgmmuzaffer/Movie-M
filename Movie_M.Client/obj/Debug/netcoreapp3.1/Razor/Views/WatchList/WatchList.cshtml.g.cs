#pragma checksum "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40d0f35496ab31ea1d9b789f66ebdf60350ce47c"
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
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\_ViewImports.cshtml"
using Movie_M.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
using Movie_M.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
using Movie_M.Client.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d0f35496ab31ea1d9b789f66ebdf60350ce47c", @"/Views/WatchList/WatchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312fb940a52337541805c6bed1987e97345363f0", @"/Views/_ViewImports.cshtml")]
    public class Views_WatchList_WatchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    bool IsSign = true;
}
else
{
    bool IsSign = false;
}

#line default
#line hidden
#nullable disable
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
#line 35 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
   if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-page-area pd-bottom-80\" style=\"background-color: #102950\">\r\n            <div class=\"container\">\r\n                <h1 class=\"ptitle\">");
#nullable restore
#line 39 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
                              Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"row\">\r\n                    <h2 style=\"color:white;\">Your Watch List is Empty</h2>\r\n                    <a href=\"/\"></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
    }
    if (Model != null && Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-page-area pd-bottom-80\" style=\"background-color: #102950\">\r\n            <div class=\"container\">\r\n                <h1 class=\"ptitle\">");
#nullable restore
#line 51 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
                              Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 53 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 1974, "\"", 1992, 1);
#nullable restore
#line 62 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
WriteAttributeValue("", 1980, item.Poster, 1980, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\" style=\"max-height:450px;\" />\r\n                                                    <a");
            BeginWriteAttribute("id", " id=\"", 2088, "\"", 2105, 1);
#nullable restore
#line 63 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
WriteAttributeValue("", 2093, item.imdbID, 2093, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tag-base tag-red\" onclick=\"throwtotrash(this.id)\"><i class=\"fa fa-trash\" aria-hidden=\"true\"></i></a>\r\n                                                    <a");
            BeginWriteAttribute("id", " id=\"", 2270, "\"", 2287, 1);
#nullable restore
#line 64 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
WriteAttributeValue("", 2275, item.imdbID, 2275, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""tag-base-bell tag-green"" onclick=""sendNotify(this.id)""><i class=""fa fa-bell"" aria-hidden=""true""></i></a>
                                                </div>
                                                <div class=""details"">
                                                    <div class=""post-meta-single"">
                                                        <ul>
                                                            <li style=""color:white;""><i class=""fa fa-clock-o""></i>");
#nullable restore
#line 69 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
                                                                                                             Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li style=\"color:white;\"><i class=\"fa fa-user\"></i>");
#nullable restore
#line 70 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
                                                                                                          Write(item.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                        </ul>\r\n                                                    </div>\r\n                                                    <h6 class=\"title mt-2\" style=\"color:white;\"><a");
            BeginWriteAttribute("href", " href=\"", 3157, "\"", 3191, 2);
            WriteAttributeValue("", 3164, "search-imdb-id/", 3164, 15, true);
#nullable restore
#line 73 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
WriteAttributeValue("", 3179, item.imdbID, 3179, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"
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
#line 81 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 87 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\WatchList\WatchList.cshtml"

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
                window.location.assign('/Watch-List');
                alert('Removed Successfully');
            }
            else {
                alert('Somthink Went Wrong Please Call Muzaffer');
            }
        }
    }
    function sendNotify(id) {
        var value = JSON.stringify(id);
        var xhr = new XMLHttpRequest;
        xhr.open('POST', '/sendNotify');
        xhr.setRequestHeader('Content-type', 'application/json;')
        xhr.responseType = 'JSON';
        xhr.send(value);
        xhr.onload = function () {
            if (xhr.status == 200) {
                window.location.a");
            WriteLiteral("ssign(\'/Watch-List\');\r\n                alert(\'Your Notify is Successfully Recorded\');\r\n            }\r\n            else {\r\n                alert(\'Somthink Went Wrong Please Call Muzaffer\');\r\n            }\r\n        }\r\n    }\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Movie_MClientUser> SignInManager { get; private set; }
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
