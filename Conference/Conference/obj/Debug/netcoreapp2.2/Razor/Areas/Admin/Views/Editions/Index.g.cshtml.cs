#pragma checksum "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ecd3e985fc04e493635c62ad8e826255e3d5a2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Editions_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Editions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Editions/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Editions_Index))]
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
#line 1 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ecd3e985fc04e493635c62ad8e826255e3d5a2d", @"/Areas/Admin/Views/Editions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e16f7b6cceb4266df9bbeec1021e619275b7a7d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Editions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Editions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 25, true);
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(166, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ecd3e985fc04e493635c62ad8e826255e3d5a2d4006", async() => {
                BeginContext(189, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(203, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(290, 38, false);
#line 17 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(328, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(381, 40, false);
#line 20 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(421, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(474, 43, false);
#line 23 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TagLine));

#line default
#line hidden
            EndContext();
            BeginContext(517, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(570, 40, false);
#line 26 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(610, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(663, 42, false);
#line 29 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(705, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 35 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(832, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(891, 37, false);
#line 39 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(928, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(993, 39, false);
#line 42 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1097, 42, false);
#line 45 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TagLine));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1204, 39, false);
#line 48 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1308, 41, false);
#line 51 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1414, 53, false);
#line 54 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1491, 59, false);
#line 55 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1550, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1574, 57, false);
#line 56 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 59 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Areas\Admin\Views\Editions\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1682, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Editions>> Html { get; private set; }
    }
}
#pragma warning restore 1591