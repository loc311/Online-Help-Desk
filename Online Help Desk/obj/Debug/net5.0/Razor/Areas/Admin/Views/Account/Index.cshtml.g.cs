#pragma checksum "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e038fdfd66a45b542ff2f29f2e31ea2ed0e56f9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineHelpDesk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineHelpDesk.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
using OnlineHelpDesk.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e038fdfd66a45b542ff2f29f2e31ea2ed0e56f9d", @"/Areas/Admin/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5979f3922cf172a192a1c258b8450b5ddc3054dc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineHelpDesk.Areas.Admin.Models.RegisterUserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 8 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Acount List";
    var ds = ViewBag.data;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--CND VueJs-->\r\n<script src=\"https://cdn.jsdelivr.net/npm/vue@2/dist/vue.js\"></script>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/axios/0.25.0/axios.min.js\"></script>\r\n<h1 style=\"text-align:center\">Account list</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e038fdfd66a45b542ff2f29f2e31ea2ed0e56f9d5425", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<div id=""myApp"">



    <table class=""table"">
        <thead>
            <tr>
                <th>
                    <label>Email</label>
                </th>
                <th>
                    <label>FullName</label>
                </th>
                <th>
                    <label>PhoneNumber</label>
                </th>

                <th>
                    <label>Gender</label>
                </th>

                <th>
                    <label>Role</label>
                </th>

                <th>
                    <label>Action</label>
                </th>
            </tr>
        </thead>
        <tbody>

            <tr v-for=""(inf,index) in ds"" :key=""index"">
                <td>
                    {{inf.Email}}
                </td>
                <td>
                    {{inf.FullName}}
                </td>
                <td>
                    {{inf.PhoneNumber}}

                </td>
                <td>
      ");
            WriteLiteral(@"              <span v-if=""inf.Gender"">Male</span>
                    <span v-else>Fmale</span>

                </td>

                <td>


                    {{inf.Name}}

                </td>

                <td>

                    <div class=""dropdown"">
                        <button class=""btn btn-success dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Dropdown button
                        </button>
                        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">

                            <a href=""#"" class=""dropdown-item"" v-on:click=""resetpass(inf.Id)"">Reset Password</a>

                            <div  v-if=""inf.Id != userid"" >
                                <a href=""#"" v-on:click=""deleteuser(inf.Id)"" class=""dropdown-item"">Delete Account</a>

                            </div>

                            <a class=""dropdown-item"" v-on:cl");
            WriteLiteral("ick=\"editrole(inf.Id)\" href=\"#\">Edit Role</a>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </td>\r\n\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n    <pre id=\"ds\">");
#nullable restore
#line 116 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
            Write(JsonConvert.SerializeObject(ds));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n    <pre id=\"id\">");
#nullable restore
#line 117 "C:\Users\Loc Tran\Documents\GitHub\OnlineHelpDesk\OnlineHelpDesk\Areas\Admin\Views\Account\Index.cshtml"
            Write(UserManager.GetUserAsync(User).Result?.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pre>



    <!-- Button trigger modal -->
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" hidden data-target=""#exampleModal"" id=""click""></button>

    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Changed password successfully</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div style=""color:green; text-align:center"">Your password is: 123456789aA &commat; </div>
                </div>
            </div>
        </div>
    </div>




</di");
            WriteLiteral(@"v>




<script>



    var App = new Vue({
        el: ""#myApp"",
        created() {
            this.load();
        },

        data() {
            return {
                ds: [],
                userid:""0""
            }

        },
        methods: {

            load: function () {
                var ds1 = JSON.parse(document.getElementById(""ds"").innerText);

                var timeconvert = document.getElementById(""ds"");
                timeconvert.parentNode.removeChild(timeconvert);

                this.userid = document.getElementById(""id"").innerText;

              var  timeconvert1 = document.getElementById(""id"");
                timeconvert1.parentNode.removeChild(timeconvert1);

                

                console.log(ds1);

                this.ds = ds1;
            },


            resetpass: function (id) {
                let url = ""/admin/Account/ResetPassword?id="" + id;


                var request = new XMLHttpRequest();
          ");
            WriteLiteral(@"      request.open('POST', url, false);  // `false` makes the request synchronous
                request.send(null);

                if (request.status === 200) {// That's HTTP for 'ok'
                    console.log(request.responseText);

                    document.getElementById(""click"").click();

                }



            },

            deleteuser: function (id) {

                if (confirm(""Do you want to delete user ?"")) {
                    location.href = ""/admin/account/delete?id="" + id;

                }

            },

            editrole: function (id) {
                location.href = ""/admin/account/editrole?id="" + id;
            }

        }

    })


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineHelpDesk.Areas.Admin.Models.RegisterUserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591