#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ab3da6b0cba072d19b7f8a37694de03f9d71e7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ab3da6b0cba072d19b7f8a37694de03f9d71e7", @"/Views/Users/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72a3507736061eb4800cfa095c8cb4e67dac9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindMyPet.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-image-top img-fluid img-thumbnail forms"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blank-avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary col-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scrolling-animations-functions.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
  
    var context = new FindMyPet.Data.FindMyPetDbContext();

    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(135, 610, true);
            WriteLiteral(@"


<div class=""container"">
    <div class=""row"">
        <div class=""col-12 text-center"">
            <br />
            <div class=""revealOnScroll"" data-animation=""bounceInDown"">
                <h1 class=""display-3""><strong>User Profile Page</strong></h1>
            </div>
            <br />
            <hr class=""display-3"" />

            <div>

                <br />
                <h1 class=""display-4""><strong class=""revealOnScroll"" data-animation=""right"">Email</strong> <span class=""revealOnScroll"" data-animation=""forms""> : </span> <i class=""revealOnScroll"" data-animation=""left"">");
            EndContext();
            BeginContext(746, 11, false);
#line 23 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                                                                                                                                     Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(757, 259, true);
            WriteLiteral(@"</i></h1>
                <br />

                <h2 class=""display-5""><strong class=""revealOnScroll"" data-animation=""right2"">FullName</strong> <span class=""revealOnScroll"" data-animation=""forms""> : </span><i class=""revealOnScroll"" data-animation=""left2"">");
            EndContext();
            BeginContext(1017, 14, false);
#line 26 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                                                                                                                                         Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 260, true);
            WriteLiteral(@"</i></h2>
                <br />

                <h2 class=""display-5""><strong class=""revealOnScroll"" data-animation=""right3"">FeedBack</strong> <span class=""revealOnScroll"" data-animation=""forms""> : </span> <i class=""revealOnScroll"" data-animation=""left3"">");
            EndContext();
            BeginContext(1292, 14, false);
#line 29 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                                                                                                                                          Write(Model.FeedBack);

#line default
#line hidden
            EndContext();
            BeginContext(1306, 39, true);
            WriteLiteral("</i></h2>\r\n                <br />\r\n\r\n\r\n");
            EndContext();
#line 33 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                 if (Model.AvatarUrl != null)
                {

#line default
#line hidden
            BeginContext(1411, 89, true);
            WriteLiteral("                    <img width=\"250\" class=\"card-image-top img-fluid img-thumbnail forms\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1500, "\"", 1522, 1);
#line 35 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
WriteAttributeValue("", 1506, Model.AvatarUrl, 1506, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1523, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 36 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1588, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1608, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1eb45f14d25472f97681de5ba7d1e9c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1712, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(1733, 52, true);
            WriteLiteral("                <br />\r\n                <br />\r\n\r\n\r\n");
            EndContext();
#line 45 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                 if (Model.DateOfBirth != null)
                {

#line default
#line hidden
            BeginContext(1853, 238, true);
            WriteLiteral("                    <h2>\r\n                        <strong class=\"revealOnScroll\" data-animation=\"left\">Date of Birth</strong> <span class=\"revealOnScroll\" data-animation=\"forms\"> : </span> <i class=\"revealOnScroll\" data-animation=\"right\">");
            EndContext();
            BeginContext(2092, 17, false);
#line 48 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                                                                                                                               Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(2109, 33, true);
            WriteLiteral("</i>\r\n                    </h2>\r\n");
            EndContext();
#line 50 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2202, 284, true);
            WriteLiteral(@"                    <h2>
                        <strong class=""revealOnScroll"" data-animation=""left"">Date of Birth</strong> <span class=""revealOnScroll"" data-animation=""forms""> : </span> <i class=""revealOnScroll"" data-animation=""right"">Not specified</i>
                    </h2>
");
            EndContext();
#line 56 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(2505, 30, true);
            WriteLiteral("\r\n\r\n                <br />\r\n\r\n");
            EndContext();
#line 61 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                 if (Model.PhoneNumber != null)
                {


#line default
#line hidden
            BeginContext(2605, 239, true);
            WriteLiteral("                    <h2>\r\n                        <strong class=\"revealOnScroll\" data-animation=\"left2\">Phone Number</strong> <span class=\"revealOnScroll\" data-animation=\"forms\"> : </span> <i class=\"revealOnScroll\" data-animation=\"right2\">");
            EndContext();
            BeginContext(2845, 17, false);
#line 65 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                                                                                                                                Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2862, 33, true);
            WriteLiteral("</i>\r\n                    </h2>\r\n");
            EndContext();
#line 67 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2955, 285, true);
            WriteLiteral(@"                    <h2>
                        <strong class=""revealOnScroll"" data-animation=""left2"">Phone Number</strong> <span class=""revealOnScroll"" data-animation=""forms""> : </span> <i class=""revealOnScroll"" data-animation=""right2"">Not specified</i>
                    </h2>
");
            EndContext();
#line 73 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(3259, 293, true);
            WriteLiteral(@"

                <br />

            </div>

            <div class=""revealOnScroll"" data-animation=""left"">


                <h1 class=""display-3""><strong>Messages</strong></h1>

                <div class=""card col-12 thumbnail commentsContainer"">
                    <br />

");
            EndContext();
#line 88 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                     if (ViewBag.Messages.Count < 1)
                    {


#line default
#line hidden
            BeginContext(3631, 161, true);
            WriteLiteral("                        <div class=\"noCommentsPresent\">\r\n                            <h3>No messages posted for this user.</h3>\r\n                        </div>\r\n");
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
            BeginContext(3961, 128, true);
            WriteLiteral("                            <div>\r\n                                <h2 class=\"contentDiv\">\r\n                                    ");
            EndContext();
            BeginContext(4090, 15, false);
#line 102 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                               Write(message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(4105, 193, true);
            WriteLiteral("\r\n                                </h2>\r\n                                <span>\r\n                                    Created by\r\n                                    <strong style=\"color: grey\">");
            EndContext();
            BeginContext(4298, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66656869be58422dbda24baf5026267d", async() => {
                BeginContext(4403, 20, false);
#line 106 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                                                                                   Write(message.Sender.Email);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
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
            BeginContext(4427, 90, true);
            WriteLiteral("</strong>\r\n                                    on\r\n                                    <i>");
            EndContext();
            BeginContext(4518, 20, false);
#line 108 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                  Write(message.CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(4538, 96, true);
            WriteLiteral("</i>\r\n                                    <br />\r\n                                    <br />\r\n\r\n");
            EndContext();
#line 112 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                     if (message.LikeDisabled == false)
                                    {

#line default
#line hidden
            BeginContext(4746, 173, true);
            WriteLiteral("                                        <strong style=\"color: darkblue\">\r\n                                            <a class=\"btn btn-sm btn-success likeButton\" data-url=\"");
            EndContext();
            BeginContext(4920, 67, false);
#line 115 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                              Write(Url.Action("AddLike", "Messages", new {id = message.Id.ToString()}));

#line default
#line hidden
            EndContext();
            BeginContext(4987, 63, true);
            WriteLiteral("\">Like</a>\r\n                                        </strong>\r\n");
            EndContext();
#line 117 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(5170, 178, true);
            WriteLiteral("                                        <strong style=\"color: darkblue\">\r\n                                            <a class=\"btn btn-sm btn-danger removelikeButton\" data-url=\"");
            EndContext();
            BeginContext(5349, 70, false);
#line 121 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                   Write(Url.Action("RemoveLike", "Messages", new {id = message.Id.ToString()}));

#line default
#line hidden
            EndContext();
            BeginContext(5419, 70, true);
            WriteLiteral("\">Remove Like</a>\r\n                                        </strong>\r\n");
            EndContext();
#line 123 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5528, 78, true);
            WriteLiteral("                                    :\r\n                                    <i>");
            EndContext();
            BeginContext(5607, 19, false);
#line 125 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                  Write(message.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5626, 135, true);
            WriteLiteral("</i>\r\n\r\n                                    <br />\r\n\r\n                                </span>\r\n                                <br />\r\n");
            EndContext();
#line 131 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                 if (ViewData["isAdmin"].ToString() == "True" || this.User.Identity.Name == Model.Email)
                                {


#line default
#line hidden
            BeginContext(5920, 111, true);
            WriteLiteral("                                    <a style=\"margin: 0 auto\" class=\"deleteBtn btn btn-danger col-3\" data-url=\"");
            EndContext();
            BeginContext(6032, 66, false);
#line 134 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                          Write(Url.Action("RemoveMessage", "Users", new {messageId = message.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(6098, 102, true);
            WriteLiteral("\">\r\n                                        Delete Message\r\n                                    </a>\r\n");
            EndContext();
#line 137 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                }

#line default
#line hidden
            BeginContext(6235, 116, true);
            WriteLiteral("                                <br />\r\n                                <br />\r\n                            </div>\r\n");
            EndContext();
#line 141 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                        }

#line default
#line hidden
#line 141 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                         

                    }

#line default
#line hidden
            BeginContext(6403, 196, true);
            WriteLiteral("                    <br />\r\n                </div>\r\n            </div>\r\n\r\n            <br />\r\n            \r\n            <div class=\"revealOnScroll\" data-animation=\"rotateInUpLeft\">\r\n\r\n            ");
            EndContext();
            BeginContext(6599, 537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf9213fa36da42fbb1e81670072af9a7", async() => {
                BeginContext(6605, 389, true);
                WriteLiteral(@"

                <h2 class=""""><strong>Add Message</strong></h2>
                <div class=""form-group row"">
                    <textarea class=""form-control messageDescription"" name=""Description"" placeholder=""Enter Comment""
                              minlength=""10"" required></textarea>
                </div>

                <input type=""button"" id=""btn-add-pet"" data-url=""");
                EndContext();
                BeginContext(6995, 55, false);
#line 160 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                           Write(Url.Action("AddMessage", "Users", new { id = Model.Id}));

#line default
#line hidden
                EndContext();
                BeginContext(7050, 79, true);
                WriteLiteral("\" class=\"btn btn-success btn-lg btn-block\" value=\"Add Comment\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7136, 307, true);
            WriteLiteral(@"
            </div>

            <br />
            <br />


            <div class=""revealOnScroll"" data-animation=""rotateInUpRight"">

                <div class=""card-footer text-center"">
                    <h1 class=""display-3"" style=""background: lightgreen"">Actions</h1>
                    ");
            EndContext();
            BeginContext(7443, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c0cc0820c5949c7bf088a92fb675a3c", async() => {
                BeginContext(7515, 4, true);
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
            BeginContext(7523, 90, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7631, 1392, true);
                WriteLiteral(@"

    <script>
        $(""#btn-add-pet"").click(function () {

            let addMessageUrl = $(this).data(""url"");

            let id = addMessageUrl.split(""/"").pop();

            let Description = $('.messageDescription').val();
            
            $('.messageDescription').val('');

            $.get(addMessageUrl,
                    {
                    Description: Description,
                    id: id
                }).then((res) => {

                    console.log(""SUCCESS !"");
                    
                    let currentMessage = """";

                    $.ajax({
                        url: '/Messages/GetLastMessage',
                        method: 'GET',
                        dataType: ""json"",
                        success: function (currentMessage) {
                            

                        $("".noCommentsPresent"").fadeOut();


                     //APPEND TO
                    $('.commentsContainer')
                        ");
                WriteLiteral(@".append(
                         ""<div>""
                            + ""<h2 class=\""contentDiv\"">""
                                + Description
                            + ""</h2>""
                        + ""<span> Created by ""
                        + ""<strong class=\""profile\"">""
                            + ""<a class='profileLink' href='/Users/Profile/");
                EndContext();
                BeginContext(9024, 72, false);
#line 224 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                      Write(context.Users.FirstOrDefault(u => u.Email == this.User.Identity.Name).Id);

#line default
#line hidden
                EndContext();
                BeginContext(9096, 2, true);
                WriteLiteral("\'>");
                EndContext();
                BeginContext(9099, 23, false);
#line 224 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Users\Profile.cshtml"
                                                                                                                                                 Write(this.User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(9122, 2789, true);
                WriteLiteral(@"</a>""
                        + ""</strong> on ""
                        + ""<i>"" + new Date().toLocaleDateString('en-gb') + "" "" + new Date().toLocaleTimeString('en-gb') + ""</i><br/><br/>""

                        + ""<strong style='color:darkblue'>""
                        + ""<a class='btn btn-sm btn-success likeButton' data-url='/Messages/AddLike/"" + currentMessage.id + ""'>Like</a>""
                            + ""</strong>""
                            + "":""
                            + ""<i class=\""commentLikes\"">0</i>""
                        + ""</span><br/><br/>""
                        +""<br /><br /></div>"");

                        },
                        error : (err) => console.log(err)
                    })
                });
        });


    </script>

    <script>
        $("".deleteBtn"").click(function () {
            let deleteCommentUrl = $(this).data(""url"");
            $.get(deleteCommentUrl);
            $(this).parent().fadeOut();
        });
    </script>

 ");
                WriteLiteral(@"   <script>

        $(""body"").on(""click"", "".likeButton"", function () {
            let addLikeUrl = $(this).data(""url"");
            $.get(addLikeUrl);

            let commentId = addLikeUrl.split(""/"").slice(-1).pop()
            console.log(commentId)
            let currentLikes = Number($(this).parent().next()[0].innerText);
            let newLikes = currentLikes + 1;

            console.log($(this).parent().next()[0]);
            $(this).parent().next().replaceWith(""<i class=\""commentLikes\"">"" + newLikes + ""</i>"");
            //replace


            $(this).fadeOut(() => {
                $(""<a class='btn btn-sm btn-danger removelikeButton' data-url='/Messages/RemoveLike/"" + commentId + ""'>Remove Like</a>"").hide().appendTo($(this).parent()).fadeIn();
            });
        });

    </script>

    <script>

        $(""body"").on(""click"", "".removelikeButton"", function () {

            let removeLikeUrl = $(this).data(""url"");
            $.get(removeLikeUrl);

           ");
                WriteLiteral(@" let commentId = removeLikeUrl.split(""/"").slice(-1).pop()
            console.log(commentId);

            let currentLikes = Number($(this).parent().next()[0].innerText);
            console.log(currentLikes)

            let newLikes = currentLikes - 1;
            console.log(newLikes)

            console.log($(this).parent().next()[0]);

            //replace
            $(this).parent().next().replaceWith(""<i class=\""commentLikes\"">"" + newLikes + ""</i>"");

            $(this).fadeOut(() => {
                $(""<a class='btn btn-sm btn-success likeButton'  data-url='/Messages/AddLike/"" + commentId + ""'>Like</a>"").hide().appendTo($(this).parent()).fadeIn();
            });

        });

    </script>

    ");
                EndContext();
                BeginContext(11911, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "599cc68751164433b5ce4767a36370aa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11973, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindMyPet.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
