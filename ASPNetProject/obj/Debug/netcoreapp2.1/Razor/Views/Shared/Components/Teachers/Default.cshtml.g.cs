#pragma checksum "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79e4ec7b778e9f17414c3c59cb159ba2330d1f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Teachers_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Teachers/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Teachers/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Teachers_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e4ec7b778e9f17414c3c59cb159ba2330d1f0a", @"/Views/Shared/Components/Teachers/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75ad261125fd47f9d3a83db31753885bdcad958", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Teachers_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TeacherVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
 foreach (TeacherVM item in Model)
{

#line default
#line hidden
            BeginContext(72, 153, true);
            WriteLiteral("    <div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n        <div class=\"single-teacher mb-45\">\r\n            <div class=\"single-teacher-img\">\r\n                ");
            EndContext();
            BeginContext(225, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5ca79b7e16d45d784db7b70fe872431", async() => {
                BeginContext(298, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 302, "\"", 331, 2);
                WriteAttributeValue("", 308, "img/teacher/", 308, 12, true);
#line 8 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
WriteAttributeValue("", 320, item.Image, 320, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(332, 15, true);
                WriteLiteral(" alt=\"teacher\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
                                                                   WriteLiteral(item.Id);

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
            BeginContext(351, 104, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"single-teacher-content text-center\">\r\n                <h2>");
            EndContext();
            BeginContext(455, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c98efaa1aa045f3a62d7bf57800b0ed", async() => {
                BeginContext(529, 13, false);
#line 11 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
                                                                                        Write(item.Fullname);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
                                                                       WriteLiteral(item.Id);

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
            BeginContext(546, 27, true);
            WriteLiteral("</h2>\r\n                <h4>");
            EndContext();
            BeginContext(574, 30, false);
#line 12 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
               Write(item.TeacherInfo.Qualification);

#line default
#line hidden
            EndContext();
            BeginContext(604, 55, true);
            WriteLiteral("</h4>\r\n                <ul>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 659, "\"", 692, 1);
#line 14 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
WriteAttributeValue("", 666, item.TeacherInfo.Facebook, 666, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(693, 72, true);
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 765, "\"", 799, 1);
#line 15 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
WriteAttributeValue("", 772, item.TeacherInfo.Pinterest, 772, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(800, 73, true);
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 873, "\"", 903, 1);
#line 16 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
WriteAttributeValue("", 880, item.TeacherInfo.Vimeo, 880, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(904, 69, true);
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 973, "\"", 1005, 1);
#line 17 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
WriteAttributeValue("", 980, item.TeacherInfo.Twitter, 980, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1006, 116, true);
            WriteLiteral("><i class=\"zmdi zmdi-twitter\"></i></a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 22 "E:\Projects\ASPNetProject\Views\Shared\Components\Teachers\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TeacherVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
