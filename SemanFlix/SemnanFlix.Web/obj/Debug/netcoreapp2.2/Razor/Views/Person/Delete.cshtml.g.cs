#pragma checksum "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93dc594dc4b5fc1a3e9936845bfc25ffcf326da7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Delete), @"mvc.1.0.view", @"/Views/Person/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Delete.cshtml", typeof(AspNetCore.Views_Person_Delete))]
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
#line 1 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix;

#line default
#line hidden
#line 2 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels;

#line default
#line hidden
#line 3 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels.Account;

#line default
#line hidden
#line 4 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels.Manage;

#line default
#line hidden
#line 5 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93dc594dc4b5fc1a3e9936845bfc25ffcf326da7", @"/Views/Person/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa6f439dba39d5d7130eb680c45ba14b0891373", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SemnanFlix.ViewModels.Person.PersonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Person", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
  
    ViewData["Title"] = "Delete " + Model.Name;

#line default
#line hidden
            BeginContext(111, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(118, 17, false);
#line 7 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(135, 55, true);
            WriteLiteral("</h1>\r\n<p class=\"lead\">Are you sure you want to delete ");
            EndContext();
            BeginContext(191, 10, false);
#line 8 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(201, 23, true);
            WriteLiteral("?</p>\r\n<br /><br />\r\n\r\n");
            EndContext();
            BeginContext(224, 607, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93dc594dc4b5fc1a3e9936845bfc25ffcf326da76982", async() => {
                BeginContext(324, 53, true);
                WriteLiteral("\r\n    <div class=\"container form-actions no-color\">\r\n");
                EndContext();
#line 13 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
         if (Model.Roles.Count > 0)
        {

#line default
#line hidden
                BeginContext(425, 36, true);
                WriteLiteral("            <h4 class=\"text-danger\">");
                EndContext();
                BeginContext(462, 10, false);
#line 15 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
                               Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(472, 59, true);
                WriteLiteral(" cannot be deleted because they\'re in the cast or crew for ");
                EndContext();
                BeginContext(532, 17, false);
#line 15 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
                                                                                                     Write(Model.Roles.Count);

#line default
#line hidden
                EndContext();
                BeginContext(549, 31, true);
                WriteLiteral(" movies: </h4>\r\n            <p>");
                EndContext();
                BeginContext(581, 33, false);
#line 16 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
          Write(Html.Raw(Model.RolesBulletedList));

#line default
#line hidden
                EndContext();
                BeginContext(614, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 17 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(656, 75, true);
                WriteLiteral("            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n");
                EndContext();
#line 21 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Person\Delete.cshtml"
        }

#line default
#line hidden
                BeginContext(742, 30, true);
                WriteLiteral("        <br /><br />\r\n        ");
                EndContext();
                BeginContext(772, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93dc594dc4b5fc1a3e9936845bfc25ffcf326da79679", async() => {
                    BeginContext(794, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(810, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SemnanFlix.ViewModels.Person.PersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
