#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79a74d29f85dc9bb6c28fd774b0e5ace8ea33ce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_MyProfile), @"mvc.1.0.view", @"/Views/Users/MyProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/MyProfile.cshtml", typeof(AspNetCore.Views_Users_MyProfile))]
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
#line 1 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\_ViewImports.cshtml"
using FindMyPet.Web;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\_ViewImports.cshtml"
using FindMyPet.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a74d29f85dc9bb6c28fd774b0e5ace8ea33ce6", @"/Views/Users/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72a3507736061eb4800cfa095c8cb4e67dac9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindMyPet.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0 auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger col-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary col-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
  
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
#line 20 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                                          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(527, 99, true);
            WriteLiteral("</h1>\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>FullName</strong> : ");
            EndContext();
            BeginContext(627, 14, false);
#line 23 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                                             Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(641, 99, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>FeedBack</strong> : ");
            EndContext();
            BeginContext(741, 14, false);
#line 26 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                                             Write(Model.FeedBack);

#line default
#line hidden
            EndContext();
            BeginContext(755, 35, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n\r\n");
            EndContext();
#line 30 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                 if(Model.AvatarUrl != null) { 


#line default
#line hidden
            BeginContext(841, 79, true);
            WriteLiteral("                <img width=\"250\" class=\"card-image-top img-fluid img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 920, "\"", 942, 1);
#line 32 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 926, Model.AvatarUrl, 926, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(943, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 33 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                }

#line default
#line hidden
            BeginContext(967, 76, true);
            WriteLiteral("                <br />\r\n                <br />\r\n                <br />\r\n\r\n\r\n");
            EndContext();
#line 39 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                 if (Model.DateOfBirth != null)
                {


#line default
#line hidden
            BeginContext(1113, 83, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Date of Birth</strong> : ");
            EndContext();
            BeginContext(1197, 17, false);
#line 43 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                                    Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1214, 29, true);
            WriteLiteral("\r\n                    </h2>\r\n");
            EndContext();
#line 45 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1303, 125, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Date of Birth</strong> : Not specified\r\n                    </h2>\r\n");
            EndContext();
#line 51 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                }

#line default
#line hidden
            BeginContext(1447, 28, true);
            WriteLiteral("\r\n                <br />\r\n\r\n");
            EndContext();
#line 55 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                 if (Model.PhoneNumber != null)
                {


#line default
#line hidden
            BeginContext(1545, 82, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Phone Number</strong> : ");
            EndContext();
            BeginContext(1628, 17, false);
#line 59 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1645, 29, true);
            WriteLiteral("\r\n                    </h2>\r\n");
            EndContext();
#line 61 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1734, 117, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Phone</strong> : Not specified\r\n                    </h2>\r\n");
            EndContext();
#line 67 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                }

#line default
#line hidden
            BeginContext(1870, 420, true);
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
#line 89 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                     if (ViewBag.Messages.Count < 1)
                    {

#line default
#line hidden
            BeginContext(2367, 134, true);
            WriteLiteral("                        <div>\r\n                            <h3>No comments posted for this pet.</h3>\r\n                        </div>\r\n");
            EndContext();
#line 94 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                    }
                    else
                    {

                        

#line default
#line hidden
#line 98 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                         foreach (var message in ViewBag.Messages)
                        {

#line default
#line hidden
            BeginContext(2670, 111, true);
            WriteLiteral("                            <div class=\"card col-12 commentsContainer\">\r\n\r\n                                <h2>");
            EndContext();
            BeginContext(2782, 15, false);
#line 102 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                               Write(message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2797, 159, true);
            WriteLiteral("</h2>\r\n                                <span>\r\n                                    Created by\r\n                                    <strong style=\"color: grey\">");
            EndContext();
            BeginContext(2956, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dc2b248b12647f6a3977203543efee3", async() => {
                BeginContext(3061, 20, false);
#line 105 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
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
#line 105 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
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
            BeginContext(3085, 90, true);
            WriteLiteral("</strong>\r\n                                    on\r\n                                    <i>");
            EndContext();
            BeginContext(3176, 20, false);
#line 107 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                  Write(message.CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(3196, 96, true);
            WriteLiteral("</i>\r\n                                    <br />\r\n                                    <br />\r\n\r\n");
            EndContext();
#line 111 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                     if (message.LikeDisabled == false)
                                    {

#line default
#line hidden
            BeginContext(3404, 162, true);
            WriteLiteral("                                        <strong style=\"color: darkblue\">\r\n                                            <a class=\"btn btn-sm btn-success likeButton\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3566, "\"", 3647, 4);
            WriteAttributeValue("", 3573, "/Messages/AddLike/", 3573, 18, true);
#line 114 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 3591, ViewData["CurrentId"].ToString(), 3591, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 3624, "*", 3624, 1, true);
#line 114 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 3625, message.Id.ToString(), 3625, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3648, 109, true);
            WriteLiteral(">Like</a>\r\n                                            :\r\n                                        </strong>\r\n");
            EndContext();
#line 117 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3879, 167, true);
            WriteLiteral("                                        <strong style=\"color: darkblue\">\r\n                                            <a class=\"btn btn-sm btn-danger removelikeButton\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4046, "\"", 4130, 4);
            WriteAttributeValue("", 4053, "/Messages/RemoveLike/", 4053, 21, true);
#line 122 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 4074, ViewData["CurrentId"].ToString(), 4074, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 4107, "*", 4107, 1, true);
#line 122 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
WriteAttributeValue("", 4108, message.Id.ToString(), 4108, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4131, 112, true);
            WriteLiteral(">Dislike</a>\r\n                                            :\r\n                                        </strong>\r\n");
            EndContext();
#line 125 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4282, 45, true);
            WriteLiteral("\r\n\r\n\r\n                                    <i>");
            EndContext();
            BeginContext(4328, 19, false);
#line 129 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                  Write(message.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4347, 135, true);
            WriteLiteral("</i>\r\n\r\n                                    <br />\r\n\r\n                                </span>\r\n                                <br />\r\n");
            EndContext();
#line 135 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                 if (ViewData["isAdmin"].ToString() == "True" || this.User.Identity.Name == Model.Email)
                                {


#line default
#line hidden
            BeginContext(4641, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(4677, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49102c02290d48268ca076b5f818b9b0", async() => {
                BeginContext(4845, 94, true);
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
#line 138 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                                                                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 138 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
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
            BeginContext(4943, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 141 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                                }

#line default
#line hidden
            BeginContext(4980, 116, true);
            WriteLiteral("                                <br />\r\n                                <br />\r\n                            </div>\r\n");
            EndContext();
#line 145 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                        }

#line default
#line hidden
#line 145 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\MyProfile.cshtml"
                         

                    }

#line default
#line hidden
            BeginContext(5148, 316, true);
            WriteLiteral(@"                    <br />
                </div>
            </div>

            <br />
            <br />


            <div class=""bottom"">

                <div class=""card-footer text-center"">
                    <h1 class=""display-3"" style=""background: lightgreen"">Actions</h1>
                    ");
            EndContext();
            BeginContext(5464, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00fbca68015b4e2c8e2d820d516be02a", async() => {
                BeginContext(5536, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5544, 86, true);
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
