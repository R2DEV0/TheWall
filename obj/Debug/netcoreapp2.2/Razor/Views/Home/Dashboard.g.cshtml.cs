#pragma checksum "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc0578351bf0b33d5a5136127f393c0f9342fcef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\_ViewImports.cshtml"
using TheWall;

#line default
#line hidden
#line 2 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\_ViewImports.cshtml"
using TheWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc0578351bf0b33d5a5136127f393c0f9342fcef", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d202197c3bfd1895a7b2b59f7940dc9c3d32218c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostCom>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(53, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc0578351bf0b33d5a5136127f393c0f9342fcef5707", async() => {
                BeginContext(59, 110, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                EndContext();
                BeginContext(169, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc0578351bf0b33d5a5136127f393c0f9342fcef6207", async() => {
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
                EndContext();
                BeginContext(216, 41, true);
                WriteLiteral("\r\n    <title>The Wall Dashboard</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(264, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(266, 2423, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc0578351bf0b33d5a5136127f393c0f9342fcef8378", async() => {
                BeginContext(272, 274, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-6 mt-2"">
                <h2 style=""font-style: italic;"" class=""wall"">The Wall</h2>
            </div>
            <div class=""col-sm-5 mt-2 text-right"">
                <p>Welcome ");
                EndContext();
                BeginContext(547, 22, false);
#line 18 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                      Write(ViewBag.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(569, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(571, 21, false);
#line 18 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                                              Write(ViewBag.User.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(592, 333, true);
                WriteLiteral(@"</p>
            </div>
            <div class=""col-sm-1 mt-2"">
                <a href=""/logout"">Logout</a>
            </div>
        </div>
        <hr/>
        <div class=""col-sm-10 offset-1"">
            <div class=""col-sm-4"">
                <h4 class=""message""> Post a Message </h4>
            </div>
            ");
                EndContext();
                BeginContext(925, 387, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc0578351bf0b33d5a5136127f393c0f9342fcef10135", async() => {
                    BeginContext(992, 313, true);
                    WriteLiteral(@"
                <div class=""form-group"">
                    <textarea name=""Post"" class=""form-control"" cols=""80"" rows=""6""></textarea>
                </div>
                <div>
                    <button class=""btn btn-success col-6 offset-6 post"">Post It!</button>
                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1312, 73, true);
                WriteLiteral("\r\n        </div>\r\n        <br/>\r\n        <div class=\"col-11 row board\">\r\n");
                EndContext();
#line 40 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
             foreach(Message post in Model.AllMessages)
            {

#line default
#line hidden
                BeginContext(1457, 115, true);
                WriteLiteral("                <div class=\"col-11 offset-1\">\r\n                    <p style=\"font-style: italic; font-size: 12px\"> ");
                EndContext();
                BeginContext(1573, 21, false);
#line 43 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                                                               Write(post.Poster.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1594, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1596, 20, false);
#line 43 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                                                                                      Write(post.Poster.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1616, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(1620, 14, false);
#line 43 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                                                                                                              Write(post.UpdatedAt);

#line default
#line hidden
                EndContext();
                BeginContext(1634, 30, true);
                WriteLiteral("</p>\r\n                    <p> ");
                EndContext();
                BeginContext(1665, 9, false);
#line 44 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                   Write(post.Post);

#line default
#line hidden
                EndContext();
                BeginContext(1674, 7, true);
                WriteLiteral(" </p>\r\n");
                EndContext();
#line 45 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                 foreach(Comment reply in post.ConnectedComments)
                {

#line default
#line hidden
                BeginContext(1767, 68, true);
                WriteLiteral("                    <p style=\"font-style: italic; font-size: 12px\"> ");
                EndContext();
                BeginContext(1836, 22, false);
#line 47 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                                                               Write(reply.Poster.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1858, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1860, 21, false);
#line 47 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                                                                                       Write(reply.Poster.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1881, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(1885, 15, false);
#line 47 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                                                                                                                Write(reply.UpdatedAt);

#line default
#line hidden
                EndContext();
                BeginContext(1900, 31, true);
                WriteLiteral(" </p>\r\n                    <p> ");
                EndContext();
                BeginContext(1932, 14, false);
#line 48 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                   Write(reply.Response);

#line default
#line hidden
                EndContext();
                BeginContext(1946, 7, true);
                WriteLiteral(" </p>\r\n");
                EndContext();
#line 49 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                }

#line default
#line hidden
                BeginContext(1972, 113, true);
                WriteLiteral("                    <p class=\"comment mb-1\" style=\"font-weight: bold;\"> Post a Comment </p>\r\n                    ");
                EndContext();
                BeginContext(2085, 501, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc0578351bf0b33d5a5136127f393c0f9342fcef17214", async() => {
                    BeginContext(2190, 389, true);
                    WriteLiteral(@"
                        <div class=""form-group mb-1"">
                            <textarea name=""Response"" class=""form-control"" cols=""80"" rows=""2""></textarea>
                        </div>
                        <div>
                            <button class=""btn btn-primary btn-sm col-2 offset-10 post"">Comment It!</button>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MessageId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
                                                                                                WriteLiteral(post.MessageId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["MessageId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MessageId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["MessageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2586, 53, true);
                WriteLiteral("\r\n                    <hr/>\r\n                </div>\r\n");
                EndContext();
#line 61 "C:\Users\r2dev\Desktop\coding_dojo\C#\TheWall\Views\Home\Dashboard.cshtml"
            }

#line default
#line hidden
                BeginContext(2654, 28, true);
                WriteLiteral("        </div>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2689, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostCom> Html { get; private set; }
    }
}
#pragma warning restore 1591
