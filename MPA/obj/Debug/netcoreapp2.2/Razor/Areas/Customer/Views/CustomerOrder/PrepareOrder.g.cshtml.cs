#pragma checksum "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bbb7910eb3672e481e3502ccea177801b026e29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_CustomerOrder_PrepareOrder), @"mvc.1.0.view", @"/Areas/Customer/Views/CustomerOrder/PrepareOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/CustomerOrder/PrepareOrder.cshtml", typeof(AspNetCore.Areas_Customer_Views_CustomerOrder_PrepareOrder))]
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
#line 1 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\_ViewImports.cshtml"
using OnlinePharmacy;

#line default
#line hidden
#line 2 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\_ViewImports.cshtml"
using OnlinePharmacy.Models;

#line default
#line hidden
#line 2 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
using OnlinePharmacy.WebShopUtility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbb7910eb3672e481e3502ccea177801b026e29", @"/Areas/Customer/Views/CustomerOrder/PrepareOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c61a50e1935934fcd9d4f43bac260023ad25885", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_CustomerOrder_PrepareOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OnlinePharmacy.Models.ViewModels.CustomerOrderDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded border form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:75px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderPrepare", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderCancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderReady", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
  
    ViewData["Title"] = "PrepareOrder";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(210, 80, true);
            WriteLiteral("<br/>\r\n<h2 class=\"text-success\" style=\"text-align:left\"> Submitted Orders</h2>\r\n");
            EndContext();
            BeginContext(290, 4952, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bbb7910eb3672e481e3502ccea177801b026e297836", async() => {
                BeginContext(310, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 11 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
                BeginContext(348, 70, true);
                WriteLiteral("        <div class=\"container row bg-white p-2 border mb-3 rounded\">\r\n");
                EndContext();
#line 14 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(475, 258, true);
                WriteLiteral(@"                <div class=""col-12 pb-3 pt-3"">
                    <div class=""backgroundghostWhiteBorder10Padding"">
                        <div class=""row"">
                            <div class=""col-3"">
                                Order Number : ");
                EndContext();
                BeginContext(734, 27, false);
#line 20 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                          Write(item.CustomerOrderHeader.Id);

#line default
#line hidden
                EndContext();
                BeginContext(761, 58, true);
                WriteLiteral("\r\n                                <ul class=\"text-info\">\r\n");
                EndContext();
#line 22 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                     foreach (var details in item.CustomerOrderDetails)
                                    {

#line default
#line hidden
                BeginContext(947, 44, true);
                WriteLiteral("                                        <li>");
                EndContext();
                BeginContext(992, 12, false);
#line 24 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                       Write(details.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1004, 3, true);
                WriteLiteral(" x ");
                EndContext();
                BeginContext(1008, 13, false);
#line 24 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                                       Write(details.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1021, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 25 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1067, 520, true);
                WriteLiteral(@"                                </ul>
                            </div>
                            <div class=""col-5 pb-2"">
                                <div class=""input-group pb-2"">
                                    <div class=""input-group-append"">
                                        <span style=""width:120px"" class=""input-group-text"">PickUp Time   </span>
                                    </div>
                                    <input type=""text"" class=""border rounded form-control"" readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1587, "\"", 1631, 1);
#line 33 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
WriteAttributeValue("", 1595, item.CustomerOrderHeader.PickUpTime, 1595, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1632, 429, true);
                WriteLiteral(@" />
                                </div>
                                <div class=""input-group pb-2"">
                                    <div class=""input-group-append"">
                                        <span style=""width:120px"" class=""input-group-text"">Address</span>
                                    </div>
                                    <input type=""text"" class=""border rounded form-control"" readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2061, "\"", 2108, 1);
#line 39 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
WriteAttributeValue("", 2069, item.CustomerOrderHeader.PickUpAddress, 2069, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2109, 49, true);
                WriteLiteral(" />\r\n                                </div>\r\n\r\n\r\n");
                EndContext();
#line 43 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                  
                                    var comments = item.CustomerOrderHeader.Comments;
                                    if (comments == null || comments.Trim().Length == 0)
                                    {
                                        item.CustomerOrderHeader.Comments = "No Commments";
                                    }

                                

#line default
#line hidden
                BeginContext(2579, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2611, 143, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bbb7910eb3672e481e3502ccea177801b026e2913871", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 51 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.CustomerOrderHeader.Comments);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2754, 124, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-3 offset-1 d-flex align-content-center\">\r\n");
                EndContext();
#line 54 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                 if (item.CustomerOrderHeader.Status.Equals(SD.StatusSubmitted))
                                {

#line default
#line hidden
                BeginContext(3011, 98, true);
                WriteLiteral("                                    <div class=\"col-12\">\r\n                                        ");
                EndContext();
                BeginContext(3109, 292, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bbb7910eb3672e481e3502ccea177801b026e2916661", async() => {
                    BeginContext(3253, 139, true);
                    WriteLiteral("\r\n                                            <i class=\"fas fa-check\"></i> &nbsp; Start Preparing\r\n                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 57 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                                                                               WriteLiteral(item.CustomerOrderHeader.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3401, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3443, 290, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bbb7910eb3672e481e3502ccea177801b026e2919622", async() => {
                    BeginContext(3588, 136, true);
                    WriteLiteral("\r\n                                            <i class=\"fas fa-times\"></i> &nbsp; Cancel Order\r\n                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 60 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                                                                              WriteLiteral(item.CustomerOrderHeader.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3733, 46, true);
                WriteLiteral("\r\n                                    </div>\r\n");
                EndContext();
#line 64 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#line 67 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                     if (item.CustomerOrderHeader.Status.Equals(SD.StatusInProcess))
                                    {

#line default
#line hidden
                BeginContext(4028, 106, true);
                WriteLiteral("                                        <div class=\"col-12\">\r\n                                            ");
                EndContext();
                BeginContext(4134, 306, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bbb7910eb3672e481e3502ccea177801b026e2923386", async() => {
                    BeginContext(4279, 152, true);
                    WriteLiteral("\r\n                                                <i class=\"fas fa-flag-checkered\"></i> &nbsp; Order Ready\r\n                                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 70 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                                                                                 WriteLiteral(item.CustomerOrderHeader.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4440, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(4486, 298, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bbb7910eb3672e481e3502ccea177801b026e2926366", async() => {
                    BeginContext(4631, 144, true);
                    WriteLiteral("\r\n                                                <i class=\"fas fa-times\"></i> &nbsp; Cancel Order\r\n                                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 73 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                                                                                  WriteLiteral(item.CustomerOrderHeader.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4784, 50, true);
                WriteLiteral("\r\n                                        </div>\r\n");
                EndContext();
#line 77 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                    }

#line default
#line hidden
#line 77 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
                                     
                                }

#line default
#line hidden
                BeginContext(4908, 120, true);
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 83 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
            }

#line default
#line hidden
                BeginContext(5043, 16, true);
                WriteLiteral("        </div>\r\n");
                EndContext();
#line 85 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"
    }    else{ 
   

#line default
#line hidden
                BeginContext(5081, 145, true);
                WriteLiteral("      <div class=\"row backgroundghostWhite\" style=\"height:100px\" >\r\n     <p>\r\n\r\n        Nothing to prepare...........\r\n\r\n    </p>\r\n      </div>\r\n");
                EndContext();
#line 94 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\PrepareOrder.cshtml"

    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OnlinePharmacy.Models.ViewModels.CustomerOrderDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591