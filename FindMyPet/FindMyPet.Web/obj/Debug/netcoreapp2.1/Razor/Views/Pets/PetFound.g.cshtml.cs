#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b64bf3f45ec1cb839f78d58bcd3c02e4d0c8ceb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_PetFound), @"mvc.1.0.view", @"/Views/Pets/PetFound.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pets/PetFound.cshtml", typeof(AspNetCore.Views_Pets_PetFound))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b64bf3f45ec1cb839f78d58bcd3c02e4d0c8ceb0", @"/Views/Pets/PetFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72a3507736061eb4800cfa095c8cb4e67dac9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_PetFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindMyPet.Web.Models.BindingModels.PetFoundBindingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PetFoundPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
  
    ViewData["Title"] = "PetFound";

#line default
#line hidden
            BeginContext(108, 427, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <div class=""col-12 text-center"">
            <br />
            <div class=""titleDiv"">
                <h1 class=""display-3 left"">Are you sure you found this pet ?</h1>
            </div>
            <br />
            <hr class=""display-3"" />

            <div class=""forms"">

                <img width=""500"" class=""card-image-top img-fluid img-thumbnail""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 535, "\"", 556, 1);
#line 19 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
WriteAttributeValue("", 541, Model.ImageUrl, 541, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(557, 117, true);
            WriteLiteral(" />\r\n                <br />\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>Type</strong> : ");
            EndContext();
            BeginContext(675, 10, false);
#line 23 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
                                                         Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(685, 95, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n                <h2 class=\"display-4\"><strong>Name</strong> : ");
            EndContext();
            BeginContext(781, 10, false);
#line 26 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
                                                         Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(791, 104, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>Location Lost</strong> : ");
            EndContext();
            BeginContext(896, 18, false);
#line 29 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
                                                                  Write(Model.LocationLost);

#line default
#line hidden
            EndContext();
            BeginContext(914, 100, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n                <h2 class=\"display-5\"><strong>Time Lost</strong> : ");
            EndContext();
            BeginContext(1015, 14, false);
#line 32 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
                                                              Write(Model.TimeLost);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 49, true);
            WriteLiteral("</h2>\r\n                <br />\r\n\r\n                ");
            EndContext();
            BeginContext(1078, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19b2b795de7e45278934493e6baf4312", async() => {
                BeginContext(1171, 254, true);
                WriteLiteral("\r\n\r\n                    <input type=\"submit\" id=\"btn-add-game\" class=\"left btn btn-success btn-lg btn-block\" value=\"Yes\" />\r\n                    <a id=\"btn-add-game\" href=\"/Pets/All\" class=\"right btn btn-primary btn-lg btn-block\">No</a>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
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
            BeginContext(1432, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindMyPet.Web.Models.BindingModels.PetFoundBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
