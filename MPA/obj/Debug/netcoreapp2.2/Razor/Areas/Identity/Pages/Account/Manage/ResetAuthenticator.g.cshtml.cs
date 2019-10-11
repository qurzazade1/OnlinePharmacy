#pragma checksum "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54d59c5b148950e113c0116a48be926454af0f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlinePharmacy.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ResetAuthenticator), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ResetAuthenticator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/ResetAuthenticator.cshtml", typeof(OnlinePharmacy.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ResetAuthenticator), null)]
namespace OnlinePharmacy.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\_ViewImports.cshtml"
using OnlinePharmacy.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using OnlinePharmacy.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using OnlinePharmacy.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54d59c5b148950e113c0116a48be926454af0f03", @"/Areas/Identity/Pages/Account/Manage/ResetAuthenticator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"735f7ad7a093a111c708de98f09e886929d4a931", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8c2ecc7aaa34db566dcfd15f45670ea145f444c", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ea8162824831e01c766e1c228c0ac79bc5efe7", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ResetAuthenticator : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reset-authenticator-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
  
    ViewData["Title"] = "Reset authenticator key";
    ViewData["ActivePage"] = ManageNavPages.TwoFactorAuthentication;

#line default
#line hidden
            BeginContext(168, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
 if (!String.IsNullOrEmpty(Model.StatusMessage))
{
    var statusMessageClass = Model.StatusMessage.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(323, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 331, "\"", 388, 4);
            WriteAttributeValue("", 339, "alert", 339, 5, true);
            WriteAttributeValue(" ", 344, "alert-", 345, 7, true);
#line 14 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
WriteAttributeValue("", 351, statusMessageClass, 351, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 370, "alert-dismissible", 371, 18, true);
            EndWriteAttribute();
            BeginContext(389, 158, true);
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            EndContext();
            BeginContext(548, 5, false);
#line 16 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(553, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
}

#line default
#line hidden
            BeginContext(570, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<h4>");
            EndContext();
            BeginContext(583, 17, false);
#line 23 "C:\Users\sadig\source\repos\OnlinePharmacy\MPA\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(600, 483, true);
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>If you reset your authenticator key your authenticator app will not work until you reconfigure it.</strong>
    </p>
    <p>
        This process disables 2FA until you verify your authenticator app.
        If you do not complete your authenticator app configuration you may lose access to your account.
    </p>
</div>
<div>
    ");
            EndContext();
            BeginContext(1083, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54d59c5b148950e113c0116a48be926454af0f038537", async() => {
                BeginContext(1152, 125, true);
                WriteLiteral("\r\n        <button id=\"reset-authenticator-button\" class=\"btn btn-danger\" type=\"submit\">Reset authenticator key</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1284, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResetAuthenticatorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResetAuthenticatorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResetAuthenticatorModel>)PageContext?.ViewData;
        public ResetAuthenticatorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
