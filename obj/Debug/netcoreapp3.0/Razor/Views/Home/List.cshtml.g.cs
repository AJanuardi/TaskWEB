#pragma checksum "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdd6181e7c5da47bda52e455bfec4dc98de41caf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd6181e7c5da47bda52e455bfec4dc98de41caf", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Models.Cookie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://localhost:5001/Home/Admin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml"
  
    ViewBag.Title = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
div.gallery {
  border: 1px solid #ccc;
}

div.gallery:hover {
  border: 1px solid #777;
}

div.gallery img {
  width: 100%;
  height: auto;
}

div.desc {
  padding: 15px;
  text-align: center;
}

* {
  box-sizing: border-box;
}

.responsive {
  padding: 0 6px;
  float: left;
  width: 24.99999%;
}

.clearfix:after {
  content: """";
  display: table;
  clear: both;
}
</style>

<h4>Listing</h4>
<br>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdd6181e7c5da47bda52e455bfec4dc98de41caf4139", async() => {
                WriteLiteral("\r\n    <button type=\"submit\">Turn Back Action</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br>\r\n");
#nullable restore
#line 47 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml"
  
     var x = ViewBag.items;
        foreach (var i in x)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"responsive\">\r\n                <div class=\"gallery\">\r\n                <a \r\n                target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 830, "\"", 880, 2);
            WriteAttributeValue("", 837, "https://localhost:5001/Product/Detail/", 837, 38, true);
#nullable restore
#line 54 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml"
WriteAttributeValue("", 875, i.id, 875, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 904, "\"", 917, 1);
#nullable restore
#line 55 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml"
WriteAttributeValue("", 910, i.foto, 910, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 263px; height: 150px;\">\r\n                </a>\r\n                <div class=\"desc\">\r\n                    <h6>");
#nullable restore
#line 58 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml"
                   Write(i.nama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <div class=\"text-right\">\r\n                    <h6>Rp.");
#nullable restore
#line 60 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml"
                      Write(i.harga);

#line default
#line hidden
#nullable disable
            WriteLiteral(",-</h6>\r\n                    </div>\r\n                    <h6>Buy It Now</h6>\r\n                </div>\r\n                <br>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdd6181e7c5da47bda52e455bfec4dc98de41caf7491", async() => {
                WriteLiteral("\r\n                <button type=\"submit\">Delete Cookies</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1305, "https://localhost:5001/Home/Del/", 1305, 32, true);
#nullable restore
#line 66 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml"
AddHtmlAttributeValue("", 1337, i.id, 1337, 5, false);

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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 70 "D:\Users\bsi50130\Downloads\TaskWEB\Views\Home\List.cshtml"
        }
        

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Models.Cookie> Html { get; private set; }
    }
}
#pragma warning restore 1591
