#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19978de1ce3ac5ca12227557ab45fb9aaeac36a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Profile), @"mvc.1.0.view", @"/Views/Users/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Profile.cshtml", typeof(AspNetCore.Views_Users_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19978de1ce3ac5ca12227557ab45fb9aaeac36a9", @"/Views/Users/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72a3507736061eb4800cfa095c8cb4e67dac9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindMyPet.Models.User>
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
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(73, 436, true);
            WriteLiteral(@"


<div class=""container"">
    <div class=""row"">
        <div class=""col-12 text-center"">
            <br />
            <div class=""titleDiv"">
                <h1 class=""classTitle""><strong>User Profile Page</strong></h1>
            </div>
            <br />
            <hr class=""display-3"" />

            <div class=""forms"">


                <br />
                <h1 class=""display-4""><strong>Email</strong> : ");
            EndContext();
            BeginContext(510, 11, false);
#line 22 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(521, 99, true);
            WriteLiteral("</h1>\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>FullName</strong> : ");
            EndContext();
            BeginContext(621, 14, false);
#line 25 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                             Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(635, 99, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>FeedBack</strong> : ");
            EndContext();
            BeginContext(735, 14, false);
#line 28 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                             Write(Model.FeedBack);

#line default
#line hidden
            EndContext();
            BeginContext(749, 114, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n\r\n                <img width=\"250\" class=\"card-image-top img-fluid img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 863, "\"", 885, 1);
#line 32 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
WriteAttributeValue("", 869, Model.AvatarUrl, 869, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(886, 81, true);
            WriteLiteral(" />\r\n                <br />\r\n                <br />\r\n                <br />\r\n\r\n\r\n");
            EndContext();
#line 38 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                 if (Model.DateOfBirth != null)
                {


#line default
#line hidden
            BeginContext(1037, 83, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Date of Birth</strong> : ");
            EndContext();
            BeginContext(1121, 17, false);
#line 42 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                    Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 29, true);
            WriteLiteral("\r\n                    </h2>\r\n");
            EndContext();
#line 44 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1227, 125, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Date of Birth</strong> : Not specified\r\n                    </h2>\r\n");
            EndContext();
#line 50 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(1371, 28, true);
            WriteLiteral("\r\n                <br />\r\n\r\n");
            EndContext();
#line 54 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                 if (Model.PhoneNumber != null)
                {


#line default
#line hidden
            BeginContext(1469, 82, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Phone Number</strong> : ");
            EndContext();
            BeginContext(1552, 17, false);
#line 58 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 29, true);
            WriteLiteral("\r\n                    </h2>\r\n");
            EndContext();
#line 60 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1658, 117, true);
            WriteLiteral("                    <h2>\r\n                        <strong>Phone</strong> : Not specified\r\n                    </h2>\r\n");
            EndContext();
#line 66 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(1794, 388, true);
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
#line 88 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                     if (ViewBag.Messages.Count < 1)
                    {


#line default
#line hidden
            BeginContext(2261, 134, true);
            WriteLiteral("                        <div>\r\n                            <h3>No comments posted for this pet.</h3>\r\n                        </div>\r\n");
            EndContext();
#line 94 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                    }
                    else
                    {

                        

#line default
#line hidden
#line 98 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                         foreach (var message in ViewBag.Messages)
                        {

#line default
#line hidden
            BeginContext(2564, 111, true);
            WriteLiteral("                            <div class=\"card col-12 commentsContainer\">\r\n\r\n                                <h2>");
            EndContext();
            BeginContext(2676, 15, false);
#line 102 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                               Write(message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2691, 159, true);
            WriteLiteral("</h2>\r\n                                <span>\r\n                                    Created by\r\n                                    <strong style=\"color: grey\">");
            EndContext();
            BeginContext(2850, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5358230c0269440fa4e19f61e400b1c5", async() => {
                BeginContext(2955, 20, false);
#line 105 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
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
#line 105 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
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
            BeginContext(2979, 90, true);
            WriteLiteral("</strong>\r\n                                    on\r\n                                    <i>");
            EndContext();
            BeginContext(3070, 20, false);
#line 107 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                  Write(message.CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(3090, 96, true);
            WriteLiteral("</i>\r\n                                    <br />\r\n                                    <br />\r\n\r\n");
            EndContext();
#line 111 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                     if (message.LikeDisabled == false)
                                    {


#line default
#line hidden
            BeginContext(3300, 162, true);
            WriteLiteral("                                        <strong style=\"color: darkblue\">\r\n                                            <a class=\"btn btn-sm btn-success likeButton\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3462, "\"", 3543, 4);
            WriteAttributeValue("", 3469, "/Messages/AddLike/", 3469, 18, true);
#line 115 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
WriteAttributeValue("", 3487, ViewData["CurrentId"].ToString(), 3487, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 3520, "*", 3520, 1, true);
#line 115 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
WriteAttributeValue("", 3521, message.Id.ToString(), 3521, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3544, 109, true);
            WriteLiteral(">Like</a>\r\n                                            :\r\n                                        </strong>\r\n");
            EndContext();
#line 118 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"

                                    }
                                    else
                                    {


#line default
#line hidden
            BeginContext(3777, 167, true);
            WriteLiteral("                                        <strong style=\"color: darkblue\">\r\n                                            <a class=\"btn btn-sm btn-danger removelikeButton\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3944, "\"", 4028, 4);
            WriteAttributeValue("", 3951, "/Messages/RemoveLike/", 3951, 21, true);
#line 124 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
WriteAttributeValue("", 3972, ViewData["CurrentId"].ToString(), 3972, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 4005, "*", 4005, 1, true);
#line 124 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
WriteAttributeValue("", 4006, message.Id.ToString(), 4006, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4029, 112, true);
            WriteLiteral(">Dislike</a>\r\n                                            :\r\n                                        </strong>\r\n");
            EndContext();
#line 127 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4180, 45, true);
            WriteLiteral("\r\n\r\n\r\n                                    <i>");
            EndContext();
            BeginContext(4226, 19, false);
#line 131 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                  Write(message.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4245, 135, true);
            WriteLiteral("</i>\r\n\r\n                                    <br />\r\n\r\n                                </span>\r\n                                <br />\r\n");
            EndContext();
#line 137 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                 if (ViewData["isAdmin"].ToString() == "True" || this.User.Identity.Name == Model.Email)
                                {


#line default
#line hidden
            BeginContext(4539, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(4575, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddbd806c9e5a4aafae3924cbd1825e43", async() => {
                BeginContext(4743, 94, true);
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
#line 140 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 140 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
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
            BeginContext(4841, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 143 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                }

#line default
#line hidden
            BeginContext(4878, 116, true);
            WriteLiteral("                                <br />\r\n                                <br />\r\n                            </div>\r\n");
            EndContext();
#line 147 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                        }

#line default
#line hidden
#line 147 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                         

                    }

#line default
#line hidden
            BeginContext(5046, 106, true);
            WriteLiteral("                    <br />\r\n                </div>\r\n            </div>\r\n\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(5152, 568, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbbc3487b6a14ffaa22ca04f20c4ea6e", async() => {
                BeginContext(5244, 469, true);
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
#line 155 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
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
            BeginContext(5720, 246, true);
            WriteLiteral("\r\n\r\n            <br />\r\n            <br />\r\n\r\n\r\n            <div class=\"bottom\">\r\n\r\n                <div class=\"card-footer text-center\">\r\n                    <h1 class=\"display-3\" style=\"background: lightgreen\">Actions</h1>\r\n                    ");
            EndContext();
            BeginContext(5966, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91bed44b2e564c9a8870d8c40575c7ea", async() => {
                BeginContext(6038, 4, true);
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
            BeginContext(6046, 86, true);
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
