#pragma checksum "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2863e2cdca033539dc66372b588ebb1c73193a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Slider), @"mvc.1.0.view", @"/Views/Shared/_Slider.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Slider.cshtml", typeof(AspNetCore.Views_Shared__Slider))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2863e2cdca033539dc66372b588ebb1c73193a82", @"/Views/Shared/_Slider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279118bbf1cb58458d4c4850052f99821d6b7abf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Slider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 124, true);
            WriteLiteral("\r\n<div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <ol class=\"carousel-indicators\">\r\n\r\n");
            EndContext();
#line 6 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
         for (int i = 0; i < Model.Count(); i++)
        {
            if (i == 0)
            {

#line default
#line hidden
            BeginContext(251, 76, true);
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(328, 1, false);
#line 10 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(329, 24, true);
            WriteLiteral("\" class=\"active\"></li>\r\n");
            EndContext();
#line 11 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(401, 76, true);
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(478, 1, false);
#line 14 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(479, 9, true);
            WriteLiteral("\"></li>\r\n");
            EndContext();
#line 15 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(514, 49, true);
            WriteLiteral("\r\n    </ol>\r\n    <div class=\"carousel-inner\">\r\n\r\n");
            EndContext();
#line 21 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
           var index = 0;

#line default
#line hidden
            BeginContext(591, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
         foreach (var item in Model)
        {
            if (index == 0)
            {

#line default
#line hidden
            BeginContext(686, 72, true);
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    ");
            EndContext();
            BeginContext(758, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2863e2cdca033539dc66372b588ebb1c73193a826396", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 768, "~/img/", 768, 6, true);
#line 28 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 774, item.Image, 774, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 814, item.Title, 814, 11, false);

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
            BeginContext(827, 100, true);
            WriteLiteral("\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h5>");
            EndContext();
            BeginContext(928, 10, false);
#line 30 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(938, 34, true);
            WriteLiteral("</h5>\r\n                        <p>");
            EndContext();
            BeginContext(973, 16, false);
#line 31 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(989, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 34 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                index++;
            }
            else
            {

#line default
#line hidden
            BeginContext(1121, 66, true);
            WriteLiteral("                <div class=\"carousel-item \">\r\n                    ");
            EndContext();
            BeginContext(1187, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2863e2cdca033539dc66372b588ebb1c73193a829810", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1197, "~/img/", 1197, 6, true);
#line 39 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 1203, item.Image, 1203, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 1243, item.Title, 1243, 11, false);

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
            BeginContext(1256, 100, true);
            WriteLiteral("\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h5>");
            EndContext();
            BeginContext(1357, 10, false);
#line 41 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 34, true);
            WriteLiteral("</h5>\r\n                        <p>");
            EndContext();
            BeginContext(1402, 16, false);
#line 42 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1418, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 45 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(1504, 496, true);
            WriteLiteral(@"
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>

</div>");
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