#pragma checksum "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2af75a9c3eaf69c934652e46c01b02b53bbc874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Event_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Event/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Event/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Event_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2af75a9c3eaf69c934652e46c01b02b53bbc874", @"/Areas/Admin/Views/Event/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe69668118451dfbd039da4227812d30ccafe4e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Event_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:770px;height:358px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("speaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
  
    ViewData["Title"] = "Event Details";

#line default
#line hidden
            BeginContext(65, 303, true);
            WriteLiteral(@"
    <div class=""event-details-area blog-area pt-150 pb-140"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""event-details"">
                        <div class=""event-details-img"">
                            ");
            EndContext();
            BeginContext(368, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5caa803e05db47a6a9e0bff6059ca67d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 378, "~/img/event/", 378, 12, true);
#line 12 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
AddHtmlAttributeValue("", 390, Model.Event.Image, 390, 18, false);

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
            BeginContext(463, 56, true);
            WriteLiteral("\r\n                            <div class=\"event-date\">\r\n");
            EndContext();
#line 14 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                  string[] words = Model.Event.Date.Split(' ');

#line default
#line hidden
            BeginContext(601, 36, true);
            WriteLiteral("                                <h3>");
            EndContext();
            BeginContext(638, 8, false);
#line 15 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                               Write(words[0]);

#line default
#line hidden
            EndContext();
            BeginContext(646, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(648, 24, false);
#line 15 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                         Write(words[1].Substring(0, 3));

#line default
#line hidden
            EndContext();
            BeginContext(672, 168, true);
            WriteLiteral("</h3>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"event-details-content\">\r\n                            <h2>");
            EndContext();
            BeginContext(841, 16, false);
#line 19 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                           Write(Model.Event.Name);

#line default
#line hidden
            EndContext();
            BeginContext(857, 97, true);
            WriteLiteral("</h2>\r\n                            <ul>\r\n                                <li><span>time : </span>");
            EndContext();
            BeginContext(955, 16, false);
#line 21 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                                   Write(Model.Event.Time);

#line default
#line hidden
            EndContext();
            BeginContext(971, 64, true);
            WriteLiteral("</li>\r\n                                <li><span>venue : </span>");
            EndContext();
            BeginContext(1036, 17, false);
#line 22 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                                    Write(Model.Event.Venue);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 73, true);
            WriteLiteral("</li>\r\n                            </ul>\r\n                            <p>");
            EndContext();
            BeginContext(1127, 33, false);
#line 24 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                          Write(Html.Raw(Model.Event.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 121, true);
            WriteLiteral("</p>\r\n                            <h4>speakers</h4>\r\n                            <div class=\"speakers-area fix d-flex\">\r\n");
            EndContext();
#line 27 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                 foreach (EventSpeaker item in Model.EventSpeakers)
                                {
                                    if (item.EventId == Model.Event.Id)
                                    {

#line default
#line hidden
            BeginContext(1513, 225, true);
            WriteLiteral("                                        <div class=\"single-speaker\" style=\"margin-right:30px!important\">\r\n                                            <div class=\"speaker-img\">\r\n                                                ");
            EndContext();
            BeginContext(1738, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42667dbb562946f99631107744ef6c59", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1748, "~/img/event/", 1748, 12, true);
#line 33 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
AddHtmlAttributeValue("", 1760, item.Speaker.Image, 1760, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1795, 178, true);
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"speaker-name\">\r\n                                                <h5>");
            EndContext();
            BeginContext(1974, 21, false);
#line 36 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                               Write(item.Speaker.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1995, 58, true);
            WriteLiteral("</h5>\r\n                                                <p>");
            EndContext();
            BeginContext(2054, 17, false);
#line 37 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                              Write(item.Speaker.Duty);

#line default
#line hidden
            EndContext();
            BeginContext(2071, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2074, 20, false);
#line 37 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                                                  Write(item.Speaker.Company);

#line default
#line hidden
            EndContext();
            BeginContext(2094, 107, true);
            WriteLiteral(" </p>\r\n                                            </div>\r\n                                        </div>\r\n");
            EndContext();
#line 40 "E:\Projects\ASPNetProject\Areas\Admin\Views\Event\Details.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(2275, 136, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(2411, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d948cfd6d2b04ae486aaae8c769ed286", async() => {
                BeginContext(2468, 127, true);
                WriteLiteral("\r\n                    Go Back\r\n                    <i class=\"mdi mdi-keyboard-backspace btn-icon-append\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2599, 48, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
