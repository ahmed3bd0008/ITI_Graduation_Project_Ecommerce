#pragma checksum "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b53744c85b80e6e5b219cc4d3a92fe8d5aa29897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Delete), @"mvc.1.0.view", @"/Views/Product/Delete.cshtml")]
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
#nullable restore
#line 1 "E:\ITIProject\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITIProject\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITIProject\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITIProject\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.ViewModel.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ITIProject\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.ViewModel.Administration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ITIProject\MahaleSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53744c85b80e6e5b219cc4d3a92fe8d5aa29897", @"/Views/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e91d1512ae8554956f31c553855f259279f46e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MahaleSystem.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manahels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SuperAdminIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .pContent{
        background-color:blue;
        color:white;
        padding:1px 15px;
    }
    label{
        font-weight:bold;
    }
</style>
<h3 class=""text-danger text-center"">Are you sure you want to delete this Product</h3>
<div class=""alert alert-dismissible alert-warning"">
    <button type=""button"" class=""close"" data-dismiss=""alert"">&times;</button>
");
            WriteLiteral(@"</div>
<hr />
<!-- Row -->
<div class=""row"">
    <div class=""col-lg-12 col-md-12"">
        <div class=""card custom-card"">
            <div class=""card-body"">
                <div>
                    <h1 class=""container"">Delete this Product</h1>
                    <p class=""text-muted card-sub-title""></p>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53744c85b80e6e5b219cc4d3a92fe8d5aa298976218", async() => {
                WriteLiteral("\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 1124, "\"", 1132, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-6 form-group\">\r\n                                <label class=\"form-label\">Id:</label>\r\n                                <p><span class=\"pContent\">");
#nullable restore
#line 37 "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                                
                            </div>
                            <div class=""col-lg-6 form-group"">
                                <label class=""form-label"">Product Name:</label>
                                <p><span class=""pContent"">");
#nullable restore
#line 42 "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                                
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6 form-group"">
                                <label class=""form-label"">Product Amount:</label>
                                <p><span class=""pContent"">");
#nullable restore
#line 49 "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.ProductAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                                
                            </div>
                            <div class=""col-lg-6 form-group"">
                                <label class=""form-label"">Flawer Name:</label>
                                <p><span class=""pContent"">");
#nullable restore
#line 54 "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.FlowerName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                                
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6 form-group"">
                                <label class=""form-label"">Date pick: </label>
");
#nullable restore
#line 61 "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml"
                                   string txt = Model.DatePick.ToShortDateString();

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p><span class=\"pContent\">");
#nullable restore
#line 62 "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(txt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n                            </div>\r\n                            <div class=\"col-lg-6 form-group\">\r\n                                <label class=\"form-label\">manhal:</label>\r\n                                <p><span class=\"pContent\">");
#nullable restore
#line 66 "E:\ITIProject\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.ManhalId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <button class=\"btn ripple btn-danger btn-block\" type=\"submit\">Delete Product</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53744c85b80e6e5b219cc4d3a92fe8d5aa2989712246", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MahaleSystem.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
