#pragma checksum "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe8757aee7fc580b4d36efc6fd1eab4051528ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Acc_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Acc/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Acc/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Acc_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe8757aee7fc580b4d36efc6fd1eab4051528ec", @"/Areas/Admin/Views/Acc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe69668118451dfbd039da4227812d30ccafe4e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Acc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
  
    ViewData["Title"] = "Active Users";

#line default
#line hidden
            BeginContext(76, 334, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">User List</h4>
                <p class=""card-description"">
                    Here you can see all active users
                </p>
                ");
            EndContext();
            BeginContext(410, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db3dfe426575488bb85f4a09ef69ca29", async() => {
                BeginContext(471, 112, true);
                WriteLiteral("\r\n                    Create\r\n                    <i class=\"mdi mdi-apps btn-icon-append\"></i>\r\n                ");
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
            BeginContext(587, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
            BeginContext(649, 974, true);
            WriteLiteral(@"                    <div class=""table-responsive pt-3"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>
                                        Fullname
                                    </th>
                                    <th>
                                        Username
                                    </th>
                                    <th>
                                        Email
                                    </th>
                                    <th>
                                        Role
                                    </th>
                                    <th>
                                        Action
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 42 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                 foreach (UserVM item in Model)
                                {

#line default
#line hidden
            BeginContext(1723, 88, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n");
            EndContext();
#line 46 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                             if (item.Username == User.Identity.Name)
                                            {
                                                

#line default
#line hidden
            BeginContext(1994, 23, false);
#line 48 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                           Write(item.Fullname.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(2017, 51, true);
            WriteLiteral(" <span style=\"font-size:20px\"><b>(You)</b></span>\r\n");
            EndContext();
#line 49 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
            BeginContext(2261, 23, false);
#line 52 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                           Write(item.Fullname.ToUpper());

#line default
#line hidden
            EndContext();
#line 52 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                                                        
                                            }

#line default
#line hidden
            BeginContext(2333, 138, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                             ");
            EndContext();
            BeginContext(2472, 13, false);
#line 56 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                        Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(2485, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2625, 10, false);
#line 59 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2635, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2775, 9, false);
#line 62 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                       Write(item.Role);

#line default
#line hidden
            EndContext();
            BeginContext(2784, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2923, 283, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8ef62c5e0b4c7f99bd883867562858", async() => {
                BeginContext(3006, 196, true);
                WriteLiteral("\r\n                                                Edit\r\n                                                <i class=\"mdi mdi-pencil btn-icon-append\"></i>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3206, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 69 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                             if (item.Username != User.Identity.Name)
                                            {

#line default
#line hidden
            BeginContext(3342, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(3390, 298, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b4d6f9cecd40ef8bc63e718d025f41", async() => {
                BeginContext(3474, 210, true);
                WriteLiteral("\r\n                                                    Delete\r\n                                                    <i class=\"mdi mdi-delete btn-icon-append\"></i>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3688, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 75 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3737, 90, true);
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 78 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3862, 100, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
            EndContext();
#line 82 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4022, 51, true);
            WriteLiteral("                    <h1>OOPS... Nothing here</h1>\r\n");
            EndContext();
#line 86 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4092, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
