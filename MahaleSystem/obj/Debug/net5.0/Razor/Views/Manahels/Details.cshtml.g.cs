#pragma checksum "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8746d428c65dd5fb1930549d06ef4dc275d5f43f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manahels_Details), @"mvc.1.0.view", @"/Views/Manahels/Details.cshtml")]
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
#line 1 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8746d428c65dd5fb1930549d06ef4dc275d5f43f", @"/Views/Manahels/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0b08fc69a19b4e1441a5b3b5577be667368eea", @"/Views/_ViewImports.cshtml")]
    public class Views_Manahels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MahaleSystem.ViewModel.Manahel.ManhalDetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>

<!-- Row Vertical Scriollable Data Table Responsive-->
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card custom-card"">
            <div class=""card-body"">
                <div>
                    <h6 class=""card-title mb-1"">Vertical Scrollable Data Table</h6>
                    <p class=""text-muted card-sub-title"">Responsive is an extension for DataTables that resolves that problem by optimising the table's layout for different screen sizes through the dynamic insertion and removal of columns from the table.</p>
                </div>
                <div class=""table-responsive"">
                    <table id=""example3"" class=""table table-striped table-bordered text-nowrap"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 23 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.khalias.First().Ssn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 26 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.khalias.First().KhaliaLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 29 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.khalias.First().KhaliaType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 32 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.khalias.First().PraweezCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 35 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.khalias.First().Wood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 38 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.khalias.First().Queues.QueueStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 41 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.khalias.First().Queues.DateFertilization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 47 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                             foreach (var item in Model.khalias)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 51 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Ssn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 54 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.KhaliaLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 57 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.KhaliaType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 60 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PraweezCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 63 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Wood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 66 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Queues.QueueStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 69 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                         if (item.Queues.QueueStatus == "Fertilized")
                                        {
                                            string date = item.Queues.DateFertilization.Value.ToShortDateString();
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                       Write(date);

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                                 
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        \r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8746d428c65dd5fb1930549d06ef4dc275d5f43f13319", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 80 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 89 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
     foreach (var item in Model.imagesManahels)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-body text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8746d428c65dd5fb1930549d06ef4dc275d5f43f16384", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4547, "~/images/", 4547, 9, true);
#nullable restore
#line 93 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
AddHtmlAttributeValue("", 4556, item.ImagesString, 4556, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8746d428c65dd5fb1930549d06ef4dc275d5f43f17985", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idImg", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idImg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idImg", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idImg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 97 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-body text-center\">\r\n            ");
#nullable restore
#line 100 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.Partial("_AddManhalImage", ViewData["ManhalImage"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<!-- End Row -->\r\n<div class=\"container mr-2\">\r\n    <h4>Manahel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.manhal.Ssn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 116 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayFor(model => model.manhal.Ssn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 119 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.manhal.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayFor(model => model.manhal.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 125 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.manhal.LocationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 128 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayFor(model => model.manhal.LocationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 131 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.manhal.FlowerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 134 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayFor(model => model.manhal.FlowerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 137 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.manhal.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 140 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayFor(model => model.manhal.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 143 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.manhal.DateUpdated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 146 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
       Write(Html.DisplayFor(model => model.manhal.DateUpdated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8746d428c65dd5fb1930549d06ef4dc275d5f43f25216", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\Details.cshtml"
                           WriteLiteral(Model.manhal.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8746d428c65dd5fb1930549d06ef4dc275d5f43f27382", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MahaleSystem.ViewModel.Manahel.ManhalDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
