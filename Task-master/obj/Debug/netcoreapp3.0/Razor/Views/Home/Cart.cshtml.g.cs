#pragma checksum "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaef86ebb658581a5e3d4df9c2bf62f6dd45c26a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "D:\Users\bsi50130\Downloads\Task-master\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\Task-master\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaef86ebb658581a5e3d4df9c2bf62f6dd45c26a", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa69464cafd4d76600b45784b8a784724c641a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Get Your Bites First than Other";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<h5>Confirm your Cookie First</h5>\n\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef86ebb658581a5e3d4df9c2bf62f6dd45c26a3920", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
  <style>
    /* Remove the navbar's default rounded borders and increase the bottom margin */ 
    .navbar {
      margin-bottom: 50px;
      border-radius: 0;
      background-color: #191716;
    }
    
    /* Remove the jumbotron's default bottom margin */ 
     .jumbotron {
      margin-bottom: 0;
    }
   
    /* Add a gray background color and some padding to the footer */
    footer {
      background-color: #f2f2f2;
      padding: 25px;
    }
    input[type=text] {
      width: 130px;
      box-sizing: border-box;
      border: 2px solid #ccc;
      border-radius: 4px;
      font-size: 16px;
      background-color: white;
 ");
                WriteLiteral(@"     background-image: url('searchicon.png');
      background-position: 10px 10px; 
      background-repeat: no-repeat;
      padding: 12px 20px 12px 40px;
      transition: width 0.4s ease-in-out;
    }

    input[type=text]:focus {
      width: 100%;
    }
  </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef86ebb658581a5e3d4df9c2bf62f6dd45c26a6228", async() => {
                WriteLiteral("\n<br>\n<div class=\"container\">\n<div class=\"row\">\n<div class=\"col-md-6\">\n<label>Full Name</label>\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef86ebb658581a5e3d4df9c2bf62f6dd45c26a6590", async() => {
                    WriteLiteral("\n  <input type=\"text\" name=\"search\" style=\"background-image: url(https://simpleicon.com/wp-content/uploads/user1.png);\" id=\"a\" placeholder=\"Name\">\n");
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
                WriteLiteral("\n<br>\n<label>Address</label>\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef86ebb658581a5e3d4df9c2bf62f6dd45c26a8068", async() => {
                    WriteLiteral("\n  <input type=\"text\" name=\"search\" id=\"b\" placeholder=\"Address\">\n");
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
                WriteLiteral("\n</div>\n<br>\n<div class=\"col-md-6\">\n<label>Mobile Number</label>\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef86ebb658581a5e3d4df9c2bf62f6dd45c26a9503", async() => {
                    WriteLiteral("\n  <input type=\"text\" name=\"search\" id=\"c\" placeholder=\"Phone\">\n");
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
                WriteLiteral("\n<br>\n<label>Email</label>\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef86ebb658581a5e3d4df9c2bf62f6dd45c26a10894", async() => {
                    WriteLiteral("\n  <input type=\"text\" name=\"search\" id=\"d\" placeholder=\"Email\">\n");
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
                WriteLiteral(@"
</div>
</div>
</div>
</div>
<br>
<div class=""container mb-4"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th scope=""col""> </th>
                            <th scope=""col"">Product</th>
                            <th scope=""col"" class=""text-center"">Quantity</th>
                            <th scope=""col"" class=""text-right"">Price</th>
                            <th> </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 100 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
                           
                         var x = ViewBag.items;
                         int sum = 0;
                         int total = 0;
                         foreach (var i in x)
                            {
                         sum= @i.quantity * @i.harga;
                         total+=sum;
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\n                            <td><img style=\"width:100px\"");
                BeginWriteAttribute("src", " src=", 3146, "", 3158, 1);
#nullable restore
#line 109 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3151, i.foto, 3151, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/> </td>\n                            <td>");
#nullable restore
#line 110 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
                           Write(i.nama);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td><input");
                BeginWriteAttribute("id", " id=\"", 3250, "\"", 3264, 2);
                WriteAttributeValue("", 3255, "inp-", 3255, 4, true);
#nullable restore
#line 111 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3259, i.id, 3259, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=", 3298, "", 3316, 1);
#nullable restore
#line 111 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3305, i.quantity, 3305, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></td>\n                            <td class=\"text-right\">Rp.");
#nullable restore
#line 112 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
                                                 Write(i.harga);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>\n                            <div class=\"text-right\">\n                            <button");
                BeginWriteAttribute("id", " id=\"", 3512, "\"", 3526, 2);
                WriteAttributeValue("", 3517, "upd-", 3517, 4, true);
#nullable restore
#line 115 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3521, i.id, 3521, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-success\" value=\"update\" onclick=\"javascript:submitUpdate(this)\">Update</button>\n                            <button");
                BeginWriteAttribute("id", " id=\"", 3672, "\"", 3686, 2);
                WriteAttributeValue("", 3677, "rem-", 3677, 4, true);
#nullable restore
#line 116 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3681, i.id, 3681, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-danger\" value=\"remove\" onclick=\"javascript:remove(this)\">Remove</button>\n                            </div></td>\n                        </tr> ");
#nullable restore
#line 118 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
                              }
                         

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                       
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td><strong>Total (Rp)</strong></td>
                            <td class=""text-right""><strong id=""total"">");
#nullable restore
#line 127 "D:\Users\bsi50130\Downloads\Task-master\Views\Home\Cart.cshtml"
                                                                 Write(total);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div class=""col mb-2"">
            <div class=""row"">
                <div class=""col-sm-12  col-md-6"">
                    <button class=""btn btn-block btn-light"" onclick=""location.href='/Home/Product'"">Continue Shopping</button>
                </div>
                <div class=""col-sm-12 col-md-6 text-right"">
                    <button class=""btn btn-lg btn-block btn-primary text-uppercase"" onclick=""javascript:checkout(this)"">Checkout</button>
                </div>
            </div>
        </div>
        <br>
        <br>
    </div>
</div>
<br><br><br><br><br><br>
");
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
            WriteLiteral(@"
</html>

<script type=""text/javascript"">
function submitUpdate(buttonSubmit)
{
    var id = buttonSubmit.id;
    id = id.substring(4,id.Length);
    var inputId = ""inp-""+id;
    var value = document.getElementById(inputId).value;
    location.href='/Home/Update?id='+id+'&val='+value;
}

function remove(btn) {
    var id = btn.id;
    id = id.substring(4,id.Length);
    location.href='/Home/Delete?id='+id;
}

function checkout(btn) {
    var get = ""total"";
    var total = document.getElementById(get).innerHTML;
    var name = document.getElementById(""a"").value;
    var address = document.getElementById(""b"").value;
    var phone = document.getElementById(""c"").value;
    var email = document.getElementById(""d"").value;
    location.href='/Home/Charges?name='+name+'&address='+address+'&phone='+phone+'&email='+email+'&total='+total;
}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
