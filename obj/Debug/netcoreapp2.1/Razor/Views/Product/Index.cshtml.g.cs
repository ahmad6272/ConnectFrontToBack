#pragma checksum "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd4997fddf427aa0298898edc75b977328ebf650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\_ViewImports.cshtml"
using ConnectFrontToBack.Models;

#line default
#line hidden
#line 2 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\_ViewImports.cshtml"
using ConnectFrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4997fddf427aa0298898edc75b977328ebf650", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de097494db60c295e3738965279314c1f6765b9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProductPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(72, 378, true);
            WriteLiteral(@"
<main>
    <!-- begin name -->
    <div class=""container col-12 mt-4"">
        <div class=""row"">
            <div class=""shop_list"">
                <h1>Product List</h1>
                <span>Where flowers are our inspiration</span>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row mt-5 ml-2 mainList"">
            ");
            EndContext();
            BeginContext(450, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "155cbce4e6b34dc882b1148e5fb348e1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(482, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(545, 66, true);
            WriteLiteral("        </div>\r\n        <div class=\"row justify-content-center\">\r\n");
            EndContext();
            BeginContext(701, 91, true);
            WriteLiteral("            <nav aria-label=\"...\">\r\n                <ul class=\"pagination pagination-sm\">\r\n");
            EndContext();
#line 25 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                     for (int i = 1; i <= ViewBag.PageCount; i++)
                    {
                        if (ViewBag.Page == null)
                        {
                            if (i == 1)
                            {

#line default
#line hidden
            BeginContext(1032, 83, true);
            WriteLiteral("                                <li class=\"page-item disabled\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1115, "\"", 1144, 2);
            WriteAttributeValue("", 1122, "/product/index?page=", 1122, 20, true);
#line 31 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
WriteAttributeValue("", 1142, i, 1142, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1145, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1147, 1, false);
#line 31 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                                                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 32 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1255, 75, true);
            WriteLiteral("                                <li class=\"page-item \"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1330, "\"", 1359, 2);
            WriteAttributeValue("", 1337, "/product/index?page=", 1337, 20, true);
#line 35 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
WriteAttributeValue("", 1357, i, 1357, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1360, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1362, 1, false);
#line 35 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                                                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1363, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 36 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                            }
                        }
                        else
                        {
                            if (i == ViewBag.Page)
                            {

#line default
#line hidden
            BeginContext(1572, 83, true);
            WriteLiteral("                                <li class=\"page-item disabled\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1655, "\"", 1684, 2);
            WriteAttributeValue("", 1662, "/product/index?page=", 1662, 20, true);
#line 42 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
WriteAttributeValue("", 1682, i, 1682, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1685, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1687, 1, false);
#line 42 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                                                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 43 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1795, 75, true);
            WriteLiteral("                                <li class=\"page-item \"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1870, "\"", 1899, 2);
            WriteAttributeValue("", 1877, "/product/index?page=", 1877, 20, true);
#line 46 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
WriteAttributeValue("", 1897, i, 1897, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1900, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1902, 1, false);
#line 46 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                                                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1903, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 47 "C:\Users\Ahmad Dadashzada\Desktop\ConnectFrontToBack\Views\Product\Index.cshtml"
                            }
                        }

                    }

#line default
#line hidden
            BeginContext(1997, 114, true);
            WriteLiteral("                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n        <!-- finish name -->\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
