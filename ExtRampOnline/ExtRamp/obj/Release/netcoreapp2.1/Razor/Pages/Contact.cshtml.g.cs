#pragma checksum "C:\Users\matthodg\source\repos\rampAtlas\ExtRampOnline\ExtRamp\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50f9b343a498faa3d816fac2310762abf39aa9a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExtRamp.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(ExtRamp.Pages.Pages_Contact), null)]
namespace ExtRamp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\matthodg\source\repos\rampAtlas\ExtRampOnline\ExtRamp\Pages\_ViewImports.cshtml"
using ExtRamp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f9b343a498faa3d816fac2310762abf39aa9a6", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ede91916adb3e22c16f8d8bb61be53c76fd724", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("labpic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/lab.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("byulogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/byu.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\matthodg\source\repos\rampAtlas\ExtRampOnline\ExtRamp\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Our Team";

#line default
#line hidden
            BeginContext(86, 1171, true);
            WriteLiteral(@"
<!DOCTYPE html>
<html lang=""en"">
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Lato"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Montserrat"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<style>
    body, h1, h2, h3, h4, h5, h6 {
        font-family: ""Lato"", sans-serif
    }

    h1 {
        font-weight: bold;
    }

    .w3-bar, h1, button {
        font-family: ""Montserrat"", sans-serif
    }

    

    #byulogo {
        width: 50%
    }

    #labpic {
        width: 100%;
    }

    .show_on_mobile {
        display: none;
    }

    .hide_on_mobile {
        display: block;
    }

    header {
        width: 100%;
        height: 404px;
        background-image: url(""/images/lsb.jpg"")");
            WriteLiteral(";\r\n        background-repeat: no-repeat;\r\n        background-size: cover;\r\n        display: block;\r\n        /*padding: 128px 16px;*/\r\n    }\r\n\r\n    ");
            EndContext();
            BeginContext(1258, 669, true);
            WriteLiteral(@"@media (max-width: 600px) {

        h1 {
            font-size: 30px;
            font-weight: bold;
        }

        .hide_on_mobile {
            display: none;
        }

        .show_on_mobile {
            display: block;
        }

        .small_button {
            font-size: 5px;
        }

        .small_mobile_text {
            font-size: 20px;
        }

        #byulogo {
            width: 75%;
            margin-bottom: 40px;
        }

        #labpic {
            width: 75%;
            margin-top: 40px;
        }

        .center_on_mobile {
            text-align: center;
        }

    }
</style>
");
            EndContext();
            BeginContext(1927, 2410, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3591a8a4c0a40b1902bbb2534724fe9", async() => {
                BeginContext(1933, 1383, true);
                WriteLiteral(@"

    <header class=""w3-container w3-center"" style=""padding:128px 16px"">

        <h1 class=""hide_on_mobile w3-margin w3-jumbo"" style=""color: white;"">OUR TEAM</h1>
        <h1 class=""show_on_mobile w3-margin w3-xxxlarge"" style=""color: white;"">OUR TEAM</h1>
        <p class=""hide_on_mobile w3-xlarge"" style=""color: white;"">The Makers of the Ramp Atlas </p>
        <p class=""show_on_mobile w3-large"" style=""color: white;"">The Makers of the Ramp Atlas</p>

        <!--<button class=""w3-button w3-black w3-padding-large w3-large w3-margin-top"">Get Started</button>-->
    </header>



    <div class=""w3-row-padding w3-padding-64 w3-container"">
        <div class=""w3-content center_on_mobile"">
            <h1 style=""text-align: center"">The Kauwe Lab</h1>
            <br />
            <br />
            <div class=""w3-twothird"">


                <h5 class=""w3-padding-32"">There's more to what we do.</h5>

                <p class=""w3-text-grey"">
                    The Kauwe Lab investigates e");
                WriteLiteral(@"verything from bonefish conservation to polygenic risk scores to rheumatic heart disease in Samoa.
                    Check out our <a href=""https://biology.byu.edu/kauwe-lab"" style=""color:blue;"">website</a> for more information about our lab!
                </p>



            </div>

            <div class=""w3-third w3-center"">
                ");
                EndContext();
                BeginContext(3316, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79df7f5214d4486e81f8eedeb0813f12", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3358, 346, true);
                WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""w3-row-padding w3-light-grey w3-padding-64 w3-container"">
        <div class=""w3-content center_on_mobile"">
            <h1 style=""text-align: center"">Please reach out.</h1>
            <br />
            <br />
            <div class=""w3-half w3-center"">
                ");
                EndContext();
                BeginContext(3704, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0542c094073479b90fe9114d6ae0e30", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3747, 583, true);
                WriteLiteral(@"
            </div>

            <div class=""w3-half"">

                <br />
                <br />
                <address>
                    Life Sciences Building<br />
                    Provo, Utah<br />
                    Phone: (801) 422-1458<br /><br />
                    <strong>Our Lab:</strong> <a href=""https://biology.byu.edu/kauwe-lab"">The Kauwe Lab</a><br />
                    <strong>Email:</strong> <a href=""mailto:biosecretary@byu.edu"">biosecretary@byu.edu</a>

                </address>
            </div>
        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4337, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExtRamp.Pages.ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExtRamp.Pages.ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExtRamp.Pages.ContactModel>)PageContext?.ViewData;
        public ExtRamp.Pages.ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
