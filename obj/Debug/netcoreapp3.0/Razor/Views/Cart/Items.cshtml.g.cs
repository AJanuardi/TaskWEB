#pragma checksum "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\Cart\Items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c866fe457c999f41f2e8d6d510bbdb0c873deded"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Items), @"mvc.1.0.view", @"/Views/Cart/Items.cshtml")]
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
#line 1 "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c866fe457c999f41f2e8d6d510bbdb0c873deded", @"/Views/Cart/Items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa69464cafd4d76600b45784b8a784724c641a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Thank You</h1>\r\n");
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\Cart\Items.cshtml"
  
  var x = ViewBag.cart;
  foreach (var i in x)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\Cart\Items.cshtml"
Write(i.nama);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\Cart\Items.cshtml"
Write(i.quantity);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\Cart\Items.cshtml"
               
  }
  var y = ViewBag.purchase;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\Cart\Items.cshtml"
Write(y.total);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Users\bsi50130\Downloads\TaskWEB-2.4.1\Views\Cart\Items.cshtml"
Write(y.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5>This is your Expedition Receipt</h5>\r\n<h6>sdhashdjashdjhasd</h6>");
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
