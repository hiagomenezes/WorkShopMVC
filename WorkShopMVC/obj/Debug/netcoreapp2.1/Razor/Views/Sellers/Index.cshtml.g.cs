#pragma checksum "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89fe30262b41f754c9a3de0fd8f531c4cea83fb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Index), @"mvc.1.0.view", @"/Views/Sellers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Index.cshtml", typeof(AspNetCore.Views_Sellers_Index))]
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
#line 1 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\_ViewImports.cshtml"
using WorkShopMVC;

#line default
#line hidden
#line 2 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\_ViewImports.cshtml"
using WorkShopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fe30262b41f754c9a3de0fd8f531c4cea83fb0", @"/Views/Sellers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67afbb129cc83d3f6798a4f0a189e6ddc1888744", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WorkShopMVC.Models.Seller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
  
    ViewData["Title"] = "Sellers";

#line default
#line hidden
            BeginContext(90, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(97, 17, false);
#line 6 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 135, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr class=\"success\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(250, 40, false);
#line 12 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(346, 41, false);
#line 15 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(387, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(443, 45, false);
#line 18 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(488, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(544, 46, false);
#line 21 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(590, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(702, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(763, 39, false);
#line 30 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(802, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(870, 40, false);
#line 33 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(910, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(978, 44, false);
#line 36 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1090, 45, false);
#line 39 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\hiago\Desktop\hiago\WorkShopMVC\WorkShopMVC\Views\Sellers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1190, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WorkShopMVC.Models.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591
