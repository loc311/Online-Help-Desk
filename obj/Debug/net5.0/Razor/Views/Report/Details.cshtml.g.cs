#pragma checksum "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0315335bb553c8540082b3061b0fe7b1e7a570cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Details), @"mvc.1.0.view", @"/Views/Report/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\_ViewImports.cshtml"
using OnlineHelpDesk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\_ViewImports.cshtml"
using OnlineHelpDesk.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0315335bb553c8540082b3061b0fe7b1e7a570cd", @"/Views/Report/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad6ecaac315b73df965e2ddbf3700b5cef0e2bd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineHelpDesk.Models.Request>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Request", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Report</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FacilityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 17 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
             foreach (var item in ViewBag.facilities)
            {
                if (item.FacilityId == Model.FacilityId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 21 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
                  Write(item.FacilityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 22 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestSampleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 29 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
             foreach (var item in ViewBag.requestSamples)
            {
                if (item.RequestSampleId == Model.RequestSampleId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 33 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
                  Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 47 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
             if (Model.Status == "Report")
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-danger\">Waiting for approval</p>\r\n");
#nullable restore
#line 52 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-primary\">");
#nullable restore
#line 55 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
                                   Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 56 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Report\Details.cshtml"
       Write(Html.Raw(Model.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0315335bb553c8540082b3061b0fe7b1e7a570cd9489", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineHelpDesk.Models.Request> Html { get; private set; }
    }
}
#pragma warning restore 1591