#pragma checksum "C:\Users\Ahmad Dadashzada\source\repos\ConnectFrontToBack\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d97368ce752af3b45e372eab72c7d0ad633ade11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Header/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Header_Default))]
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
#line 1 "C:\Users\Ahmad Dadashzada\source\repos\ConnectFrontToBack\Views\_ViewImports.cshtml"
using ConnectFrontToBack.Models;

#line default
#line hidden
#line 2 "C:\Users\Ahmad Dadashzada\source\repos\ConnectFrontToBack\Views\_ViewImports.cshtml"
using ConnectFrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d97368ce752af3b45e372eab72c7d0ad633ade11", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de097494db60c295e3738965279314c1f6765b9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 279, true);
            WriteLiteral(@"<header>
    <!-- begin navbar -->
    <div class=""container mt-5 mb-4"">
        <nav>
            <div class=""row col-12"">
                <!-- logo -->
                <div class=""logo col-3 px-0 mx-0"">
                    <a href=""final.html"">
                        ");
            EndContext();
            BeginContext(291, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "13599403609c492b92bc66047198aa2b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 315, "~/image/logo/", 315, 13, true);
#line 10 "C:\Users\Ahmad Dadashzada\source\repos\ConnectFrontToBack\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 328, Model.Logo, 328, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(341, 4136, true);
            WriteLiteral(@"
                    </a>
                </div>
                <!-- menu -->
                <div id=""menu"" class=""col-9 px-0 mx-0"">
                    <ul class=""menu"">
                        <li class=""nav-elm-item home"">
                            <a href=""#"">HOME</a>
                            <div class=""home_menu elm-collapsed"">
                                <div class=""drop_home_menu"">
                                    <ul>
                                        <li><a href=""#"">Main Home</a></li>
                                        <li><a href=""#"">Grid Home</a></li>
                                        <li><a href=""#"">Flower Shop</a></li>
                                        <li><a href=""#"">Animated Slider</a></li>
                                        <li><a href=""#"">Metro Showcase</a></li>
                                        <li><a href=""#"">Carousel</a></li>
                                        <li><a href=""#"">Landing</a></li>
                          ");
            WriteLiteral(@"          </ul>
                                </div>
                            </div>
                        </li>
                        <li class=""nav-elm-item page"">
                            <a href=""#"">PAGES</a>
                            <div class=""page_menu elm-collapsed"">
                                <div class=""drop_pages_menu"">
                                    <ul>
                                        <li><a href=""#"">About Us</a></li>
                                        <li><a href=""#"">FAQ Page</a></li>
                                        <li><a href=""#"">Contact Us</a></li>
                                    </ul>
                                </div>
                            </div>
                        </li>
                        <li class=""nav-elm-item shop"">
                            <a href=""#"">SHOP</a>
                            <div class=""shop_menu elm-collapsed"" style=""width: 1100px; left: -500px;"">
                                <d");
            WriteLiteral(@"iv class=""drop_shop_menu"">
                                    <div class=""d-flex justify-content-around"">
                                        <h5>
                                            Product Types
                                            <ul class=""mt-3"">
                                                <li><a href=""#"">Standard Product</a></li>
                                                <li><a href=""#"">Grouped Product</a></li>
                                                <li><a href=""#"">Variable Product</a></li>
                                                <li><a href=""#"">Virtual Product</a></li>
                                                <li><a href=""#"">External Product</a></li>
                                                <li><a href=""#"">Downloadable Product</a></li>
                                                <li><a href=""#"">On Sale Product</a></li>
                                                <li><a href=""#"">Out Of Stock Product</a></li>
              ");
            WriteLiteral(@"                                  <li><a href=""#"">New Product</a></li>

                                            </ul>
                                        </h5>
                                        <h5>
                                            Shop Pages
                                            <ul class=""mt-3"">
                                                <li><a href=""#"">My Accaunt</a></li>
                                                <li><a href=""#"">Cart</a></li>
                                                <li><a href=""#"">Checkout</a></li>
                                                <li><a href=""#"">Orders</a></li>
                                                <li><a href=""#"">Downloads</a></li>
                                            </ul>
                                        </h5>
                                        <h5>
                                            Shop Types
                                            <ul class=""mt-3"">
            ");
            WriteLiteral("                                    <li>");
            EndContext();
            BeginContext(4477, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0252b39a9824a28ae8dd9c7dee0d2d0", async() => {
                BeginContext(4524, 12, true);
                WriteLiteral("Product List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            EndContext();
            BeginContext(4540, 4303, true);
            WriteLiteral(@"</li>
                                                <li><a href=""#"">Without Slidebar</a></li>
                                                <li><a href=""#"">With Category Filter</a></li>
                                                <li><a href=""#"">With Ordering Filter</a></li>
                                                <li><a href=""#"">Shop Carousel</a></li>
                                                <li><a href=""#"">Product Categories</a></li>
                                                <li><a href=""#"">Single Category</a></li>
                                            </ul>
                                        </h5>
                                        <h5>
                                            Shop Layouts
                                            <ul class=""mt-3"">
                                                <li><a href=""#"">Two Columns Grid</a></li>
                                                <li><a href=""#"">Three Columns Grid</a></li>
                ");
            WriteLiteral(@"                                <li><a href=""#"">Four Columns Grid</a></li>
                                                <li><a href=""#"">Four Columns Wide</a></li>
                                                <li><a href=""#"">Five Columns Wide</a></li>
                                                <li><a href=""#"">Six Columns Wide</a></li>
                                            </ul>
                                        </h5>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li class=""nav-elm-item portfolio"">
                            <a href=""#"">PORTFOLIO</a>
                            <div class=""portfolio_menu elm-collapsed"">
                                <div class=""drop_portfolio_menu"">
                                    <ul>
                                        <li><a href=""#"">Standard</a></li>
                                        <li><a href=");
            WriteLiteral(@"""#"">Gallery</a></li>
                                        <li><a href=""#"">Masonly</a></li>
                                        <li><a href=""#"">Portfolio Layouts</a></li>
                                        <li><a href=""#"">Partfolio Single</a></li>
                                    </ul>
                                </div>
                            </div>
                        </li>
                        <li class=""nav-elm-item blog"">
                            <a href=""#"">BLOG</a>
                            <div class=""blog_menu elm-collapsed"">
                                <div class=""drop_blog_menu"">
                                    <ul>
                                        <li><a href=""#"">Masonry</a></li>
                                        <li><a href=""#"">Standart</a></li>
                                        <li><a href=""#"">Post Types</a></li>
                                    </ul>
                                </div>
                         ");
            WriteLiteral(@"   </div>
                        </li>
                        <li class=""nav-elm-item elm"">
                            <a href=""#"">ELEMENTS</a>
                            <div class=""elements_menu elm-collapsed"">
                                <div class=""drop_elements_menu"">
                                    <ul>
                                        <li><a href=""#"">Classic</a></li>
                                        <li><a href=""#"">Infographic</a></li>
                                        <li><a href=""#"">Interactive</a></li>
                                        <li><a href=""#"">Typography</a></li>
                                    </ul>
                                </div>
                            </div>
                        </li>
                        <li class=""nav-elm-item search""> <i class=""fas fa-search""></i> </li>
                        <li class=""nav-elm-item shopping_bag"">
                            <i class=""fas fa-shopping-bag""></i>
              ");
            WriteLiteral("              <a href=\"\">CART($0)</a>\r\n                        </li>\r\n                    </ul>\r\n\r\n                </div>\r\n            </div>\r\n        </nav>\r\n\r\n    </div>\r\n    <!-- end navbar -->\r\n</header>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
