#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89011b9ca3e26a998252c933770529c5049ee80"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89011b9ca3e26a998252c933770529c5049ee80", @"/Views/Pets/PetFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72a3507736061eb4800cfa095c8cb4e67dac9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_PetFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindMyPet.Web.Models.BindingModels.PetFoundBindingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PetFoundPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scrolling-animations-functions.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
  
    ViewData["Title"] = "PetFound";

#line default
#line hidden
            BeginContext(108, 456, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <div class=""col-12 text-center"">
            <br />
            <div class=""revealOnScroll"" data-animation=""zoomInDown"">
                <h1 class=""display-3"">Are you sure you found this pet ?</h1>
            </div>
            <br />
            <hr class=""display-3"" />

            <div class=""forms"">

                <img width=""500"" class=""card-image-top img-fluid img-thumbnail""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 564, "\"", 585, 1);
#line 19 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
WriteAttributeValue("", 570, Model.ImageUrl, 570, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(586, 360, true);
            WriteLiteral(@" />
                <br />
                <br />

                <br />
                <h2 class=""display-4"">
                    <strong class=""revealOnScroll"" data-animation=""right"">Type</strong>
                    <span class=""revealOnScroll"" data-animation=""forms""> : </span>
                    <i class=""revealOnScroll"" data-animation=""left"">");
            EndContext();
            BeginContext(947, 10, false);
#line 27 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
                                                               Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(957, 362, true);
            WriteLiteral(@"</i>
                </h2>
                <br />

                <br />
                <h2 class=""display-5"">
                    <strong class=""revealOnScroll"" data-animation=""right2"">Name</strong>
                    <span class=""revealOnScroll"" data-animation=""forms""> : </span>
                    <i class=""revealOnScroll"" data-animation=""left2"">");
            EndContext();
            BeginContext(1320, 10, false);
#line 35 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
                                                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1330, 329, true);
            WriteLiteral(@"</i>
                </h2>
                <br />

                <h2>
                    <strong class=""revealOnScroll"" data-animation=""left2"">Location Lost</strong>
                    <span class=""revealOnScroll"" data-animation=""forms""> : </span>
                    <i class=""revealOnScroll"" data-animation=""right2"">");
            EndContext();
            BeginContext(1660, 18, false);
#line 42 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
                                                                 Write(Model.LocationLost);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 325, true);
            WriteLiteral(@"</i>
                </h2>
                <br />

                <h2>
                    <strong class=""revealOnScroll"" data-animation=""left3"">Time Lost</strong>
                    <span class=""revealOnScroll"" data-animation=""forms""> : </span>
                    <i class=""revealOnScroll"" data-animation=""right3"">");
            EndContext();
            BeginContext(2004, 14, false);
#line 49 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
                                                                 Write(Model.TimeLost);

#line default
#line hidden
            EndContext();
            BeginContext(2018, 97, true);
            WriteLiteral("</i>\r\n                </h2>\r\n\r\n                <br />\r\n                <br />\r\n\r\n                ");
            EndContext();
            BeginContext(2115, 393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "739663317a2c41aa8bb4bccfde1933e8", async() => {
                BeginContext(2208, 293, true);
                WriteLiteral(@"

                    <input type=""submit"" id=""btn-add-game"" class=""btn btn-success btn-lg btn-block right""  data-timeout=""100"" value=""Yes"" />
                    <a id=""btn-add-game"" href=""/Pets/All"" class=""btn btn-primary btn-lg btn-block left"" data-timeout=""100"">No</a>
                ");
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
#line 55 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFound.cshtml"
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
            BeginContext(2508, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2586, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2592, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48915b9bc43f47bd9f791cb51391c449", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2654, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindMyPet.Web.Models.BindingModels.PetFoundBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
