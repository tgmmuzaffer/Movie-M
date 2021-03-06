#pragma checksum "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "857f8110b83580101c9205bfebced7e019312b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
using Movie_M.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857f8110b83580101c9205bfebced7e019312b6a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312fb940a52337541805c6bed1987e97345363f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <style>
        .post-slider .owl-nav {
            display: none;
        }
    </style>

    <div class=""banner-area banner-inner-1 bg-black"" id=""banner"">
        <!-- banner area start -->
        <div class=""banner-inner pt-5 mb-xl-5"">
            <div class=""container post-slider post-slider owl-carousel owl-loaded owl-drag"">
");
#nullable restore
#line 13 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                 foreach (var item in Model.OrderByDescending(a => a.imdbRating))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row \">\r\n                        <div class=\"col-lg-4\">\r\n                            <div class=\"thumb after-left-top\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 687, "\"", 705, 1);
#nullable restore
#line 18 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 693, item.Poster, 693, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""img"">
                            </div>
                        </div>
                        <div class=""col-lg-4 align-self-center"">
                            <div class=""banner-details mt-4 mt-lg-0"">
                                <div class=""post-meta-single"">
                                    <ul>
");
#nullable restore
#line 25 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                          
                                            var genrelist = item.Genre.Split(",");
                                            foreach (var itemG in genrelist)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li><a class=\"tag-base tag-blue\" href=\"#\">");
#nullable restore
#line 29 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                                                                     Write(itemG);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 30 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <li class=\"date\"><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 33 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                                                                 Write(item.Released);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                                <h2>");
#nullable restore
#line 36 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 37 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                 if (item.Awards.Contains("N/A"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Not yet any award but we gave awards : ) &nbsp;&nbsp;&nbsp;  <i class=\"fa fa-star\" aria-hidden=\"true\" style=\"font-size: xx-large; color: #FFA900\"></i></p>\r\n");
#nullable restore
#line 40 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 43 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                  Write(item.Awards);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 44 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                 if (!item.Plot.Contains("N/A"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p style=\"width: 600px; overflow:hidden; white-space:nowrap; text-overflow:ellipsis\">");
#nullable restore
#line 47 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                                                                                                    Write(item.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(item.imdbID))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn btn-blue\"");
            BeginWriteAttribute("href", " href=\"", 2664, "\"", 2699, 2);
            WriteAttributeValue("", 2671, "/search-imdb-id/", 2671, 16, true);
#nullable restore
#line 51 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 2687, item.imdbID, 2687, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read More</a>\r\n");
#nullable restore
#line 52 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-lg-4\">\r\n                            <div class=\"banner-details mt-4 mt-lg-0\" style=\"margin-left:150px; line-height:8;\">\r\n");
#nullable restore
#line 58 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                  
                                    if (!string.IsNullOrEmpty(item.imdbRating))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>\r\n                                            <i class=\"fa fa-imdb\" aria-hidden=\"true\" style=\"font-size: xx-large; color: #FFA900\"></i>&nbsp;&nbsp;");
#nullable restore
#line 62 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                                                                                                                            Write(item.imdbRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n");
#nullable restore
#line 64 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <hr style=\"color: #0A1931; border:2px\" />\r\n");
#nullable restore
#line 68 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                  
                                    if (!string.IsNullOrEmpty(item.imdbVotes))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>\r\n                                            <i class=\"fa fa-arrow-up\" aria-hidden=\"true\" style=\"font-size: xx-large; color: #FFA900\"></i>&nbsp;&nbsp;");
#nullable restore
#line 72 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                                                                                                                                Write(item.imdbVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n");
#nullable restore
#line 74 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <hr style=\"color:#0A1931\" />\r\n");
#nullable restore
#line 78 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                  
                                    if (!string.IsNullOrEmpty(item.imdbID))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>\r\n                                            <i class=\"fa fa-info\" aria-hidden=\"true\" style=\"font-size: xx-large; color: #FFA900\"></i>&nbsp;&nbsp;");
#nullable restore
#line 82 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                                                                                                                            Write(item.imdbID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n");
#nullable restore
#line 84 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 90 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
#nullable restore
#line 95 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
          
            this.Context.Request.Cookies.TryGetValue("lastsearched", out string value);

            if (value!=null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("LastSearched", value));

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\MONSTER\source\repos\Movie-M\Movie_M.Client\Views\Home\Index.cshtml"
                                                                   ;
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
