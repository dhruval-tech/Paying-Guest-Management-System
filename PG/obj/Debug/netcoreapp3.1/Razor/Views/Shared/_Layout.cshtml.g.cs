#pragma checksum "D:\Dhruval\github\Paying-Guest-Management-System\PG\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9eb8f101dee7e27edf973815dcfc77f2172635c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Dhruval\github\Paying-Guest-Management-System\PG\Views\_ViewImports.cshtml"
using PG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dhruval\github\Paying-Guest-Management-System\PG\Views\_ViewImports.cshtml"
using PG.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9eb8f101dee7e27edf973815dcfc77f2172635c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b6645c42cf617ede8d0f1608bf523a59ecbfe7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9eb8f101dee7e27edf973815dcfc77f2172635c4274", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""keywords"" content=""hotel, bed and breakfast, accommodations, travel, motel"">
    <meta name=""description"" content=""FC Recom - Hotel and Bed&amp;Breakfast"">
    <meta name=""author"" content=""Ansonika"">
    <title>FC Recom - Hotel and Bed&amp;Breakfast</title>

    <!-- Favicons-->
    <link rel=""shortcut icon"" href=""img/favicon.ico"" type=""/image/x-icon"">
    <link rel=""apple-touch-icon"" type=""image/x-icon"" href=""/img/apple-touch-icon-57x57-precomposed.png"">
    <link rel=""apple-touch-icon"" type=""image/x-icon"" sizes=""72x72"" href=""/img/apple-touch-icon-72x72-precomposed.png"">
    <link rel=""apple-touch-icon"" type=""image/x-icon"" sizes=""114x114"" href=""/img/apple-touch-icon-114x114-precomposed.png"">
    <link rel=""apple-touch-icon"" type=""image/x-icon"" sizes=""144x144"" href=""/img/apple-touch-icon-144x144-precomposed.png"">

    <!-");
                WriteLiteral(@"- BASE CSS -->
    <link href=""/css/base.css"" rel=""stylesheet"">

    <!-- SPECIFIC CSS -->
    <link rel=""stylesheet"" type=""text/css"" href=""/css/DateTimePicker.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/owl.carousel.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/owl.theme.default.css"">

    <!--[if lt IE 9]>
      <script src=""js/html5shiv.min.js""></script>
      <script src=""js/respond.min.js""></script>
    <![endif]-->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9eb8f101dee7e27edf973815dcfc77f2172635c6850", async() => {
                WriteLiteral(@"
    <!-- Header ================================================== -->
    <header>
        <div class=""container"">
            <div class=""row"">
                <div class=""col--md-3 col-sm-3 col-xs-3"">
                    <a href=""index.html"" id=""logo"">
                        <img src=""/img/logo.png"" width=""190"" height=""23""");
                BeginWriteAttribute("alt", " alt=\"", 1885, "\"", 1891, 0);
                EndWriteAttribute();
                WriteLiteral(" data-retina=\"true\" class=\"logo_normal\">\r\n                        <img src=\"/img/logo_sticky.png\" width=\"190\" height=\"23\"");
                BeginWriteAttribute("alt", " alt=\"", 2013, "\"", 2019, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-retina=""true"" class=""logo_sticky"">
                    </a>
                </div>
                <nav class=""col--md-9 col-sm-9 col-xs-9"">
                    <a class=""cmn-toggle-switch cmn-toggle-switch__htx open_close"" href=""javascript:void(0);""><span>Menu mobile</span></a>
                    <ul id=""lang_top"">
                        <li><a href=""#"" class=""active"">EN</a></li>
                        <li><a href=""#"">FR</a></li>
                        <li><a href=""#"">ES</a></li>
                    </ul>
                    <div class=""main-menu"">
                        <div id=""header_menu"">
                            <img src=""/img/logo_m.png"" width=""141"" height=""40""");
                BeginWriteAttribute("alt", " alt=\"", 2723, "\"", 2729, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-retina=""true"">
                        </div>
                        <a href=""#"" class=""open_close"" id=""close_in""><i class=""icon_set_1_icon-77""></i></a>
                        <ul>
                            <li class=""submenu"">
                                <a href=""javascript:void(0);"" class=""show-submenu"">Home<i class=""icon-down-open-mini""></i></a>
                                <ul>
                                    <li><a href=""index.html"">Home Booking</a></li>
                                    <li><a href=""index_5.html"">Home Booking date 2</a></li>
                                    <li><a href=""index_4.html"">Home Carousel</a></li>
                                    <li><a href=""index_2.html"">Home Layer Slider</a></li>
                                    <li><a href=""index_6.html"">Home Video bg</a></li>
                                    <li><a href=""index_3.html"">Home Text Rotator</a></li>
                                </ul>
                            </li>
        ");
                WriteLiteral(@"                    <li><a href=""room_list.html"">Rooms</a></li>
                            <li class=""submenu"">
                                <a href=""javascript:void(0);"" class=""show-submenu"">Pages<i class=""icon-down-open-mini""></i></a>
                                <ul>
                                    <li><a href=""../index.html"">Header plain</a></li>
                                    <li><a href=""room_detail.html"">Room detail</a></li>
                                    <li><a href=""room_detail_2.html"">Room detail date 2</a></li>
                                    <li><a href=""about.html"">About us</a></li>
                                    <li><a href=""faq.html"">Faq</a></li>
                                    <li><a href=""gallery.html"">Gallery</a></li>
                                    <li><a href=""blog.html"">Blog</a></li>
                                    <li><a href=""coming_soon/index.html"">Site launch/Coming soon</a></li>
                                    <li><a href=""sho");
                WriteLiteral(@"rtcodes.html"">Shortcodes</a></li>
                                    <li><a href=""icon_pack_1.html"">Icon pack 1</a></li>
                                    <li><a href=""icon_pack_2.html"">Icon pack 2</a></li>
                                    <li><a href=""icon_pack_3.html"">Icon pack 3</a></li>
                                </ul>
                            </li>
                            <li><a href=""contacts.html"">Contacts</a></li>
                            <li><a href=""http://freecssthemes.com/website-templates/"">Purchase this template</a></li>
                        </ul>
                    </div><!-- End main-menu -->
                </nav>
            </div><!-- End row -->
        </div><!-- End container -->
    </header>
    <!-- End Header =============================================== -->

    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 98 "D:\Dhruval\github\Paying-Guest-Management-System\PG\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2021 - PG - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9eb8f101dee7e27edf973815dcfc77f2172635c12279", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
    </footer>
    <!-- COMMON SCRIPTS -->
    <script src=""/js/jquery-1.11.2.min.js""></script>
    <script src=""/js/common_scripts_min.js""></script>
    <script src=""/assets/validate.js""></script>
    <script src=""/js/functions.js""></script>

    <script type=""text/javascript"" src=""/js/DateTimePicker.js""></script>
    <script type=""text/javascript"">$(""#dtBox"").DateTimePicker();</script>
    ");
#nullable restore
#line 115 "D:\Dhruval\github\Paying-Guest-Management-System\PG\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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