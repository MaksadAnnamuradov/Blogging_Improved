#pragma checksum "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c43575d3df22992ac9567ff705200e08dc51b33c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_PostCategory), @"mvc.1.0.view", @"/Views/Blog/PostCategory.cshtml")]
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
#line 1 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\_ViewImports.cshtml"
using HW_03;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\_ViewImports.cshtml"
using HW_03.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43575d3df22992ac9567ff705200e08dc51b33c", @"/Views/Blog/PostCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2044a697f0387be3541a35af65349c1a1b57f996", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_PostCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostCatRel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
  
    ViewData["Title"] = "PostCategory";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43575d3df22992ac9567ff705200e08dc51b33c5363", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Detail</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c43575d3df22992ac9567ff705200e08dc51b33c5719", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43575d3df22992ac9567ff705200e08dc51b33c7601", async() => {
                WriteLiteral("\r\n\r\n    <table class=\"table table-bordered table-striped table-sm\">\r\n        <thead>\r\n            <tr><th>Title</th> <th>PostedOn</th> <th>EditedOn</th></tr>\r\n        </thead>\r\n        <tbody>\r\n            <p>");
#nullable restore
#line 18 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
          Write(Model.category.CategoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 19 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
          Write(Model.category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
             foreach (HW_03.Models.Post post in Model.posts)
            {
              

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p> does this</p>\r\n");
#nullable restore
#line 24 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
                foreach (HW_03.Models.PostCategory postcategory in post.PostCategories)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p>does this the sequel</p>\r\n                    <p>");
#nullable restore
#line 27 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
                  Write(postcategory.CategoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"

                    if (postcategory.CategoryId == Model.category.CategoryId)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n\r\n                            <td> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43575d3df22992ac9567ff705200e08dc51b33c10391", async() => {
#nullable restore
#line 33 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
                                                                           Write(post.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
                                      WriteLiteral(post.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
                           Write(post.PostedOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
                           Write(post.EditedOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Hector\source\repos\hw-06-categories-with-razor-pages-maksad_justin_hector\hw-05-cleanup-emmanuel_hector-master\HW-03\Views\Blog\PostCategory.cshtml"
                    }
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43575d3df22992ac9567ff705200e08dc51b33c14146", async() => {
                    WriteLiteral("NewPost");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostCatRel> Html { get; private set; }
    }
}
#pragma warning restore 1591
