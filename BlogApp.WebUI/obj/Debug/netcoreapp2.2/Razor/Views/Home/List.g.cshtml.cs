#pragma checksum "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e291d29c36f39da35a774f50bbcd0c4c1d40f128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
#line 2 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
#line 3 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e291d29c36f39da35a774f50bbcd0c4c1d40f128", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279118bbf1cb58458d4c4850052f99821d6b7abf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(68, 789, true);
            WriteLiteral(@"
<div class=""container"">

    <div class=""row mt-3"">

        <div class=""col-md-3"">
            <div class=""list-group"">
                <a href=""#"" class=""list-group-item list-group-item-action active"">
                    Cras justo odio
                </a>
                <a href=""#"" class=""list-group-item list-group-item-action"">Dapibus ac facilisis in</a>
                <a href=""#"" class=""list-group-item list-group-item-action"">Morbi leo risus</a>
                <a href=""#"" class=""list-group-item list-group-item-action"">Porta ac consectetur ac</a>
                <a href=""#"" class=""list-group-item list-group-item-action disabled"" tabindex=""-1"" aria-disabled=""true"">Vestibulum at eros</a>
            </div>
        </div>

        <div class=""col-md-9"">
");
            EndContext();
#line 24 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
            BeginContext(916, 112, true);
            WriteLiteral("                <div class=\"card mb-2\">\r\n                    <div class=\"card-header\">\r\n                        ");
            EndContext();
            BeginContext(1029, 10, false);
#line 29 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 50, true);
            WriteLiteral("\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(1089, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e291d29c36f39da35a774f50bbcd0c4c1d40f1286950", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1099, "~/img/", 1099, 6, true);
#line 31 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml"
AddHtmlAttributeValue("", 1105, item.Image, 1105, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1149, 96, true);
            WriteLiteral("\r\n\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1246, 10, false);
#line 34 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml"
                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1256, 52, true);
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1309, 16, false);
#line 35 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml"
                                        Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 31, true);
            WriteLiteral(" </p>\r\n                        ");
            EndContext();
            BeginContext(1356, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e291d29c36f39da35a774f50bbcd0c4c1d40f1289645", async() => {
                BeginContext(1538, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml"
                             WriteLiteral(item.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1549, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 42 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\List.cshtml"
            }

#line default
#line hidden
            BeginContext(1618, 46, true);
            WriteLiteral("        </div>\r\n\r\n\r\n        </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
