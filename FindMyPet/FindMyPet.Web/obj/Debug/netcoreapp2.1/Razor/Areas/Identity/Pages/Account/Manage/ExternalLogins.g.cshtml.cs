#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "562a3226badd11f49eb1282ecf3c9af261d25273"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FindMyPet.Web.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml", typeof(FindMyPet.Web.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), null)]
namespace FindMyPet.Web.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using FindMyPet.Web.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using FindMyPet.Web.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using FindMyPet.Web.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"562a3226badd11f49eb1282ecf3c9af261d25273", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9d37195f8882cd31f0759ba06b66825b7c202b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b8f4eccdf76fd4af94b21fa125f31ac5144101", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19affdb30bcb5dc66612f0a4dd14ef805d5be903", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("remove-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("link-login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
  

    Layout = "_Layout";
    ViewData["Title"] = "Manage your external logins";

#line default
#line hidden
            BeginContext(125, 25, true);
            WriteLiteral("\r\n<div class=\"top\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(151, 51, false);
#line 12 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
            EndContext();
            BeginContext(202, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(245, 76, true);
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
             foreach (var login in Model.CurrentLogins)
            {

#line default
#line hidden
            BeginContext(393, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(440, 19, false);
#line 21 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                   Write(login.LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(459, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 23 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                         if (Model.ShowRemoveButton)
                        {

#line default
#line hidden
            BeginContext(573, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(597, 547, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35f7d0661c98429b9fcc81315bd78b98", async() => {
                BeginContext(666, 69, true);
                WriteLiteral("\r\n                            <div>\r\n                                ");
                EndContext();
                BeginContext(735, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4d5327e653344ac805a42031e68efce", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 27 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(810, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(844, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9ef5e579e374c809c6e9438048d1cd4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 28 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(915, 79, true);
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 994, "\"", 1058, 7);
                WriteAttributeValue("", 1002, "Remove", 1002, 6, true);
                WriteAttributeValue(" ", 1008, "this", 1009, 5, true);
#line 29 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1013, login.LoginProvider, 1014, 20, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1034, "login", 1035, 6, true);
                WriteAttributeValue(" ", 1040, "from", 1041, 5, true);
                WriteAttributeValue(" ", 1045, "your", 1046, 5, true);
                WriteAttributeValue(" ", 1050, "account", 1051, 8, true);
                EndWriteAttribute();
                BeginContext(1059, 78, true);
                WriteLiteral(">Remove</button>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1144, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1230, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1256, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 36 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                        }

#line default
#line hidden
            BeginContext(1292, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(1357, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 42 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#line 43 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(1431, 61, true);
            WriteLiteral("    <h4>Add another service to log in.</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(1492, 510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68201d91b4a14b1ebf6863e3c46014e8", async() => {
                BeginContext(1586, 55, true);
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
                EndContext();
#line 50 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
                BeginContext(1722, 104, true);
                WriteLiteral("                    <button id=\"link-login-button\" type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1826, "\"", 1848, 1);
#line 52 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1834, provider.Name, 1834, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1849, "\"", 1904, 6);
                WriteAttributeValue("", 1857, "Log", 1857, 3, true);
                WriteAttributeValue(" ", 1860, "in", 1861, 3, true);
                WriteAttributeValue(" ", 1863, "using", 1864, 6, true);
                WriteAttributeValue(" ", 1869, "your", 1870, 5, true);
#line 52 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1874, provider.DisplayName, 1875, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1896, "account", 1897, 8, true);
                EndWriteAttribute();
                BeginContext(1905, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1907, 20, false);
#line 52 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                                                                                                                                                   Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1927, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 53 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                }

#line default
#line hidden
                BeginContext(1957, 38, true);
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2002, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
            BeginContext(2007, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel>)PageContext?.ViewData;
        public ExternalLoginsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
