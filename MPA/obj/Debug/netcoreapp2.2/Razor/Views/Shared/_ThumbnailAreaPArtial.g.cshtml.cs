#pragma checksum "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63c519fc4a1a627e93f2fa14f21f5d489e3effa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbnailAreaPArtial), @"mvc.1.0.view", @"/Views/Shared/_ThumbnailAreaPArtial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ThumbnailAreaPArtial.cshtml", typeof(AspNetCore.Views_Shared__ThumbnailAreaPArtial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63c519fc4a1a627e93f2fa14f21f5d489e3effa", @"/Views/Shared/_ThumbnailAreaPArtial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0593359b1c6d5604f46655cbe3f719a219f8a30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbnailAreaPArtial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medicine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(150, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
 if (Model.Count() >= 1)
    
{

#line default
#line hidden
            BeginContext(189, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 197, "\"", 303, 4);
            WriteAttributeValue("", 205, "col-12", 205, 6, true);
            WriteAttributeValue(" ", 211, "post", 212, 5, true);
#line 9 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
WriteAttributeValue("  ", 216, Model.FirstOrDefault().MedicineType.Name.Replace(" ",string.Empty), 218, 67, false);

#line default
#line hidden
            WriteAttributeValue(" ", 285, "medicine-pharmacy", 286, 18, true);
            EndWriteAttribute();
            BeginContext(304, 199, true);
            WriteLiteral(">\r\n        <div class=\"row border\" style=\"background-color:seagreen;margin-left:16px;height:44px;padding-top:5px;\">\r\n            <div class=\"col-8 offset-4\">\r\n                <h4 class=\"text-white\"> ");
            EndContext();
            BeginContext(504, 50, false);
#line 12 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                   Write(Model.FirstOrDefault().MedicineType.Name.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(554, 45, true);
            WriteLiteral(" </h4>\r\n       </div>\r\n            </div>\r\n\r\n");
            EndContext();
#line 16 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(647, 327, true);
            WriteLiteral(@"            <div class=""   border backgroundghostWhite "" style="" margin-left:30px; border-radius:1px;  margin-bottom:2px; margin-top:2px; padding:5px"">
                <div class=""row"" style="""">
                   
                    <div class=""col-md-3 col-sm-12"" style=""padding-left:10px;"">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 974, "\"", 991, 1);
#line 22 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
WriteAttributeValue("", 980, item.Image, 980, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(992, 376, true);
            WriteLiteral(@"  style=""border-radius:6px;border:1px solid #bbb9b9; height:170px;width:170px;"" />
                    </div>

                    <div class=""col-md-9 col-sm-12"" style=""padding-left:25px;"">
                        <div class=""row pr-3"">
                            <div class=""col-8"">
                                <label class=""text-primary"" style=""font-size:21px;"">");
            EndContext();
            BeginContext(1369, 9, false);
#line 28 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1378, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 29 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                 if (item.Country == "1")
                                {

#line default
#line hidden
            BeginContext(1482, 151, true);
            WriteLiteral("                                    <img style=\"position:relative;height:25px; width:25px;\" srcset=\"/images/AzerbaijanFlag.png\" title=\"Azerbaijan\" />\r\n");
            EndContext();
#line 32 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                }

#line default
#line hidden
            BeginContext(1668, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 33 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                 if (item.Country == "2")
                                {

#line default
#line hidden
            BeginContext(1762, 145, true);
            WriteLiteral("                                    <img style=\"position:relative;height:25px; width:25px;\" srcset=\"/images/HungaryFlag.jpg\" title=\"Hungary\" />\r\n");
            EndContext();
#line 36 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                }

#line default
#line hidden
            BeginContext(1942, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 37 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                 if (item.Country == "3")
                                {

#line default
#line hidden
            BeginContext(2036, 148, true);
            WriteLiteral("                                    <img style=\"position:relative;height:25px; width:25px;\" srcset=\"/images/IsraelFlagEmoji.png\" title=\"Israel\" />\r\n");
            EndContext();
#line 40 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                }

#line default
#line hidden
            BeginContext(2219, 137, true);
            WriteLiteral("                            </div>\r\n                            <div class=\"col-md-2  text-right\">\r\n                                <h4>$");
            EndContext();
            BeginContext(2357, 10, false);
#line 43 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2367, 136, true);
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <div class=\"col-2  text-right\">\r\n                                ");
            EndContext();
            BeginContext(2503, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d63c519fc4a1a627e93f2fa14f21f5d489e3effa10373", async() => {
                BeginContext(2596, 30, true);
                WriteLiteral("  <i class=\"fas fa-info\"> </i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2630, 186, true);
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"row col-12 text-justify d-none d-md-block\">\r\n                            <p>");
            EndContext();
            BeginContext(2817, 26, false);
#line 52 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                          Write(Html.Raw(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2843, 141, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    \r\n                    </div>\r\n                    </div>\r\n                </div> \r\n");
            EndContext();
#line 58 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
        }

#line default
#line hidden
            BeginContext(2995, 45, true);
            WriteLiteral("        <div class=\"p-4\"></div>\r\n    </div>\r\n");
            EndContext();
#line 61 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Views\Shared\_ThumbnailAreaPArtial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medicine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
