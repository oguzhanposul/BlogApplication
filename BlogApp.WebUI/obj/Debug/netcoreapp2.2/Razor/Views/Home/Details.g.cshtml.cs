#pragma checksum "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a16a63c1a1f7bd6b40866c3fe439a6d04b2e8eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a16a63c1a1f7bd6b40866c3fe439a6d04b2e8eb", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279118bbf1cb58458d4c4850052f99821d6b7abf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(58, 952, true);
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
                <div class=""card"">
                    <div class=""card-header"">
                        ");
            EndContext();
            BeginContext(1011, 11, false);
#line 26 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 50, true);
            WriteLiteral("\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(1072, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a16a63c1a1f7bd6b40866c3fe439a6d04b2e8eb5627", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1082, "~/img/", 1082, 6, true);
#line 28 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 1088, Model.Image, 1088, 12, false);

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
            BeginContext(1133, 96, true);
            WriteLiteral("\r\n\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1230, 11, false);
#line 31 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\Details.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1241, 52, true);
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1294, 17, false);
#line 32 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Home\Details.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 186, true);
            WriteLiteral("</p>\r\n                        <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591