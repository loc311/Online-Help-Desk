#pragma checksum "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8e2d667a6bd5086e5b89a9623a9ce695a24484"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserProfile), @"mvc.1.0.view", @"/Views/Home/UserProfile.cshtml")]
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
#nullable restore
#line 5 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
using OnlineHelpDesk.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8e2d667a6bd5086e5b89a9623a9ce695a24484", @"/Views/Home/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad6ecaac315b73df965e2ddbf3700b5cef0e2bd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/ImageSystem/profilebackground.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 200px; max-height: 200px; vertical-align: text-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
  
    ViewData["Title"] = "User Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\" style=\"min-height:1000px\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c8e2d667a6bd5086e5b89a9623a9ce695a244846349", async() => {
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\" style=\"margin-top:2%; margin-left:10%\">\r\n        <div class=\"col-sm-4\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c8e2d667a6bd5086e5b89a9623a9ce695a244847618", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 724, "~/", 724, 2, true);
#nullable restore
#line 22 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
AddHtmlAttributeValue("", 726, Url.Content(ViewBag.user.Avatar), 726, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-8\">\r\n            <br />\r\n\r\n\r\n            <h3>");
#nullable restore
#line 29 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
           Write(ViewBag.user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <br />\r\n            <b>Gender:</b> <span>");
#nullable restore
#line 31 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
                                  if (@ViewBag.user.Gender) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Male</span> ");
#nullable restore
#line 31 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
                                                                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Fmale</span> ");
#nullable restore
#line 31 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
                                                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            <b>Mail:</b> <span>");
#nullable restore
#line 33 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
                          Write(ViewBag.user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            <b>Phone:</b> <span>");
#nullable restore
#line 35 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
                           Write(ViewBag.user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            <b>Role:</b> <span>");
#nullable restore
#line 37 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
                          Write(ViewBag.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 43 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
     if (@UserManager.GetUserAsync(User).Result?.FullName != null)
    {
        if (@UserManager.GetUserAsync(User).Result?.Id.Equals(ViewBag.user.Id))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"" style=""margin-top:5%"">
                <div class=""col"" style=""text-align:center"">

                    <a href=""/home/EditProfile"">
                        <button class=""btn btn-success"">Change Information </button>
                    </a>

                    <a href=""/Identity/Account/Manage/ChangePassword"">
                        <button class=""btn btn-info"">Change Password </button>
                    </a>

                </div>
            </div>
");
#nullable restore
#line 60 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Views\Home\UserProfile.cshtml"
        }




    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591