#pragma checksum "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fab8b2efa5aa3cacb4af92572a4e11dc29fbf73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SwitchBook.Pages.Trade.Views_Trade_Index), @"mvc.1.0.view", @"/Views/Trade/Index.cshtml")]
namespace SwitchBook.Pages.Trade
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
#line 1 "E:\repos\Switch-Book\SwitchBook\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\repos\Switch-Book\SwitchBook\Views\_ViewImports.cshtml"
using SwitchBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\repos\Switch-Book\SwitchBook\Views\_ViewImports.cshtml"
using SwitchBook.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fab8b2efa5aa3cacb4af92572a4e11dc29fbf73", @"/Views/Trade/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbed7b9c09cb0d8838aa474c5421d7ca06d55e34", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Trade_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SwitchBook.ViewModels.TradeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Trade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
  
    ViewData["Title"] = "??????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>??????????</h2>\r\n\r\n<div>\r\n    <div class=\"book_trade\">\r\n        <div class=\"book_trade_book\">\r\n            <h5>???????????????? ??????????</h5>\r\n            <div class=\"avaliable_book\" style=\"height: fit-content;\">\r\n");
#nullable restore
#line 13 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                 if (Model.Book.Image != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img class=\"avaliable_book_image\"");
            BeginWriteAttribute("src", " src=\"", 410, "\"", 482, 2);
            WriteAttributeValue("", 416, "data:image/jpeg;base64,", 416, 23, true);
#nullable restore
#line 15 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
WriteAttributeValue("", 439, Convert.ToBase64String(Model.Book.Image), 439, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 16 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"avaliable_book_text\">\r\n                    <h4>");
#nullable restore
#line 18 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.Book.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <hr/>\r\n                    <h5>");
#nullable restore
#line 20 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.Book.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"book_trade_book\">\r\n            <h5>???? ??????????</h5>\r\n                <div class=\"book_trade_choice\">\r\n");
#nullable restore
#line 27 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                 foreach (var item in Model.MyBooks)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fab8b2efa5aa3cacb4af92572a4e11dc29fbf736782", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1122, "\"", 1145, 1);
#nullable restore
#line 30 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
WriteAttributeValue("", 1130, ViewBag.bookId, 1130, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"bookId\"/>\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1208, "\"", 1224, 1);
#nullable restore
#line 31 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
WriteAttributeValue("", 1216, item.Id, 1216, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"myBookId\"/>\r\n                        <div class=\"avaliable_book\">\r\n");
#nullable restore
#line 33 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                             if (item.Image != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <img class=\"avaliable_book_image\"");
                BeginWriteAttribute("src", " src=\"", 1449, "\"", 1515, 2);
                WriteAttributeValue("", 1455, "data:image/jpeg;base64,", 1455, 23, true);
#nullable restore
#line 35 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
WriteAttributeValue("", 1478, Convert.ToBase64String(item.Image), 1478, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 36 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"avaliable_book_image\"></div>\r\n");
#nullable restore
#line 40 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"avaliable_book_text\">\r\n                                <h4>");
#nullable restore
#line 42 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                <hr/>\r\n                                <h5>");
#nullable restore
#line 44 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <input type=\"submit\" class=\"btn btn_book\" value=\"????????????\">\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "E:\repos\Switch-Book\SwitchBook\Views\Trade\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n<hr/>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SwitchBook.ViewModels.TradeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
