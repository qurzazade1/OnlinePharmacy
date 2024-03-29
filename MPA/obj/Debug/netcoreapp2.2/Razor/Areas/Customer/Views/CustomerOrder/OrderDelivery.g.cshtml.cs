#pragma checksum "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c504d2a07fa66a3fadbc0e437b55b0e5fe5a062d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_CustomerOrder_OrderDelivery), @"mvc.1.0.view", @"/Areas/Customer/Views/CustomerOrder/OrderDelivery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/CustomerOrder/OrderDelivery.cshtml", typeof(AspNetCore.Areas_Customer_Views_CustomerOrder_OrderDelivery))]
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
#line 2 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
using OnlinePharmacy.WebShopUtility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c504d2a07fa66a3fadbc0e437b55b0e5fe5a062d", @"/Areas/Customer/Views/CustomerOrder/OrderDelivery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c61a50e1935934fcd9d4f43bac260023ad25885", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_CustomerOrder_OrderDelivery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlinePharmacy.Models.ViewModels.CustomerOrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GetCustomerOrderDetails.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(194, 787, true);
            WriteLiteral(@"

<div class=""modal fade"" id=""myOrderDetailsModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-centered modal-dialog"" role=""document"">
        <div class=""modal-content"">

                <div class=""modal-header bg-success text-light justify-content-lg-start"">
                    <div class=""col-8""><h5 class=""modal-title"">Order Details</h5></div>
                    <div class=""col-2 offset-2"">
                        <button type=""button"" class=""btn btn-success "" style=""width:100%"" data-dismiss=""modal"">Close</button>
                    </div>

                </div>


            <div class=""modal-body justify-content-md-start"" id=""myOrderDetailsModalContent"">

            </div>

        </div>
    </div>
</div>



");
            EndContext();
            BeginContext(981, 4273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c504d2a07fa66a3fadbc0e437b55b0e5fe5a062d5684", async() => {
                BeginContext(1000, 571, true);
                WriteLiteral(@"
    <br />




    

        <div class=""row"" style=""padding-top:12px"">

            <div class=""col-12"">

            <h3 class=""text-success""> Orders Ready for Delivery  </h3>
       

       
                </div
>
        </div>



    

    <div class=""border backgroundghostWhite col-12"">


        <div class=""container  col-4 offset-8"" style=""height:55px;"">

            <div class=""row container "">
                <div class=""col-8  "">
                    <div class=""row"" style=""padding-top:10px"">


                        ");
                EndContext();
                BeginContext(1572, 109, false);
#line 66 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                   Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control", @placeholder = "Name..." } }));

#line default
#line hidden
                EndContext();
                BeginContext(1681, 506, true);
                WriteLiteral(@"


                    </div>
                </div>
                <div class=""col-3 offset-1"">
                    <div class=""row"" style=""padding-top:10px;"">
                        <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-outline-success form-control"">
                            <i class=""fas fa-search""></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>

        <br />
        <div>
");
                EndContext();
#line 83 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
             if (Model.Orders.Count() <= 0)
            {

#line default
#line hidden
                BeginContext(2245, 32, true);
                WriteLiteral("<p>Nothing for delivery...</p>\r\n");
                EndContext();
#line 85 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
            }
            else
            {


#line default
#line hidden
                BeginContext(2327, 153, true);
                WriteLiteral("                <table class=\"table  border\">\r\n                    <tr class=\"table-success\">\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(2481, 60, false);
#line 92 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].CustomerOrderHeader.Id));

#line default
#line hidden
                EndContext();
                BeginContext(2541, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(2633, 68, false);
#line 95 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].CustomerOrderHeader.PickupName));

#line default
#line hidden
                EndContext();
                BeginContext(2701, 93, true);
                WriteLiteral("\r\n                        </th>\r\n\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(2795, 68, false);
#line 99 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].CustomerOrderHeader.PickUpTime));

#line default
#line hidden
                EndContext();
                BeginContext(2863, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(2955, 79, false);
#line 102 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].CustomerOrderHeader.ApplicationUser.Email));

#line default
#line hidden
                EndContext();
                BeginContext(3034, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3126, 71, false);
#line 105 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].CustomerOrderHeader.PickUpAddress));

#line default
#line hidden
                EndContext();
                BeginContext(3197, 197, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            Total Items\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n");
                EndContext();
#line 112 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                     foreach (var item in Model.Orders)
                    {

#line default
#line hidden
                BeginContext(3474, 96, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(3571, 49, false);
#line 116 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                           Write(Html.DisplayFor(m => item.CustomerOrderHeader.Id));

#line default
#line hidden
                EndContext();
                BeginContext(3620, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(3724, 57, false);
#line 119 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                           Write(Html.DisplayFor(m => item.CustomerOrderHeader.PickupName));

#line default
#line hidden
                EndContext();
                BeginContext(3781, 105, true);
                WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(3887, 57, false);
#line 123 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                           Write(Html.DisplayFor(m => item.CustomerOrderHeader.PickUpTime));

#line default
#line hidden
                EndContext();
                BeginContext(3944, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4048, 68, false);
#line 126 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                           Write(Html.DisplayFor(m => item.CustomerOrderHeader.ApplicationUser.Email));

#line default
#line hidden
                EndContext();
                BeginContext(4116, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4220, 60, false);
#line 129 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                           Write(Html.DisplayFor(m => item.CustomerOrderHeader.PickUpAddress));

#line default
#line hidden
                EndContext();
                BeginContext(4280, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4384, 53, false);
#line 132 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                           Write(Html.DisplayFor(m => item.CustomerOrderDetails.Count));

#line default
#line hidden
                EndContext();
                BeginContext(4437, 179, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-outline-success anchorDetail\" data-id=\"");
                EndContext();
                BeginContext(4617, 27, false);
#line 135 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                                                                                                       Write(item.CustomerOrderHeader.Id);

#line default
#line hidden
                EndContext();
                BeginContext(4644, 199, true);
                WriteLiteral("\" data-toggle=\"modal\">\r\n                                    <i class=\"fas fa-info\"> </i>\r\n                                </button>\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 140 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
                    }

#line default
#line hidden
                BeginContext(4866, 26, true);
                WriteLiteral("                </table>\r\n");
                EndContext();
                BeginContext(4894, 20, true);
                WriteLiteral("                <div");
                EndContext();
                BeginWriteAttribute("page-model", " page-model=\"", 4914, "\"", 4944, 1);
#line 143 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
WriteAttributeValue("", 4927, Model.PagingInfo, 4927, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4945, 229, true);
                WriteLiteral(" page-classes-enabled=\"true\" page-class=\"btn border\"\r\n                     page-class-normal=\"btn btn-light\" page-class-selected=\"btn btn-info active\"\r\n                     class=\"btn-group float-right\">\r\n                </div>\r\n");
                EndContext();
                BeginContext(5176, 24, true);
                WriteLiteral("                <br />\r\n");
                EndContext();
#line 149 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Customer\Views\CustomerOrder\OrderDelivery.cshtml"
            }

#line default
#line hidden
                BeginContext(5215, 32, true);
                WriteLiteral("        </div>\r\n\r\n\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(5254, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5287, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5293, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c504d2a07fa66a3fadbc0e437b55b0e5fe5a062d18835", async() => {
                    BeginContext(5339, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5356, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlinePharmacy.Models.ViewModels.CustomerOrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
