#pragma checksum "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c0675ef79aa26b621ac762addc5bd9b6bd45c67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BanhMi_Index), @"mvc.1.0.view", @"/Views/BanhMi/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0675ef79aa26b621ac762addc5bd9b6bd45c67", @"/Views/BanhMi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba5a60320d960d3c6a8413692e2664b2809d234", @"/Views/_ViewImports.cshtml")]
    public class Views_BanhMi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vpop.ViewModels.OrderBanhMiViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
  
    ViewData["Title"] = "Vpop Page";
    Layout = "_MainMenu";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container body-content\">\r\n\t<h3>BANH MI Order Form </h3>\r\n\t<p>A Vietnamese baguette sandwich served with influences from the French an;d native\r\n\tVietnamese ingredients (pickled medley, cilantro, cucumber)</p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c0675ef79aa26b621ac762addc5bd9b6bd45c674007", async() => {
                WriteLiteral("\r\n           <div>\r\n                <input type=\"hidden\" name=\"Custname\" value=\" \" />\r\n           </div>\r\n           <p class=\"headerText\">Pick a protein below</p> \r\n           <p>\r\n");
#nullable restore
#line 18 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
                 foreach (var protein in Model.Protein1Choices)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                   <span class=\".radioalign\">\r\n                       <input type=\"radio\" name=\"item\"");
                BeginWriteAttribute("id", " id=\"", 735, "\"", 752, 1);
#nullable restore
#line 21 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 740, protein.Key, 740, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 753, "\"", 775, 1);
#nullable restore
#line 21 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 761, protein.Value, 761, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 776, "", 812, 1);
#nullable restore
#line 21 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 785, protein.Key == "Veggie ", 785, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                       <label");
                BeginWriteAttribute("for", " for=\"", 846, "\"", 864, 1);
#nullable restore
#line 22 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 852, protein.Key, 852, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
                                            Write(protein.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> \r\n                   </span>\r\n");
#nullable restore
#line 24 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("               <br/>\r\n");
#nullable restore
#line 26 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
                foreach (var protein in Model.Protein2Choices)
               {

#line default
#line hidden
#nullable disable
                WriteLiteral("                  <span class=\".radioalign\">\r\n                      <input type=\"radio\" name=\"item\"");
                BeginWriteAttribute("id", " id=\"", 1141, "\"", 1158, 1);
#nullable restore
#line 29 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 1146, protein.Key, 1146, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1159, "\"", 1181, 1);
#nullable restore
#line 29 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 1167, protein.Value, 1167, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 1182, "", 1218, 1);
#nullable restore
#line 29 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 1191, protein.Key == "Veggie ", 1191, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                      <label");
                BeginWriteAttribute("for", " for=\"", 1251, "\"", 1269, 1);
#nullable restore
#line 30 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 1257, protein.Key, 1257, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
                                           Write(protein.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> \r\n                  </span>\r\n");
#nullable restore
#line 32 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
                WriteLiteral("          </p>\r\n            <p>\r\n                <input type=\"hidden\" name=\"category\" value=\"Banh Mi\" />\r\n                <input type=\"hidden\" name=\"CurrDate\"");
                BeginWriteAttribute("value", " value=\"", 1499, "\"", 1543, 1);
#nullable restore
#line 36 "C:\Users\jtruo\source\repos\capstone-project\Vpop\Vpop\Views\BanhMi\Index.cshtml"
WriteAttributeValue("", 1507, DateTime.Now.ToString("MM/dd/yyyy"), 1507, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </p>\r\n            <p>\r\n                <input type=\"submit\" value=\"Submit\"/>\r\n          </p>\r\n   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vpop.ViewModels.OrderBanhMiViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
