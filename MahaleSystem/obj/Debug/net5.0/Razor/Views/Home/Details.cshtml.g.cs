#pragma checksum "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8072b2590e9e165e684f80d9da614f6f3e57c389"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#nullable restore
#line 3 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.ViewModel.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using MahaleSystem.ViewModel.Administration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8072b2590e9e165e684f80d9da614f6f3e57c389", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e91d1512ae8554956f31c553855f259279f46e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MahaleSystem.ViewModel.Product.PublishClientVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
  
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"">
    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <h2>products Details</h2>
                <ol>
                    <li><a href=""index.html"">Home</a></li>
                    <li>product Details</li>
                </ol>
            </div>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Portfolio Details Section ======= -->
    <section id=""portfolio-details"" class=""portfolio-details"">
        <div class=""container"">

            <div class=""row gy-4"">

                <div class=""col-lg-7"">
                    <div class=""portfolio-details-slider swiper-container"">
                        <div class=""swiper-wrapper align-items-center"">
");
#nullable restore
#line 29 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                               var imgString = "";
                                try
                                {
                                    var imgs = Model.product.ImageProducts.ToList();
                                    if (imgs != null)
                                    {
                                        foreach (var item in imgs)
                                        {
                                            imgString = item.ImagesString;
                                            if (imgString == null)
                                                imgString = "../../assets/img/users/2.jpg";
                                            else
                                                imgString = "../../images/" + imgString;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"swiper-slide\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=", 1908, "", 1923, 1);
#nullable restore
#line 43 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
WriteAttributeValue("", 1913, imgString, 1913, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-gallery=\"portfolioGallery\" class=\"img-fluid\" style=\"height:400px\" />\r\n                                                <!--<img src=\"assets/img/portfolio/portfolio-1.jpg\" alt=\"\">product image-->\r\n                                            </div>\r\n");
#nullable restore
#line 46 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                        }
                                    }
                                }
                                catch { 
                                    imgString = "../../assets/img/users/2.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"swiper-slide\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=", 2524, "", 2539, 1);
#nullable restore
#line 52 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
WriteAttributeValue("", 2529, imgString, 2529, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-gallery=\"portfolioGallery\" class=\"img-fluid\" style=\"height:400px\" />\r\n                                        <!--<img src=\"assets/img/portfolio/portfolio-1.jpg\" alt=\"\">product image-->\r\n                                    </div>\r\n");
#nullable restore
#line 55 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""swiper-pagination""></div>
                    </div>
                </div>
                <style>
                    .spanInfo{
                        border:1px solid #000;
                        margin-left:5px;
                        padding:2px 5px;
                    }
                </style>
                <div class=""col-lg-5"">
                    <div class=""portfolio-info"">
                        <h3>product information</h3>
                        <ul>
");
#nullable restore
#line 72 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                               string dte = @Model.productPublished.datePublish.ToShortDateString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><strong>product name:</strong>\r\n                            <span class=\"spanInfo\">");
#nullable restore
#line 74 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                              Write(Model.productPublished.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            <li><strong>product price:</strong>\r\n                                <span class=\"spanInfo\">");
#nullable restore
#line 76 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                                  Write(Model.productPublished.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            <li><strong>product description: </strong>\r\n                                <span class=\"spanInfo\">");
#nullable restore
#line 78 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                                  Write(Model.productPublished.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            <li><strong>Flower Name:</strong>\r\n                                <span class=\"spanInfo\">");
#nullable restore
#line 80 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                                  Write(Model.product.FlowerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            <li><strong>Date of Production:</strong>\r\n                                <span class=\"spanInfo\">");
#nullable restore
#line 82 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                                  Write(dte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            <li><strong>Contact with Phone Number:</strong>\r\n                                <span class=\"spanInfo\">");
#nullable restore
#line 84 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                                  Write(Model.admin.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            <li><strong>Email:</strong>\r\n                                <span class=\"spanInfo\">");
#nullable restore
#line 86 "D:\ITI\ITI_Project\ITI_Graduation_Project_Ecommerce\MahaleSystem\Views\Home\Details.cshtml"
                                                  Write(Model.admin.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                        </ul>
                    </div>
                    <!-- <div class=""portfolio-description"">
                        <h2>This is an example of product detail</h2>
                        <p>
                          Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.
                        </p>
                      </div>
                    </div> -->

                </div>

            </div>
            </div>
    </section><!-- End Portfolio Details Section -->

</main><!-- End #main -->

<section id=""contact"" class=""contact"">
    <div class=""container"">

        <div class=""section-title"">
            <h2 style=""color: #b85c11;""> تواصل معنا للطلب او الاستعلام</h2>
        </div>

   ");
            WriteLiteral(@"     <div class=""row"">

            <div class=""col-lg-8 d-flex align-items-stretch"">
                <div class=""info"">
                    <div class=""address"">
                        <i class=""bi bi-geo-alt""></i>
                        <h4>Location:</h4>
                        <p> ميدان المحطه_ مركز مغاغه_ محافظه المنيا</p>
                    </div>

                    <div class=""email"">
                        <i class=""bi bi-envelope""></i>
                        <h4>Email:</h4>
                        <p>sam.team@example.com</p>
                    </div>

                    <div class=""phone"">
                        <i class=""bi bi-phone""></i>
                        <h4>Call:</h4>
                        <p>+201011273949</p>
                    </div>
                    <div class=""mapouter""><div class=""gmap_canvas""><iframe width=""600"" height=""500"" id=""gmap_canvas"" src=""https://maps.google.com/maps?q=%D9%85%D9%8A%D8%AF%D8%A7%D9%86%20%D8%A7%D9%84%D9%85%D8%AD%D8%B7%D9%87,%2");
            WriteLiteral(@"0maghagha&t=&z=13&ie=UTF8&iwloc=&output=embed"" frameborder=""0"" style=""border:0; width: 100%; height: 290px;"" allowfullscreen></iframe><a href=""https://www.whatismyip-address.com/divi-discount/""></a><br>
                    <style>
                        .mapouter {
                            position: relative;
                            text-align: right;
                            height: 500px;
                            width: 600px;
                        }
                    </style><a href=""https://www.embedgooglemap.net"">google map website embed</a>
                    <style>
                        .gmap_canvas {
                            overflow: hidden;
                            background: none !important;
                            height: 300px;
                            width: 400px;
                        }
                    </style></div></div>
                </div>

            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MahaleSystem.ViewModel.Product.PublishClientVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
