#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f0db500df881d25d612eb38a8c2322496db5b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_MyProfile), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/MyProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/MyProfile.cshtml", typeof(AspNetCore.Areas_Admin_Views_Users_MyProfile))]
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
#line 1 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\_ViewImports.cshtml"
using FindMyPet.Web;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\_ViewImports.cshtml"
using FindMyPet.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0db500df881d25d612eb38a8c2322496db5b8c", @"/Areas/Admin/Views/Users/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72a3507736061eb4800cfa095c8cb4e67dac9f7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindMyPet.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0 auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger col-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary col-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
  
    ViewData["Title"] = "MyProfile";

#line default
#line hidden
            BeginContext(75, 440, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-12 text-center"">
            <br />
            <div class=""titleDiv"">
                <h1 class=""display-3 classTitle""><strong>My Profile Page</strong></h1>
            </div>
            <br />
            <hr class=""display-3"" />

            <div class=""forms"">


                <br />
                <h1 class=""display-4""><strong>Email</strong> : ");
            EndContext();
            BeginContext(516, 11, false);
#line 20 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(527, 99, true);
            WriteLiteral("</h1>\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>FullName</strong> : ");
            EndContext();
            BeginContext(627, 14, false);
#line 23 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                             Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(641, 99, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>FeedBack</strong> : ");
            EndContext();
            BeginContext(741, 14, false);
#line 26 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                             Write(Model.FeedBack);

#line default
#line hidden
            EndContext();
            BeginContext(755, 114, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n\r\n                <img width=\"250\" class=\"card-image-top img-fluid img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 869, "\"", 891, 1);
#line 30 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 875, Model.AvatarUrl, 875, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(892, 81, true);
            WriteLiteral(" />\r\n                <br />\r\n                <br />\r\n                <br />\r\n\r\n\r\n");
            EndContext();
#line 36 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                 if (Model.DateOfBirth != null)
                {


#line default
#line hidden
            BeginContext(1043, 83, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Date of Birth</strong> : ");
            EndContext();
            BeginContext(1127, 17, false);
#line 40 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                    Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 29, true);
            WriteLiteral("\r\n                    </h2>\r\n");
            EndContext();
#line 42 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1233, 125, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Date of Birth</strong> : Not specified\r\n                    </h2>\r\n");
            EndContext();
#line 48 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                }

#line default
#line hidden
            BeginContext(1377, 28, true);
            WriteLiteral("\r\n                <br />\r\n\r\n");
            EndContext();
#line 52 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                 if (Model.PhoneNumber != null)
                {


#line default
#line hidden
            BeginContext(1475, 82, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Phone Number</strong> : ");
            EndContext();
            BeginContext(1558, 17, false);
#line 56 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1575, 29, true);
            WriteLiteral("\r\n                    </h2>\r\n");
            EndContext();
#line 58 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1664, 117, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Phone</strong> : Not specified\r\n                    </h2>\r\n");
            EndContext();
#line 64 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                }

#line default
#line hidden
            BeginContext(1800, 420, true);
            WriteLiteral(@"
                <br />

                <!--
                    Pets Owned
                    Pets Found

                    Messages
                -->


            </div>

            <div class=""left"">

                
                    <h1 class=""display-3""><strong>Messages</strong></h1>
                
                <div class=""card col-12 thumbnail"">
                    <br />

");
            EndContext();
#line 86 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                     if (ViewBag.Messages.Count < 1)
                    {

#line default
#line hidden
            BeginContext(2297, 134, true);
            WriteLiteral("                        <div>\r\n                            <h3>No comments posted for this pet.</h3>\r\n                        </div>\r\n");
            EndContext();
#line 91 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                    }
                    else
                    {

                        

#line default
#line hidden
#line 95 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                         foreach (var message in ViewBag.Messages)
                        {

#line default
#line hidden
            BeginContext(2600, 111, true);
            WriteLiteral("                            <div class=\"card col-12 commentsContainer\">\r\n\r\n                                <h2>");
            EndContext();
            BeginContext(2712, 15, false);
#line 99 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                               Write(message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2727, 159, true);
            WriteLiteral("</h2>\r\n                                <span>\r\n                                    Created by\r\n                                    <strong style=\"color: grey\">");
            EndContext();
            BeginContext(2886, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098e651be498428eb2e8f9dbd525f852", async() => {
                BeginContext(2991, 20, false);
#line 102 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                                                                                                                                   Write(message.Sender.Email);

#line default
#line hidden
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
#line 102 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                                                                                                        WriteLiteral(message.Sender.Id);

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
            BeginContext(3015, 90, true);
            WriteLiteral("</strong>\r\n                                    on\r\n                                    <i>");
            EndContext();
            BeginContext(3106, 20, false);
#line 104 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                  Write(message.CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(3126, 96, true);
            WriteLiteral("</i>\r\n                                    <br />\r\n                                    <br />\r\n\r\n");
            EndContext();
#line 108 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                     if (message.LikeDisabled == false)
                                    {

#line default
#line hidden
            BeginContext(3334, 162, true);
            WriteLiteral("                                        <strong style=\"color: darkblue\">\r\n                                            <a class=\"btn btn-sm btn-success likeButton\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3496, "\"", 3577, 4);
            WriteAttributeValue("", 3503, "/Messages/AddLike/", 3503, 18, true);
#line 111 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 3521, ViewData["CurrentId"].ToString(), 3521, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 3554, "*", 3554, 1, true);
#line 111 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 3555, message.Id.ToString(), 3555, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3578, 109, true);
            WriteLiteral(">Like</a>\r\n                                            :\r\n                                        </strong>\r\n");
            EndContext();
#line 114 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3809, 167, true);
            WriteLiteral("                                        <strong style=\"color: darkblue\">\r\n                                            <a class=\"btn btn-sm btn-danger removelikeButton\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3976, "\"", 4060, 4);
            WriteAttributeValue("", 3983, "/Messages/RemoveLike/", 3983, 21, true);
#line 119 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 4004, ViewData["CurrentId"].ToString(), 4004, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 4037, "*", 4037, 1, true);
#line 119 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 4038, message.Id.ToString(), 4038, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4061, 112, true);
            WriteLiteral(">Dislike</a>\r\n                                            :\r\n                                        </strong>\r\n");
            EndContext();
#line 122 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4212, 45, true);
            WriteLiteral("\r\n\r\n\r\n                                    <i>");
            EndContext();
            BeginContext(4258, 19, false);
#line 126 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                  Write(message.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4277, 135, true);
            WriteLiteral("</i>\r\n\r\n                                    <br />\r\n\r\n                                </span>\r\n                                <br />\r\n");
            EndContext();
#line 132 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                 if (ViewData["isAdmin"].ToString() == "True" || this.User.Identity.Name == Model.Email)
                                {


#line default
#line hidden
            BeginContext(4571, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(4607, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "103cbdf618114ab5888a666a2ce3ecac", async() => {
                BeginContext(4775, 94, true);
                WriteLiteral("\r\n                                        Delete Message\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 135 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                                                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 135 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                                                                                                                                                   WriteLiteral(message.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4873, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 138 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                }

#line default
#line hidden
            BeginContext(4910, 116, true);
            WriteLiteral("                                <br />\r\n                                <br />\r\n                            </div>\r\n");
            EndContext();
#line 142 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                        }

#line default
#line hidden
#line 142 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                         

                    }

#line default
#line hidden
            BeginContext(5078, 106, true);
            WriteLiteral("                    <br />\r\n                </div>\r\n            </div>\r\n\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(5184, 568, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3206bddd35dc46b580aa04c726226644", async() => {
                BeginContext(5276, 469, true);
                WriteLiteral(@"

                    <h2 class=""""><strong>Add Message</strong></h2>
                <div class=""form-group row"">
                    <textarea class=""form-control commentDescription"" name=""Description"" placeholder=""Enter Comment""
                              minlength=""10"" required></textarea>
                </div>

                <input type=""submit"" id=""btn-add-game"" class=""btn btn-outline-success btn-lg btn-block"" value=""Add Comment"" />
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 150 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Areas\Admin\Views\Users\MyProfile.cshtml"
                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5752, 246, true);
            WriteLiteral("\r\n\r\n            <br />\r\n            <br />\r\n\r\n\r\n            <div class=\"bottom\">\r\n\r\n                <div class=\"card-footer text-center\">\r\n                    <h1 class=\"display-3\" style=\"background: lightgreen\">Actions</h1>\r\n                    ");
            EndContext();
            BeginContext(5998, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "347b67b62d574e47bd9f655b160cd0b0", async() => {
                BeginContext(6070, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6078, 86, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindMyPet.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
