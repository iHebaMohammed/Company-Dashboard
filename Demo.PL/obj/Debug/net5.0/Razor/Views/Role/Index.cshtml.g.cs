#pragma checksum "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0e3baaff76547a23caae212efd13a254401d2a5e2405d1444e686fb398504bd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL

#nullable disable
    ;
#nullable restore
#line 2 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models

#nullable disable
    ;
#nullable restore
#line 3 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Entities;

#nullable disable
#nullable restore
#line 4 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#nullable disable
#nullable restore
#line 5 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces;

#nullable disable
#nullable restore
#line 6 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0e3baaff76547a23caae212efd13a254401d2a5e2405d1444e686fb398504bd1", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"38e7aff1790e7b4c044e6fa555f7f1964937c0ec5c965df76d961ef95cc3c80f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>All Role</h1>\r\n<br />\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e3baaff76547a23caae212efd13a254401d2a5e2405d1444e686fb398504bd15720", async() => {
                WriteLiteral(@"
    <div class=""row align-content-sm-center justify-content-center"">
        <div class=""col-8"">
            <input type=""text"" placeholder=""Search By Name"" class=""form-control"" name=""SearchValue"" />
        </div>
        <div class=""col-4"">
            <input type=""submit"" value=""Search"" class=""btn btn-success""/>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e3baaff76547a23caae212efd13a254401d2a5e2405d1444e686fb398504bd17569", async() => {
                WriteLiteral("Create New Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 25 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <br />\r\n    <br />\r\n    <table class=\"table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                \r\n                <th>");
            Write(
#nullable restore
#line 33 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
                     Html.DisplayNameFor(R => R.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th>");
            Write(
#nullable restore
#line 34 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
                     Html.DisplayNameFor(R => R.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 41 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\r\n                    <th>");
            Write(
#nullable restore
#line 44 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
                         Html.DisplayFor(M => item.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                    <th>");
            Write(
#nullable restore
#line 45 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
                         Html.DisplayFor(M => item.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e3baaff76547a23caae212efd13a254401d2a5e2405d1444e686fb398504bd110863", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = 
#nullable restore
#line 46 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
                                                               item.Id

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 48 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 51 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"m-5 alert alert-warning\">\r\n        <h3>There is No Users</h3>\r\n    </div>\r\n");
#nullable restore
#line 57 "E:\Repos\Projects\Company-Dashboard\Demo.PL\Views\Role\Index.cshtml"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
