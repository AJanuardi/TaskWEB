#pragma checksum "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed3ce3d01406c4c758a7a7a0cf05214d316edb33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Data), @"mvc.1.0.view", @"/Views/Admin/Data.cshtml")]
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
#line 1 "D:\Users\bsi50130\Downloads\TaskWEB\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\TaskWEB\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3ce3d01406c4c758a7a7a0cf05214d316edb33", @"/Views/Admin/Data.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa69464cafd4d76600b45784b8a784724c641a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Data : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3ce3d01406c4c758a7a7a0cf05214d316edb334410", async() => {
                WriteLiteral(@"
<div class=""text-center"">
<h2>Administration Page</h2>
</div>
<style>
#cookies {
  font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#cookies td, #cookies th {
  border: 1px solid #ddd;
  padding: 8px;
}

#cookies tr:nth-child(even){background-color: #f2f2f2;}

#cookies tr:hover {background-color: #ddd;}

#cookies th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: white;
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3ce3d01406c4c758a7a7a0cf05214d316edb335874", async() => {
                WriteLiteral(@"
<br>
<div class=""container"">
  <div class=""row"">
    <div class=""col-md-6"">
    <div class=""text-left"">
      <button id=""btn"" type=""button"" class=""btn btn-danger"" value=""update"" onclick=""location.href='/Admin/Logout'"">Logout</button>
    </div>
    </div>
  </div>
</div>
<br>
          <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6"">
                <div class=""text-left"">
                <button id=""btn"" type=""button"" class=""btn btn-primary"" value=""update"" onclick=""location.href='/Admin/Export'"">Export</button>
                </div>
                <br>
                <br>
                </div>
                <div class=""col-md-6"">
                <div class=""text-right"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3ce3d01406c4c758a7a7a0cf05214d316edb336917", async() => {
                    WriteLiteral("\n                  <input  type=\"file\" id=\"Upload\" name=\"Upload\" value=\"Upload\">\n                  <button type=\"submit\" class=\"btn btn-success\">Import</button>\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
<div class=""text-center"">
<table id=""cookies"">
  <tr>
    <th>Id</th>
    <th>Rating</th>
    <th>Nama</th>
    <th>Deskripsi</th>
    <th>Harga</th>
    <th>Action</th>
  </tr>
");
                WriteLiteral(@"    <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4"">
                <div class=""text-right"">
                <button id=""btn"" type=""button"" class=""btn btn-success"" value=""update"" onclick=""location.href='/Admin/Edit'"">Edit</button>
                </div>
                </div>
                <div class=""col-md-4"">
                <div class=""text-center"">
                <button id=""btn"" type=""button"" class=""btn btn-success"" value=""update"" onclick=""location.href='/Admin/Add'"">Add</button>
                </div>
                </div>
                <div class=""col-md-4"">
                <div class=""text-left"">
                <button id=""btn"" type=""button"" class=""btn btn-success"" value=""update"" onclick=""location.href='/Admin/Transaction'"">Transaction</button>
                </div>
                </div>
            </div>
    </div>
");
#nullable restore
#line 94 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml"
 
      var x = ViewBag.items;
      foreach (var i in x)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 99 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml"
           Write(i.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 100 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml"
           Write(i.rating);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 101 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml"
           Write(i.nama);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 102 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml"
           Write(i.deskripsi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 103 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml"
           Write(i.harga);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>\n                <button id=\"btn\" type=\"button\" class=\"btn btn-danger\" value=\"update\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3045, "\"", 3090, 3);
                WriteAttributeValue("", 3055, "location.href=\'/Admin/Remove/", 3055, 29, true);
#nullable restore
#line 105 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml"
WriteAttributeValue("", 3084, i.id, 3084, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3089, "\'", 3089, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Remove</button>\n            </td>\n        </tr>\n");
#nullable restore
#line 108 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Admin\Data.cshtml"
      }
  

#line default
#line hidden
#nullable disable
                WriteLiteral("</table>\n</div>\n");
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
            WriteLiteral("\n</html>\n");
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
