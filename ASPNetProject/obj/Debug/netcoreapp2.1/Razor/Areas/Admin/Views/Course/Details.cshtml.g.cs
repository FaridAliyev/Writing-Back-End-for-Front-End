#pragma checksum "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c0c60feb973cf23edd9dbfedf2fec1afd576bcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Course_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Course/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Course/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Course_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0c60feb973cf23edd9dbfedf2fec1afd576bcc", @"/Areas/Admin/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe69668118451dfbd039da4227812d30ccafe4e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoursesVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("courses-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:770px;height:411px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
  
    ViewData["Title"] = "Course Details";

#line default
#line hidden
            BeginContext(68, 309, true);
            WriteLiteral(@"
    <div class=""courses-details-area blog-area pt-150 pb-140"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""courses-details"">
                        <div class=""courses-details-img"">
                            ");
            EndContext();
            BeginContext(377, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "443a30401ad949329c0b062b04d2888a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 387, "~/img/course/", 387, 13, true);
#line 12 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
AddHtmlAttributeValue("", 400, Model.Course.Image, 400, 19, false);

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
            BeginContext(476, 128, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"course-details-content\">\r\n                            <h2>");
            EndContext();
            BeginContext(605, 17, false);
#line 15 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                           Write(Model.Course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(622, 38, true);
            WriteLiteral("</h2>\r\n                            <p>");
            EndContext();
            BeginContext(661, 34, false);
#line 16 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                          Write(Html.Raw(Model.Course.Description));

#line default
#line hidden
            EndContext();
            BeginContext(695, 233, true);
            WriteLiteral("</p>\r\n                            <div class=\"course-details-left\">\r\n                                <div class=\"single-course-left\">\r\n                                    <h3>about course</h3>\r\n                                    <p>");
            EndContext();
            BeginContext(929, 41, false);
#line 20 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                  Write(Html.Raw(Model.Course.CourseDetail.About));

#line default
#line hidden
            EndContext();
            BeginContext(970, 210, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"single-course-left\">\r\n                                    <h3>how to apply</h3>\r\n                                    <p>");
            EndContext();
            BeginContext(1181, 46, false);
#line 24 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                  Write(Html.Raw(Model.Course.CourseDetail.HowToApply));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 226, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"single-course-left\">\r\n                                    <h3>certification</h3>\r\n                                    <p class=\"margin\">");
            EndContext();
            BeginContext(1454, 49, false);
#line 28 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                 Write(Html.Raw(Model.Course.CourseDetail.Certification));

#line default
#line hidden
            EndContext();
            BeginContext(1503, 295, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""course-details-right"">
                                <h3>COURSE FEATURES</h3>
                                <ul>
                                    <li>starts <span>");
            EndContext();
            BeginContext(1799, 62, false);
#line 34 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                Write(Model.Course.CourseFeature.StartDate.ToString("dd MMMM, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 69, true);
            WriteLiteral("</span></li>\r\n                                    <li>duration <span>");
            EndContext();
            BeginContext(1931, 35, false);
#line 35 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                  Write(Model.Course.CourseFeature.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 75, true);
            WriteLiteral("</span></li>\r\n                                    <li>class duration <span>");
            EndContext();
            BeginContext(2042, 40, false);
#line 36 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                        Write(Model.Course.CourseFeature.ClassDuration);

#line default
#line hidden
            EndContext();
            BeginContext(2082, 78, true);
            WriteLiteral(" hours</span></li>\r\n                                    <li>skill level <span>");
            EndContext();
            BeginContext(2161, 37, false);
#line 37 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                     Write(Model.Course.CourseFeature.SkillLevel);

#line default
#line hidden
            EndContext();
            BeginContext(2198, 69, true);
            WriteLiteral("</span></li>\r\n                                    <li>language <span>");
            EndContext();
            BeginContext(2268, 35, false);
#line 38 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                  Write(Model.Course.CourseFeature.Language);

#line default
#line hidden
            EndContext();
            BeginContext(2303, 69, true);
            WriteLiteral("</span></li>\r\n                                    <li>students <span>");
            EndContext();
            BeginContext(2373, 39, false);
#line 39 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                  Write(Model.Course.CourseFeature.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(2412, 71, true);
            WriteLiteral("</span></li>\r\n                                    <li>assesments <span>");
            EndContext();
            BeginContext(2484, 37, false);
#line 40 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                    Write(Model.Course.CourseFeature.Assesments);

#line default
#line hidden
            EndContext();
            BeginContext(2521, 113, true);
            WriteLiteral("</span></li>\r\n                                </ul>\r\n                                <h3 class=\"red\">course fee $");
            EndContext();
            BeginContext(2635, 30, false);
#line 42 "E:\Projects\ASPNetProject\Areas\Admin\Views\Course\Details.cshtml"
                                                       Write(Model.Course.CourseFeature.Fee);

#line default
#line hidden
            EndContext();
            BeginContext(2665, 143, true);
            WriteLiteral("</h3>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(2808, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35a7d3769a024be5b324df219af3312c", async() => {
                BeginContext(2865, 127, true);
                WriteLiteral("\r\n                    Go Back\r\n                    <i class=\"mdi mdi-keyboard-backspace btn-icon-append\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2996, 48, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoursesVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
