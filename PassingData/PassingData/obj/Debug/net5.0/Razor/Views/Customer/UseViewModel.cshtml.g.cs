#pragma checksum "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356e2a1a8f6de609635fcc368cc95a809c3e4da4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UseViewModel), @"mvc.1.0.view", @"/Views/Customer/UseViewModel.cshtml")]
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
#line 1 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
using PassingData.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
using PassingData.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356e2a1a8f6de609635fcc368cc95a809c3e4da4", @"/Views/Customer/UseViewModel.cshtml")]
    #nullable restore
    public class Views_Customer_UseViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerAndProductVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<p>\r\n\tMüsteriler\r\n</p>\r\n\r\n\r\n<ul>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
     foreach (Customer item in Model.customers) 
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<li>\n\t\t\t");
#nullable restore
#line 17 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 18 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
       Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</li>\n");
#nullable restore
#line 20 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<p> Urun ");
#nullable restore
#line 23 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
    Write(Model.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n\r\n<p> Tarih: ");
#nullable restore
#line 26 "C:\Users\maran\OneDrive\Masaüstü\MVC Project\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
      Write(Model.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerAndProductVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
