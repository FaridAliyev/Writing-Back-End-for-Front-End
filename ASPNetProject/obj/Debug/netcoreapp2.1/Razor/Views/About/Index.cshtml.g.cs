#pragma checksum "E:\Projects\ASPNetProject\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8a1d0f9c12737bcec60f3b546fc2f979741ea8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
#line 1 "E:\Projects\ASPNetProject\Views\_ViewImports.cshtml"
using ASPNetProject.Models;

#line default
#line hidden
#line 2 "E:\Projects\ASPNetProject\Views\_ViewImports.cshtml"
using ASPNetProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8a1d0f9c12737bcec60f3b546fc2f979741ea8e", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75ad261125fd47f9d3a83db31753885bdcad958", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(57, 105, true);
            WriteLiteral("\r\n<!-- Banner Area Start -->\r\n<div class=\"banner-area-wrapper\">\r\n    <div class=\"banner-area text-center\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 162, "\"", 257, 4);
            WriteAttributeValue("", 170, "background-image:", 170, 17, true);
            WriteAttributeValue(" ", 187, "url(\'", 188, 6, true);
#line 8 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
WriteAttributeValue("", 193, Url.Content("~/img/banner/"+Model.Background.Image), 193, 52, false);

#line default
#line hidden
            WriteAttributeValue("", 245, "\')!important", 245, 12, true);
            EndWriteAttribute();
            BeginContext(258, 682, true);
            WriteLiteral(@">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>about us</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- About Start -->
<div class=""about-area pt-145 pb-155"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-content"">
                    <h2>WELCOME TO <span>");
            EndContext();
            BeginContext(941, 16, false);
#line 29 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                                    Write(Model.About.Name);

#line default
#line hidden
            EndContext();
            BeginContext(957, 37, true);
            WriteLiteral("</span></h2>\r\n                    <p>");
            EndContext();
            BeginContext(995, 23, false);
#line 30 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                  Write(Model.About.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 47, true);
            WriteLiteral("</p>\r\n                    <p class=\"hidden-sm\">");
            EndContext();
            BeginContext(1066, 23, false);
#line 31 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                                    Write(Model.About.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(1115, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8fc02fb9e744142aef8ebcc1a6b087b", async() => {
                BeginContext(1181, 12, true);
                WriteLiteral("view courses");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1197, 156, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1353, "\"", 1387, 2);
            WriteAttributeValue("", 1359, "img/about/", 1359, 10, true);
#line 37 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
WriteAttributeValue("", 1369, Model.About.Image, 1369, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1388, 537, true);
            WriteLiteral(@" alt=""about"">
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Teacher Start -->
<div class=""teacher-area pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    <img src=""img/icon/section.png"" alt=""title"">
                    <h2>meet our teachers</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            ");
            EndContext();
            BeginContext(1926, 42, false);
#line 56 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
       Write(await  Component.InvokeAsync("Teachers",4));

#line default
#line hidden
            EndContext();
            BeginContext(1968, 273, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Teacher End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
");
            EndContext();
#line 66 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                 foreach (Testimonial item in Model.Testimonials)
                {

#line default
#line hidden
            BeginContext(2327, 291, true);
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2618, "\"", 2651, 2);
            WriteAttributeValue("", 2624, "img/testimonial/", 2624, 16, true);
#line 72 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
WriteAttributeValue("", 2640, item.Image, 2640, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2652, 167, true);
            WriteLiteral(" alt=\"testimonial\">\r\n                                </div>\r\n                                <div class=\"testimonial-content\">\r\n                                    <p>");
            EndContext();
            BeginContext(2820, 11, false);
#line 75 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                                  Write(item.Review);

#line default
#line hidden
            EndContext();
            BeginContext(2831, 46, true);
            WriteLiteral("</p>\r\n                                    <h4>");
            EndContext();
            BeginContext(2878, 13, false);
#line 76 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                                   Write(item.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(2891, 47, true);
            WriteLiteral("</h4>\r\n                                    <h5>");
            EndContext();
            BeginContext(2939, 9, false);
#line 77 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                                   Write(item.Duty);

#line default
#line hidden
            EndContext();
            BeginContext(2948, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2951, 18, false);
#line 77 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                                               Write(item.Qualification);

#line default
#line hidden
            EndContext();
            BeginContext(2969, 143, true);
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 82 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3131, 427, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3558, "\"", 3649, 4);
            WriteAttributeValue("", 3566, "background-image:", 3566, 17, true);
            WriteAttributeValue(" ", 3583, "url(\'", 3584, 6, true);
#line 95 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3589, Url.Content("~/img/notice/"+Model.Video.Source), 3589, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 3637, "\')!important", 3637, 12, true);
            EndWriteAttribute();
            BeginContext(3650, 567, true);
            WriteLiteral(@">
                        <div class=""video-icon video-hover"">
                            <a class=""video-popup"" href=""https://www.youtube.com/watch?v=to6Ghf8UL7o"">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
");
            EndContext();
#line 108 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                         foreach (NoticeBoard item in Model.NoticeBoards)
                        {

#line default
#line hidden
            BeginContext(4319, 110, true);
            WriteLiteral("                            <div class=\"single-notice-left mb-23 pb-20\">\r\n                                <h4>");
            EndContext();
            BeginContext(4430, 9, false);
#line 111 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4439, 42, true);
            WriteLiteral("</h4>\r\n                                <p>");
            EndContext();
            BeginContext(4482, 16, false);
#line 112 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4498, 42, true);
            WriteLiteral("</p>\r\n                            </div>\r\n");
            EndContext();
#line 114 "E:\Projects\ASPNetProject\Views\About\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4567, 133, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Notice End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
