#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8eb603934f3264b4882002fc1eeed75a9e7c20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_PetsPages_AllUsers), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/PetsPages/AllUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/PetsPages/AllUsers.cshtml", typeof(AspNetCore.Areas_Admin_Pages_PetsPages_AllUsers), null)]
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
#line 1 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using FindMyPet.Web;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using FindMyPet.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using FindMyPet.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8eb603934f3264b4882002fc1eeed75a9e7c20", @"/Areas/Admin/Pages/PetsPages/AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7a03b32b8c0e19a14a56f8a2224f1f73546b43", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_PetsPages_AllUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary tableDataRotate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success tableDataRotate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnlockUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger tableDataRotate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LockUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(78, 717, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-12 text-center"">
            <br /><h1 class=""display-3 left"">All User Profiles</h1><br /><table class=""table right"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Email</th>
                        <th class=""thCol"" scope=""col"">Full Name</th>
                        <th class=""thCol"" scope=""col"">FeedBack</th>
                        <th class=""thCol"" scope=""col"">Avatar</th>
                        <th class=""thCol"" scope=""col"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 21 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                     for (var i = 0; i < Model.AllUsers.Count; i++)
                    {
                        var user = Model.AllUsers[i]; var count = i + 1;

#line default
#line hidden
            BeginContext(961, 74, true);
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
            EndContext();
            BeginContext(1036, 5, false);
#line 25 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 51, true);
            WriteLiteral("</th>\r\n                            <th scope=\"row\">");
            EndContext();
            BeginContext(1093, 10, false);
#line 26 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                       Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 39, true);
            WriteLiteral("</th>\r\n                            <td>");
            EndContext();
            BeginContext(1143, 13, false);
#line 27 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                           Write(user.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1196, 13, false);
#line 28 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                           Write(user.FeedBack);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 30 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                             if (@user.AvatarUrl != null && user.AvatarUrl != "")
                            {

#line default
#line hidden
            BeginContext(1332, 60, true);
            WriteLiteral("                                <td><img class=\"tableAvatar\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1392, "\"", 1413, 1);
#line 32 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
WriteAttributeValue("", 1398, user.AvatarUrl, 1398, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1414, 26, true);
            WriteLiteral(" alt=\"No Avatar\" /></td>\r\n");
            EndContext();
#line 33 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                            }
                            else {

#line default
#line hidden
            BeginContext(1507, 52, true);
            WriteLiteral("                                <td>No Avatar</td>\r\n");
            EndContext();
#line 36 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                            }

#line default
#line hidden
            BeginContext(1590, 120, true);
            WriteLiteral("                            \r\n                            <td class=\"tableDataRotate\">\r\n                                ");
            EndContext();
            BeginContext(1710, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ff46f3543d4b0c941761bb3fb11351", async() => {
                BeginContext(1821, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                                                                                                         WriteLiteral(user.Id);

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
            BeginContext(1832, 6, true);
            WriteLiteral(" |\r\n\r\n");
            EndContext();
#line 41 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                 if (user.LockoutEnd != null)
                                {

                                    if (user.LockoutEnd > DateTime.Now)
                                    {

#line default
#line hidden
            BeginContext(2050, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2090, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10af10746a9e4067b9b8dd9452304738", async() => {
                BeginContext(2204, 9, true);
                WriteLiteral("Free User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                                                                                                                    WriteLiteral(user.Id);

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
            BeginContext(2217, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2339, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2379, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d77b88c8d8144e9da70a77427323636c", async() => {
                BeginContext(2490, 9, true);
                WriteLiteral("Lock User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                                                                                                                 WriteLiteral(user.Id);

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
            BeginContext(2503, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                    }
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2652, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2688, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34979f89ea1845f09e505e70ce9e0701", async() => {
                BeginContext(2799, 9, true);
                WriteLiteral("Lock User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                                                                                                             WriteLiteral(user.Id);

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
            BeginContext(2812, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                                }

#line default
#line hidden
            BeginContext(2849, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Pages\PetsPages\AllUsers.cshtml"
                    }

#line default
#line hidden
            BeginContext(2940, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindMyPet.Web.Areas.Admin.Pages.PetsPages.AllUsersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FindMyPet.Web.Areas.Admin.Pages.PetsPages.AllUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FindMyPet.Web.Areas.Admin.Pages.PetsPages.AllUsersModel>)PageContext?.ViewData;
        public FindMyPet.Web.Areas.Admin.Pages.PetsPages.AllUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
