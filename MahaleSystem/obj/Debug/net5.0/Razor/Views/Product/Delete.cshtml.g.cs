#pragma checksum "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ece81538155996adbc9ccae2e9805e4571577cb"
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
#line 1 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.ViewModel.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.ViewModel.Administration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ece81538155996adbc9ccae2e9805e4571577cb", @"/Views/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e91d1512ae8554956f31c553855f259279f46e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MahaleSystem.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .pContent{
        background-color:#00ffff;
        color:white;
        padding:1px 15px;
    }
    label{
        font-weight:bold;
    }
</style>
<h3 class=""text-danger text-center"">هل انت متاكد من حذف هذا المنتج</h3>
<div class=""alert alert-dismissible alert-warning"">
    <button type=""button"" class=""close"" data-dismiss=""alert"">&times;</button>
    <h4 class=""alert-heading"">Note!</h4>
    <p class=""mb-0"">عند حذف هذا المنتج سيتم ايظا حذف كل الصور المتعلقة به
    و عمليات البيع وعمليات الترويج ولن تستطيع استرجاع هذه البيانات مرة اخرى <a href=""#"" class=""alert-link""></a>.</p>
</div>
<hr />
<!-- Row -->
<div class=""row"">
    <div class=""col-lg-12 col-md-12"">
        <div class=""card custom-card"">
            <div class=""card-body"">
                <div>
                    <h1 class=""container"">حذف منتج</h1>
                    <p class=""text-muted card-sub-title""></p>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ece81538155996adbc9ccae2e9805e4571577cb6758", async() => {
                WriteLiteral("\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 1131, "\"", 1139, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-6 form-group\">\r\n                                <label class=\"form-label\">اسم المنتج:</label>\r\n                                <p><span class=\"pContent\">");
#nullable restore
#line 38 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n                            </div>\r\n                            <div class=\"col-lg-6 form-group\">\r\n                                <label class=\"form-label\">الكمية:</label>\r\n                                <p><span class=\"pContent\">");
#nullable restore
#line 42 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Model.ProductAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;");
#nullable restore
#line 42 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml"
                                                                               Write(Model.Containter);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6 form-group"">
                                <label class=""form-label"">اسم الزهرة:</label>
                                <p><span class=""pContent"">");
#nullable restore
#line 48 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.FlowerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n                            </div>\r\n                            <div class=\"col-lg-6 form-group\">\r\n                                <label class=\"form-label\">التاربخ: </label>\r\n");
#nullable restore
#line 52 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml"
                                   string txt = Model.DatePick.ToShortDateString();

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p><span class=\"pContent\">");
#nullable restore
#line 53 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(txt);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6 form-group"">
                                <label class=""form-label"">الوصف:</label>
                                <p><span class=""pContent"">");
#nullable restore
#line 59 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Product\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <button class=\"btn ripple btn-danger btn-block\" type=\"submit\">حذف المنتج</button>\r\n                ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ece81538155996adbc9ccae2e9805e4571577cb12686", async() => {
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
