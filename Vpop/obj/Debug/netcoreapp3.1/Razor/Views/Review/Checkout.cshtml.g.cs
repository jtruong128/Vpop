#pragma checksum "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbfaa338125ef396e579ea63190a32c94a645833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review_Checkout), @"mvc.1.0.view", @"/Views/Review/Checkout.cshtml")]
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
#line 1 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\_ViewImports.cshtml"
using Vpop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\_ViewImports.cshtml"
using Vpop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbfaa338125ef396e579ea63190a32c94a645833", @"/Views/Review/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba5a60320d960d3c6a8413692e2664b2809d234", @"/Views/_ViewImports.cshtml")]
    public class Views_Review_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
  
    ViewData["Title"] = "Vpop Page";
    Layout = "_MainMenu";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container body-content\">\r\n");
#nullable restore
#line 7 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
    if (ViewBag.orderCust.Count > 0) 
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Payment Summary</h3>\r\n         <br/>\r\n         <table class=\"table\">\r\n               <tr>\r\n                       <th>Order Date: ");
#nullable restore
#line 13 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                                  Write(ViewBag.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n               </tr>\r\n               <tr>\r\n                       <th>Customer Email: ");
#nullable restore
#line 16 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                                      Write(ViewBag.custName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n               </tr>\r\n               <tr>\r\n                        <th>Order Number</th>\r\n                        <th>Category</th>\r\n                        <th>Item</th>\r\n                        <th>Price</th>\r\n               </tr>\r\n");
#nullable restore
#line 24 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                foreach (var ord in ViewBag.orderCust)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                           Write(ord.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                           Write(ord.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                           Write(ord.Item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>$");
#nullable restore
#line 30 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                            Write(ord.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            \r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>Total Price: $");
#nullable restore
#line 35 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
                                 Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                </table>\r\n");
#nullable restore
#line 38 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
    } 
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>There are no orders to review.</h3>\r\n");
#nullable restore
#line 42 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Checkout.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591