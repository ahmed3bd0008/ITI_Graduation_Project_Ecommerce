#pragma checksum "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\DetailsAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46428ab48dd8eee62bee74465ddac03c7e8af30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manahels_DetailsAll), @"mvc.1.0.view", @"/Views/Manahels/DetailsAll.cshtml")]
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
#line 1 "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46428ab48dd8eee62bee74465ddac03c7e8af30", @"/Views/Manahels/DetailsAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0b08fc69a19b4e1441a5b3b5577be667368eea", @"/Views/_ViewImports.cshtml")]
    public class Views_Manahels_DetailsAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MahaleSystem.ViewModel.Manahel.InfoVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manahels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn ripple btn-secondary navresponsive-toggler mb-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid"">
    <!-- Page Header -->
    <div class=""page-header"">
        <div>
            <h2 class=""main-content-title tx-24 mg-b-5"">This Is Home Page</h2>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">this Display All Details for all Manahel</li>
            </ol>
        </div>
        <div class=""d-flex"">
            <div class=""ml-2"">
                <a class=""btn ripple btn-outline-primary dropdown-toggle mb-0"" href=""#"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
                    <i class=""fe fe-external-link float-right ml-1 mt-1""></i>  <i class=""fas fa-caret-down mr-1 mt-1 float-left""></i> Export
                </a>
                <div class=""dropdown-menu tx-13"">
");
            WriteLiteral("                    <a class=\"dropdown-item\" href=\"#\"><i class=\"far fa-file-excel ml-2\"></i>Export as Excel</a>\r\n                </div>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1331, "\"", 1339, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e46428ab48dd8eee62bee74465ddac03c7e8af305456", async() => {
                WriteLiteral("Add New Manahal");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- End Page Header -->\r\n</div>\r\n\r\n\r\n<!-- Row -->\r\n<div class=\"row row-sm\">\r\n");
#nullable restore
#line 37 "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\DetailsAll.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 col-xl-3 col-lg-6\">\r\n        <div class=\"card custom-card\">\r\n            <div class=\"card-body dash1\">\r\n                <div class=\"d-flex\">\r\n                    <p class=\"mb-1 tx-inverse\">");
#nullable restore
#line 43 "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\DetailsAll.cshtml"
                                          Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"mr-auto\">\r\n                        <i class=\"fas fa-chart-line fs-20 text-primary\"></i>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    <h3 class=\"dash-25\">");
#nullable restore
#line 49 "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\DetailsAll.cshtml"
                                   Write(item.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"progress mb-1\">\r\n                    <div");
            BeginWriteAttribute("aria-valuemax", " aria-valuemax=\"", 2237, "\"", 2270, 1);
#nullable restore
#line 52 "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\DetailsAll.cshtml"
WriteAttributeValue("", 2253, item.value+100, 2253, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2289, "\"", 2316, 1);
#nullable restore
#line 52 "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\DetailsAll.cshtml"
WriteAttributeValue("", 2305, item.value, 2305, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"progress-bar progress-bar-xs wd-70p\" role=\"progressbar\"></div>\r\n                </div>\r\n                <div class=\"expansion-label d-flex\">\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\doaar\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Manahels\DetailsAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""row"">
    <div class=""col-sm-12 col-xl-12 col-lg-12"">
        <div class=""card custom-card"">
            <div class=""card-body dash1"">
                <div class=""d-flex"">
                    <p class=""mb-1 tx-inverse"">The general average of the apiaries</p>
                    <div class=""mr-auto"">
                        <i class=""fas fa-chart-line fs-20 text-primary""></i>
                    </div>
                </div>
                <div>
                    <h3 class=""dash-25"">66%</h3>
                </div>
                <div class=""progress mb-1"">
                    <div aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""66"" class=""progress-bar progress-bar-xs wd-70p bg-warning"" role=""progressbar""></div>
                </div>
                <div class=""expansion-label d-flex"">
");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>


    <!-- Row -->
    <div class=""row"">
        <div class=""col-lg-6 col-md-12"">
            <div class=""card custom-card"">
                <div class=""card-body"">
                    <div>
                        <h6 class=""card-title mb-1"">Bar Chart1</h6>
                        <p class=""text-muted  card-sub-title"">Below is the basic bar chart example..</p>
                    </div>
                    <div class=""ht-200 ht-sm-300"" id=""flotBar1""></div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Row -->


    <script>
        $(function () {
            'use strict';
            /* Flot Chart1*/
            $.plot('#flotBar1', [{
                data: [
                    [0, 3],
                    [1, 8],
                    [2, 5],
                    [3, 13],
                    [4, 5],
                    [5, 7],
                    [6, 4],
           ");
            WriteLiteral(@"         [7, 6],
                    [8, 3],
                    [9, 7]
                ]
            }], {
                series: {
                    bars: {
                        show: true,
                        lineWidth: 0,
                        fillColor: '#8760fb',
                        barWidth: .5
                    },
                    highlightColor: '#7c59e6'
                },
                grid: {
                    borderWidth: 1,
                    borderColor: 'rgba(119, 119, 142, 0.2)',
                    hoverable: true
                },
                yaxis: {
                    tickColor: 'rgba(119, 119, 142, 0.2)',
                    font: {
                        color: '#77778e',
                        size: 10
                    }
                },
                xaxis: {
                    tickColor: 'rgba(119, 119, 142, 0.2)',
                    font: {
                        color: '#77778e',
                        size:");
            WriteLiteral(@" 10
                    }
                }
            });

            var newCust = [
                [0, 2],
                [1, 3],
                [2, 6],
                [3, 5],
                [4, 7],
                [5, 8],
                [6, 10]
            ];
            var retCust = [
                [0, 1],
                [1, 2],
                [2, 5],
                [3, 3],
                [4, 5],
                [5, 6],
                [6, 9]
            ];

            var plot = $.plot($('#flotLine1'), [{
                data: newCust,
                label: 'New Customer',
                color: '#8760fb'
            }, {
                data: retCust,
                label: 'Returning Customer',
                color: '#eb6f33'
            }], {
                series: {
                    lines: {
                        show: true,
                        lineWidth: 2
                    },
                    shadowSize: 0
                },
");
            WriteLiteral(@"                points: {
                    show: false,
                },
                legend: {
                    noColumns: 1,
                    position: 'nw'
                },
                grid: {
                    hoverable: true,
                    clickable: true,
                    borderWidth: 0,
                    labelMargin: 5
                },
                yaxis: {
                    min: 0,
                    max: 15,
                    color: 'rgba(119, 119, 142, 0.2)',
                    font: {
                        size: 10,
                        color: '#77778e'
                    }
                },
                xaxis: {
                    color: 'rgba(119, 119, 142, 0.2)',
                    font: {
                        size: 10,
                        color: '#77778e'
                    }
                }
            });
            function labelFormatter(label, series) {
                return '<div style=""font");
            WriteLiteral("-size:8pt; text-align:center; padding:2px; color:white;\">\' + label + \'<br/>\' + Math.round(series.percent) + \'%</div>\';\r\n            }\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MahaleSystem.ViewModel.Manahel.InfoVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
