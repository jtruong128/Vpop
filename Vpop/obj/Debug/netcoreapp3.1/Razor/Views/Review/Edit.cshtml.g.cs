#pragma checksum "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff073e08aa94a956665ba638caa0a23d1e619850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review_Edit), @"mvc.1.0.view", @"/Views/Review/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff073e08aa94a956665ba638caa0a23d1e619850", @"/Views/Review/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba5a60320d960d3c6a8413692e2664b2809d234", @"/Views/_ViewImports.cshtml")]
    public class Views_Review_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Review/Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
  
    ViewData["Title"] = "Vpop Page";
    Layout = "_MainMenu";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container body-content\">\r\n\t<h3>Change Order </h3>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff073e08aa94a956665ba638caa0a23d1e6198504154", async() => {
                WriteLiteral("\r\n         <p>\r\n              <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=", 240, "", 268, 1);
#nullable restore
#line 10 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 247, ViewBag.orderEdit.Id, 247, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <input type=\"hidden\" name=\"currDate\"");
                BeginWriteAttribute("value", " value=\"", 321, "\"", 365, 1);
#nullable restore
#line 11 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 329, DateTime.Now.ToString("MM/dd/yyyy"), 329, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n         </p>\r\n         <p>\r\n              <label for=\"custname\">Customer Email:  <input type=\"text\" name=\"custname\"");
                BeginWriteAttribute("value", " value =\"", 485, "\"", 521, 1);
#nullable restore
#line 14 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 494, ViewBag.orderEdit.Custname, 494, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled></label>\r\n         </p>\r\n");
#nullable restore
#line 16 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
           if (ViewBag.orderEdit.Category == "Salad Bowl" || ViewBag.orderEdit.Category == "Vermicelli Bowl" || ViewBag.orderEdit.Category == "Rice Bowl")
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <p class=\"headerText\">Pick a bowl below</p>\r\n");
#nullable restore
#line 19 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
               foreach (var category in ViewBag.categories)
              {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span>\r\n                    <input type=\"radio\" name=\"category\"");
                BeginWriteAttribute("id", " id=\"", 942, "\"", 960, 1);
#nullable restore
#line 22 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 947, category.Key, 947, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 961, "\"", 984, 1);
#nullable restore
#line 22 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 969, category.Value, 969, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 985, "", 1040, 1);
#nullable restore
#line 22 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 994, category.Key == @ViewBag.orderEdit.Category, 994, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1071, "\"", 1090, 1);
#nullable restore
#line 23 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 1077, category.Key, 1077, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                                          Write(category.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </span>\r\n");
#nullable restore
#line 25 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("             <p class=\"headerText\">Pick a protein below</p>\r\n             <p>       \r\n");
#nullable restore
#line 28 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                 foreach (var protein in ViewBag.proteins)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span>\r\n                        <input type=\"radio\" name=\"item\"");
                BeginWriteAttribute("id", " id=\"", 1407, "\"", 1424, 1);
#nullable restore
#line 31 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 1412, protein.Key, 1412, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1425, "\"", 1447, 1);
#nullable restore
#line 31 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 1433, protein.Value, 1433, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 1448, "", 1497, 1);
#nullable restore
#line 31 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 1457, protein.Key == ViewBag.orderEdit.Item, 1457, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1531, "\"", 1549, 1);
#nullable restore
#line 32 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 1537, protein.Key, 1537, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                                             Write(protein.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </span>\r\n");
#nullable restore
#line 34 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </p>\r\n");
#nullable restore
#line 36 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
          }
          else if (ViewBag.orderEdit.Category == "Banh Mi")
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("             <p>\r\n                 <input type=\"hidden\" name=\"category\"");
                BeginWriteAttribute("value", " value=\"", 1799, "\"", 1834, 1);
#nullable restore
#line 40 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 1807, ViewBag.orderEdit.Category, 1807, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n             </p>\r\n             <p class=\"headerText\">Pick a protein below</p>\r\n             <p>\r\n");
#nullable restore
#line 44 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                   foreach (var protein in ViewBag.protein1)
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                     <input type=\"radio\" name=\"item\"");
                BeginWriteAttribute("id", " id=\"", 2071, "\"", 2088, 1);
#nullable restore
#line 46 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2076, protein.Key, 2076, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2089, "\"", 2111, 1);
#nullable restore
#line 46 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2097, protein.Value, 2097, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 2112, "", 2161, 1);
#nullable restore
#line 46 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2121, protein.Key == ViewBag.orderEdit.Item, 2121, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                     <label");
                BeginWriteAttribute("for", " for=\"", 2192, "\"", 2210, 1);
#nullable restore
#line 47 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2198, protein.Key, 2198, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                                          Write(protein.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 48 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <br />\r\n");
#nullable restore
#line 50 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                  foreach (var protein in ViewBag.protein2)
                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"radio\" name=\"item\"");
                BeginWriteAttribute("id", " id=\"", 2414, "\"", 2431, 1);
#nullable restore
#line 52 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2419, protein.Key, 2419, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2432, "\"", 2454, 1);
#nullable restore
#line 52 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2440, protein.Value, 2440, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 2455, "", 2504, 1);
#nullable restore
#line 52 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2464, protein.Key == ViewBag.orderEdit.Item, 2464, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 2534, "\"", 2552, 1);
#nullable restore
#line 53 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2540, protein.Key, 2540, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 53 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                                         Write(protein.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 54 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                 }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </p>\r\n");
#nullable restore
#line 56 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
          }
          else if (ViewBag.orderEdit.Category == "Snacks")
          {


#line default
#line hidden
#nullable disable
                WriteLiteral("             <p>\r\n                  <input type=\"hidden\" name=\"category\"");
                BeginWriteAttribute("value", " value=\"", 2776, "\"", 2811, 1);
#nullable restore
#line 61 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 2784, ViewBag.orderEdit.Category, 2784, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n             </p>\r\n             <p class=\"headerText\">Pick a Snack below</p>\r\n             <p>\r\n");
#nullable restore
#line 65 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                   foreach (var snack in  ViewBag.snacks1)
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span>\r\n                            <input type=\"radio\" name=\"item\"");
                BeginWriteAttribute("id", " id=\"", 3080, "\"", 3095, 1);
#nullable restore
#line 68 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 3085, snack.Key, 3085, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3096, "\"", 3116, 1);
#nullable restore
#line 68 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 3104, snack.Value, 3104, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 3117, "", 3164, 1);
#nullable restore
#line 68 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 3126, snack.Key == ViewBag.orderEdit.Item, 3126, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 3203, "\"", 3219, 1);
#nullable restore
#line 69 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 3209, snack.Key, 3209, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 69 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                                               Write(snack.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </span>\r\n");
#nullable restore
#line 71 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("             </p>\r\n             <p>\r\n");
#nullable restore
#line 74 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                   foreach (var snack in  ViewBag.snacks2)
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span>\r\n                            <input type=\"radio\" name=\"item\"");
                BeginWriteAttribute("id", " id=\"", 3498, "\"", 3513, 1);
#nullable restore
#line 77 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 3503, snack.Key, 3503, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3514, "\"", 3534, 1);
#nullable restore
#line 77 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 3522, snack.Value, 3522, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 3535, "", 3582, 1);
#nullable restore
#line 77 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 3544, snack.Key == ViewBag.orderEdit.Item, 3544, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 3621, "\"", 3637, 1);
#nullable restore
#line 78 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
WriteAttributeValue("", 3627, snack.Key, 3627, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 78 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                                               Write(snack.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </span>\r\n");
#nullable restore
#line 80 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("             </p>\r\n");
#nullable restore
#line 82 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\Review\Edit.cshtml"
           }

#line default
#line hidden
#nullable disable
                WriteLiteral("          <p>\r\n               <input type=\"submit\" value=\"Submit\" />\r\n          </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
