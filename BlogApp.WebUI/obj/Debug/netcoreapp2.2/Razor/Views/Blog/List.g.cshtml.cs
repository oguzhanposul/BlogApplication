#pragma checksum "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "957fe51bd6f0f8aba19c57279b409bbb3e61a4ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_List), @"mvc.1.0.view", @"/Views/Blog/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/List.cshtml", typeof(AspNetCore.Views_Blog_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957fe51bd6f0f8aba19c57279b409bbb3e61a4ab", @"/Views/Blog/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279118bbf1cb58458d4c4850052f99821d6b7abf", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(120, 106, true);
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n    <h2>Blog List</h2>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n");
            EndContext();
#line 12 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
             if (Model.Count() > 0 )
            {

#line default
#line hidden
            BeginContext(279, 524, true);
            WriteLiteral(@"                <table class=""table table-bordered table-striped "" >
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Image</th>
                            <th>Title</th>
                            <th>Date</th>
                            <th>isApproved</th>
                            <th>isHome</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 27 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                        foreach (var item in Model)
                       {

#line default
#line hidden
            BeginContext(882, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(945, 11, false);
#line 30 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.BlogId);

#line default
#line hidden
            EndContext();
            BeginContext(956, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1029, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "957fe51bd6f0f8aba19c57279b409bbb3e61a4ab7427", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1039, "~/img/", 1039, 6, true);
#line 32 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
AddHtmlAttributeValue("", 1045, item.Image, 1045, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1072, 69, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(1142, 10, false);
#line 34 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1192, 9, false);
#line 35 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 37 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (item.isApproved)
                                {

#line default
#line hidden
            BeginContext(1332, 259, true);
            WriteLiteral(@"                                    <p>
                                        <span class=""badge badge-info"">
                                            Approved
                                        </span>
                                    </p>
");
            EndContext();
#line 44 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1699, 265, true);
            WriteLiteral(@"                                    <p>
                                        <span class=""badge badge-danger"">
                                            Not Approved
                                        </span>
                                    </p>
");
            EndContext();
#line 52 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(1999, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 55 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (item.isHome)
                                {

#line default
#line hidden
            BeginContext(2154, 260, true);
            WriteLiteral(@"                                    <p>
                                        <span class=""badge badge-info"">
                                            Home Blog
                                        </span>
                                    </p>
");
            EndContext();
#line 62 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2522, 266, true);
            WriteLiteral(@"                                    <p>
                                        <span class=""badge badge-danger"">
                                            Not Home Blog
                                        </span>
                                    </p>
");
            EndContext();
#line 70 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2823, 101, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2924, 292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "957fe51bd6f0f8aba19c57279b409bbb3e61a4ab13095", async() => {
                BeginContext(3134, 78, true);
                WriteLiteral("\r\n                                    Update\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                     WriteLiteral(item.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3216, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3250, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "957fe51bd6f0f8aba19c57279b409bbb3e61a4ab15839", async() => {
                BeginContext(3461, 78, true);
                WriteLiteral("\r\n                                    Delete\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                     WriteLiteral(item.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3543, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 87 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                       }

#line default
#line hidden
            BeginContext(3637, 56, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
            EndContext();
#line 90 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3741, 126, true);
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    There are no blog on database.\r\n                </div>\r\n");
            EndContext();
#line 96 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
            }

#line default
#line hidden
            BeginContext(3882, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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