#pragma checksum "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c62eba767c3aac62d7cdafbe3b1d9ca8b66791e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DisplayStatistics_DisplayStatistics), @"mvc.1.0.view", @"/Views/Shared/Components/DisplayStatistics/DisplayStatistics.cshtml")]
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
#nullable restore
#line 1 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
using MahaleSystem.ViewModel.Manahel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c62eba767c3aac62d7cdafbe3b1d9ca8b66791e0", @"/Views/Shared/Components/DisplayStatistics/DisplayStatistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e91d1512ae8554956f31c553855f259279f46e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DisplayStatistics_DisplayStatistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<InfoVM>[], int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-sm-12 col-xl-12 col-lg-12"">
        <div class=""card custom-card"">
            <div class=""card-body dash1"">
                <div class=""d-flex"">
                    <p class=""mb-1 tx-inverse"">The general average of the Manhal</p>
                    <div class=""mr-auto"">
                        <i class=""fas fa-chart-line fs-20 text-primary""></i>
                    </div>
                </div>
                <div>
                    <h3 class=""dash-25"">");
#nullable restore
#line 16 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
                                   Write(Model.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h3>\r\n                </div>\r\n                <div class=\"progress\">\r\n                    <div class=\"progress-bar bg-warning\"");
            BeginWriteAttribute("style", " style=\"", 729, "\"", 756, 3);
            WriteAttributeValue("", 737, "width:", 737, 6, true);
#nullable restore
#line 19 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
WriteAttributeValue("", 743, Model.Item2, 743, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 755, "%", 755, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"expansion-label d-flex\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 32 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
 foreach (var item1 in Model.Item1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Row -->\r\n    <div class=\"row row-sm\">\r\n");
#nullable restore
#line 36 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
         foreach (var item in item1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-6 col-xl-3 col-lg-6\">\r\n                <div class=\"card custom-card\">\r\n                    <div class=\"card-body dash1\">\r\n                        <div class=\"d-flex\">\r\n                            <p class=\"mb-1 tx-inverse\">");
#nullable restore
#line 42 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
                                                  Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""mr-auto"">
                                <i class=""fas fa-chart-line fs-20 text-primary""></i>
                            </div>
                        </div>
                        <div>
                            <h3 class=""dash-25"">");
#nullable restore
#line 48 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
                                           Write(item.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"progress\">\r\n");
#nullable restore
#line 54 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
                               int x = item.value / 5;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"progress-bar bg-warning\"");
            BeginWriteAttribute("style", " style=\"", 2233, "\"", 2250, 3);
            WriteAttributeValue("", 2241, "width:", 2241, 6, true);
#nullable restore
#line 55 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
WriteAttributeValue("", 2247, x, 2247, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2249, "%", 2249, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"expansion-label d-flex\">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 65 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <hr />\r\n");
#nullable restore
#line 68 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\DisplayStatistics\DisplayStatistics.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<InfoVM>[], int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
