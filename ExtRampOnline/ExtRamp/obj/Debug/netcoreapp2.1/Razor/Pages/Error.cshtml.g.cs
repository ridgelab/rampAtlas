#pragma checksum "C:\Users\matthodg\source\repos\ExtRamp_ASP.Net\ExtRamp_ASP.Net\ExtRamp\ExtRamp\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08867921331a8acb942abc569637133c98d8e001"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExtRamp.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Error.cshtml", typeof(ExtRamp.Pages.Pages_Error), null)]
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
#line 1 "C:\Users\matthodg\source\repos\ExtRamp_ASP.Net\ExtRamp_ASP.Net\ExtRamp\ExtRamp\Pages\_ViewImports.cshtml"
using ExtRamp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08867921331a8acb942abc569637133c98d8e001", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ede91916adb3e22c16f8d8bb61be53c76fd724", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\matthodg\source\repos\ExtRamp_ASP.Net\ExtRamp_ASP.Net\ExtRamp\ExtRamp\Pages\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(67, 183, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\" style=\"text-align: center\">Error.</h1>\r\n<!--<h2 class=\"text-danger\" style=\"text-align: center\">You did not provide the required fasta file.</h2>-->\r\n\r\n<!--\r\n");
            EndContext();
#line 11 "C:\Users\matthodg\source\repos\ExtRamp_ASP.Net\ExtRamp_ASP.Net\ExtRamp\ExtRamp\Pages\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(280, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(333, 15, false);
#line 14 "C:\Users\matthodg\source\repos\ExtRamp_ASP.Net\ExtRamp_ASP.Net\ExtRamp\ExtRamp\Pages\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(348, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 16 "C:\Users\matthodg\source\repos\ExtRamp_ASP.Net\ExtRamp_ASP.Net\ExtRamp\ExtRamp\Pages\Error.cshtml"
}

#line default
#line hidden
            BeginContext(370, 569, true);
            WriteLiteral(@"

<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>
-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
