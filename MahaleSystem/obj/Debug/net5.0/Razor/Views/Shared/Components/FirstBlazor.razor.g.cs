#pragma checksum "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\FirstBlazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f234a237efb1c49804636835cf257f3358521c5b"
// <auto-generated/>
#pragma warning disable 1591
namespace MahaleSystem.Views.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class FirstBlazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"card-header\"><h3>Data Component</h3>\r\n    <button onclick=\"Getdata\" class=\"btn btn-success\">Click to GetData</button></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-body");
            __builder.AddMarkupContent(3, "<br>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "badge-primary");
            __builder.AddContent(6, 
#nullable restore
#line 7 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\FirstBlazor.razor"
                                counter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "E:\ITIProject\New folder\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Shared\Components\FirstBlazor.razor"
       
    //[Parameter]
    //public string Data { get; set; } = string.Empty;
    //[Parameter]
    //public string style { get; set; }
    public int counter = 1;
    public void Getdata()
    {
        counter++;

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
