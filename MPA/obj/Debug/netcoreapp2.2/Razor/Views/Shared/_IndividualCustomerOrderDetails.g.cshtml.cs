#pragma checksum "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__IndividualCustomerOrderDetails), @"mvc.1.0.view", @"/Views/Shared/_IndividualCustomerOrderDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_IndividualCustomerOrderDetails.cshtml", typeof(AspNetCore.Views_Shared__IndividualCustomerOrderDetails))]
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
#line 1 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\_ViewImports.cshtml"
using OnlinePharmacy;

#line default
#line hidden
#line 2 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\_ViewImports.cshtml"
using OnlinePharmacy.Models;

#line default
#line hidden
#line 2 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
using OnlinePharmacy.WebShopUtility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b", @"/Views/Shared/_IndividualCustomerOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0593359b1c6d5604f46655cbe3f719a219f8a30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__IndividualCustomerOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlinePharmacy.Models.ViewModels.CustomerOrderDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDelivery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CustomerOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(229, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(233, 5007, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b5563", async() => {
                BeginContext(361, 338, true);
                WriteLiteral(@"
    <div class=""container row border ml-1 backgroundghostWhiteBorder10Padding"" style=""width:100%"">

        <div class=""col-lg-4 col-12"">
            <h3 class=""d-flex justify-content-between align-content-start mb-3"">
                
                <span  style=""width:100%;height:100%;"" class=""badge badge-success "">Order ID:  ");
                EndContext();
                BeginContext(700, 28, false);
#line 13 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                                                                          Write(Model.CustomerOrderHeader.Id);

#line default
#line hidden
                EndContext();
                BeginContext(728, 70, true);
                WriteLiteral("</span>\r\n            </h3>\r\n            <ul class=\"list-group mb-3\">\r\n");
                EndContext();
#line 16 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                 foreach (var details in Model.CustomerOrderDetails)
                {

#line default
#line hidden
                BeginContext(887, 157, true);
                WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between\">\r\n                        <div>\r\n                            <h6 class=\"my-0\">");
                EndContext();
                BeginContext(1045, 12, false);
#line 20 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                        Write(details.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1057, 72, true);
                WriteLiteral("</h6>\r\n                            <small class=\"text-muted\">Quantity : ");
                EndContext();
                BeginContext(1130, 13, false);
#line 21 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                                            Write(details.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1143, 91, true);
                WriteLiteral("</small>\r\n                        </div>\r\n                        <span class=\"text-muted\">");
                EndContext();
                BeginContext(1236, 29, false);
#line 23 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                             Write(details.Price * details.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1266, 36, true);
                WriteLiteral("</span>\r\n                    </li>\r\n");
                EndContext();
#line 25 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                }

#line default
#line hidden
                BeginContext(1321, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 26 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                 if (Model.CustomerOrderHeader.DiscountCodeString != null)
                {

#line default
#line hidden
                BeginContext(1416, 230, true);
                WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between\">\r\n                        <div class=\"text-success\">\r\n                            <h6 class=\"my-0\">Promo Code</h6>\r\n                            <small>");
                EndContext();
                BeginContext(1647, 44, false);
#line 31 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                              Write(Model.CustomerOrderHeader.DiscountCodeString);

#line default
#line hidden
                EndContext();
                BeginContext(1691, 93, true);
                WriteLiteral("</small>\r\n                        </div>\r\n                        <span class=\"text-success\">");
                EndContext();
                BeginContext(1786, 83, false);
#line 33 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                               Write(Model.CustomerOrderHeader.OrderTotalOriginal - Model.CustomerOrderHeader.OrderTotal);

#line default
#line hidden
                EndContext();
                BeginContext(1870, 36, true);
                WriteLiteral("</span>\r\n                    </li>\r\n");
                EndContext();
#line 35 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                }

#line default
#line hidden
                BeginContext(1925, 198, true);
                WriteLiteral("                <li class=\"list-group-item d-flex justify-content-between bg-light\">\r\n                    <span class=\"text-info\"> Total (USD)</span>\r\n                    <strong class=\"text-info\">$");
                EndContext();
                BeginContext(2124, 36, false);
#line 38 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                          Write(Model.CustomerOrderHeader.OrderTotal);

#line default
#line hidden
                EndContext();
                BeginContext(2160, 53, true);
                WriteLiteral("</strong>\r\n                </li>\r\n            </ul>\r\n");
                EndContext();
#line 41 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
             if (Model.CustomerOrderHeader.Status.Equals(SD.StatusReady) && (User.IsInRole(SD.ManagerUser) || User.IsInRole(SD.PostmanUser)))
            {

#line default
#line hidden
                BeginContext(2371, 111, true);
                WriteLiteral("                <button type=\"submit\" class=\"btn btn-outline-success form-control\"> Confirm Delivery</button>\r\n");
                EndContext();
#line 44 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(2578, 105, true);
                WriteLiteral("                                <button type=\"submit\" disabled class=\"btn btn-outline-info form-control\">");
                EndContext();
                BeginContext(2684, 32, false);
#line 47 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                                                                                    Write(Model.CustomerOrderHeader.Status);

#line default
#line hidden
                EndContext();
                BeginContext(2716, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 48 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                            }

#line default
#line hidden
                BeginContext(2774, 90, true);
                WriteLiteral("        </div>\r\n\r\n        <div class=\"col-lg-8 col-12\" >\r\n            <br />\r\n            ");
                EndContext();
                BeginContext(2864, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b13546", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2920, 203, true);
                WriteLiteral("\r\n            <div class=\"form-group row\">\r\n                <div class=\"col-3\">\r\n                    <label>Name</label>\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    ");
                EndContext();
                BeginContext(3123, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b15620", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 59 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.PickupName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3203, 145, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                <div class=\"col-3\">\r\n                    ");
                EndContext();
                BeginContext(3348, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b17834", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 64 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.ApplicationUser.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3415, 83, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    ");
                EndContext();
                BeginContext(3498, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b19586", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 67 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.ApplicationUser.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3589, 145, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                <div class=\"col-3\">\r\n                    ");
                EndContext();
                BeginContext(3734, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b21811", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 72 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.ApplicationUser.PhoneNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3807, 83, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    ");
                EndContext();
                BeginContext(3890, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b23569", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 75 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.ApplicationUser.PhoneNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3987, 145, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                <div class=\"col-3\">\r\n                    ");
                EndContext();
                BeginContext(4132, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b25800", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 80 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.OrderTotal);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4188, 83, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    ");
                EndContext();
                BeginContext(4271, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b27541", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 83 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.OrderTotal);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4351, 145, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                <div class=\"col-3\">\r\n                    ");
                EndContext();
                BeginContext(4496, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b29755", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 88 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.OrderDate);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4551, 89, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4640, "\"", 4763, 2);
#line 91 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
WriteAttributeValue("", 4648, Model.CustomerOrderHeader.PickUpTime.ToShortDateString(), 4648, 57, false);

#line default
#line hidden
#line 91 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
WriteAttributeValue(" ", 4705, Model.CustomerOrderHeader.PickUpTime.ToShortTimeString(), 4706, 57, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4764, 178, true);
                WriteLiteral(" disabled class=\"form-control\" />\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                <div class=\"col-3\">\r\n                    ");
                EndContext();
                BeginContext(4942, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b32427", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 96 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.Comments);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4996, 83, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    ");
                EndContext();
                BeginContext(5079, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91ee24f165c6bcdebb0e75e4442f4ca43cc2da3b34166", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 99 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerOrderHeader.Comments);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5157, 76, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 7 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_IndividualCustomerOrderDetails.cshtml"
                                                                       WriteLiteral(Model.CustomerOrderHeader.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlinePharmacy.Models.ViewModels.CustomerOrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
