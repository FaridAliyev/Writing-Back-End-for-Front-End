#pragma checksum "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d622cfab57fda0d7ee70d704a9de2ed97460c58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Subscriber_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Subscriber/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Subscriber/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Subscriber_Index))]
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
#line 1 "E:\Projects\ASPNetProject\Areas\Admin\Views\_ViewImports.cshtml"
using ASPNetProject.Models;

#line default
#line hidden
#line 2 "E:\Projects\ASPNetProject\Areas\Admin\Views\_ViewImports.cshtml"
using ASPNetProject.ViewModels;

#line default
#line hidden
#line 3 "E:\Projects\ASPNetProject\Areas\Admin\Views\_ViewImports.cshtml"
using ASPNetProject.Areas.Admin.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d622cfab57fda0d7ee70d704a9de2ed97460c58", @"/Areas/Admin/Views/Subscriber/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe69668118451dfbd039da4227812d30ccafe4e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Subscriber_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Subscriber>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NotSeen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkAllAsSeen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkAsSeen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
  
    ViewData["Title"] = "Subscribers";

#line default
#line hidden
            BeginContext(79, 213, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Subscribers</h4>\r\n                ");
            EndContext();
            BeginContext(292, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "535828b8b2ad46e9aaec1b549bb33959", async() => {
                BeginContext(354, 127, true);
                WriteLiteral("\r\n                    Show only not seen\r\n                    <i class=\"mdi mdi-new-box btn-icon-append\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(485, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                 foreach (Subscriber item in Model)
                {
                    if (!item.Checked)
                    {

#line default
#line hidden
            BeginContext(622, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(646, 340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "161e39d1449641e881d4ee6416d62d81", async() => {
                BeginContext(831, 151, true);
                WriteLiteral("\r\n                            Mark all as seen\r\n                            <i class=\"mdi mdi-check-all btn-icon-append\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                    WriteLiteral(string.Format("{0}{1}",Context.Request.Path, Context.Request.QueryString));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(986, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                        break;
                    }
                }

#line default
#line hidden
            BeginContext(1062, 129, true);
            WriteLiteral("                <div class=\"table-responsive pt-3\">\r\n                    <table class=\"table\">\r\n                        <tbody>\r\n");
            EndContext();
#line 29 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                             if (Model.Count() > 0)
                            {
                                

#line default
#line hidden
#line 31 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                 foreach (Subscriber item in Model)
                                {

#line default
#line hidden
            BeginContext(1379, 42, true);
            WriteLiteral("                                    <tr>\r\n");
            EndContext();
#line 34 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                         if (item.Checked)
                                        {

#line default
#line hidden
            BeginContext(1524, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(1573, 10, false);
#line 36 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1583, 62, true);
            WriteLiteral("</td>\r\n                                            <td></td>\r\n");
            EndContext();
#line 38 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(1777, 51, true);
            WriteLiteral("                                            <td><b>");
            EndContext();
            BeginContext(1829, 10, false);
#line 41 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                              Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1839, 59, true);
            WriteLiteral("</b></td>\r\n                                            <td>");
            EndContext();
            BeginContext(1898, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916e3306ec864c13bcac26b428dfd799", async() => {
                BeginContext(2084, 49, true);
                WriteLiteral("<i class=\"mdi mdi-check-all btn-icon-append\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                                            WriteLiteral(string.Format("{0}{1}",Context.Request.Path, Context.Request.QueryString));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#line 42 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                                                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2137, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 43 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2187, 43, true);
            WriteLiteral("                                    </tr>\r\n");
            EndContext();
#line 45 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                }

#line default
#line hidden
#line 45 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2361, 147, true);
            WriteLiteral("                                <tr>\r\n                                    <td><h1>No subscribers</h1></td>\r\n                                </tr>\r\n");
            EndContext();
#line 52 "E:\Projects\ASPNetProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2539, 146, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Subscriber>> Html { get; private set; }
    }
}
#pragma warning restore 1591
