#pragma checksum "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3df483792bfbdffde3e0b84e214f1f7ea6002a4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Detail.cshtml", typeof(AspNetCore.Views_Order_Detail))]
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
#line 1 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb;

#line default
#line hidden
#line 1 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
using Microsoft.eShopWeb.ViewModels;

#line default
#line hidden
#line 3 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.ViewModels.Account;

#line default
#line hidden
#line 4 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.ViewModels.Manage;

#line default
#line hidden
#line 5 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\_ViewImports.cshtml"
using Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df483792bfbdffde3e0b84e214f1f7ea6002a4e", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843e4d411b447d0258efafc230228657e9de315c", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "My Order History";

#line default
#line hidden
#line 6 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "Order Detail";

#line default
#line hidden
            BeginContext(161, 666, true);
            WriteLiteral(@"
<div class=""esh-orders_detail"">
    <div class=""container"">
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-3"">Order number</section>
                <section class=""esh-orders_detail-title col-xs-3"">Date</section>
                <section class=""esh-orders_detail-title col-xs-3"">Total</section>
                <section class=""esh-orders_detail-title col-xs-3"">Status</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-3"">");
            EndContext();
            BeginContext(828, 17, false);
#line 21 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderNumber);

#line default
#line hidden
            EndContext();
            BeginContext(845, 77, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-item col-xs-3\">");
            EndContext();
            BeginContext(923, 15, false);
#line 22 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(938, 78, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-item col-xs-3\">$");
            EndContext();
            BeginContext(1017, 11, false);
#line 23 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1028, 78, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-title col-xs-3\">");
            EndContext();
            BeginContext(1107, 12, false);
#line 24 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 58, true);
            WriteLiteral("</section>\r\n            </article>\r\n        </section>\r\n\r\n");
            EndContext();
            BeginContext(1609, 361, true);
            WriteLiteral(@"
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">Shipping Address</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-12"">");
            EndContext();
            BeginContext(1971, 28, false);
#line 44 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.Street);

#line default
#line hidden
            EndContext();
            BeginContext(1999, 163, true);
            WriteLiteral("</section>\r\n            </article>\r\n\r\n            <article class=\"esh-orders_detail-items row\">\r\n                <section class=\"esh-orders_detail-item col-xs-12\">");
            EndContext();
            BeginContext(2163, 26, false);
#line 48 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.City);

#line default
#line hidden
            EndContext();
            BeginContext(2189, 163, true);
            WriteLiteral("</section>\r\n            </article>\r\n\r\n            <article class=\"esh-orders_detail-items row\">\r\n                <section class=\"esh-orders_detail-item col-xs-12\">");
            EndContext();
            BeginContext(2353, 29, false);
#line 52 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2382, 289, true);
            WriteLiteral(@"</section>
            </article>
        </section>

        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">ORDER DETAILS</section>
            </article>

");
            EndContext();
#line 61 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
             for (int i = 0; i < Model.OrderItems.Count; i++)
            {
                var item = Model.OrderItems[i];

#line default
#line hidden
            BeginContext(2798, 241, true);
            WriteLiteral("                <article class=\"esh-orders_detail-items esh-orders_detail-items--border row\">\r\n                    <section class=\"esh-orders_detail-item col-md-4 hidden-md-down\">\r\n                        <img class=\"esh-orders_detail-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3039, "\"", 3061, 1);
#line 66 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
WriteAttributeValue("", 3045, item.PictureUrl, 3045, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3062, 135, true);
            WriteLiteral(">\r\n                    </section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-4\">");
            EndContext();
            BeginContext(3198, 16, false);
#line 68 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                               Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3214, 114, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">$ ");
            EndContext();
            BeginContext(3329, 29, false);
#line 69 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                                 Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3358, 112, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">");
            EndContext();
            BeginContext(3471, 10, false);
#line 70 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                               Write(item.Units);

#line default
#line hidden
            EndContext();
            BeginContext(3481, 114, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-2\">$ ");
            EndContext();
            BeginContext(3596, 57, false);
#line 71 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                                 Write(Math.Round(item.Units * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3653, 40, true);
            WriteLiteral("</section>\r\n                </article>\r\n");
            EndContext();
#line 73 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(3708, 612, true);
            WriteLiteral(@"        </section>

        <section class=""esh-orders_detail-section esh-orders_detail-section--right"">
            <article class=""esh-orders_detail-titles esh-basket-titles--clean row"">
                <section class=""esh-orders_detail-title col-xs-9""></section>
                <section class=""esh-orders_detail-title col-xs-2"">TOTAL</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-9""></section>
                <section class=""esh-orders_detail-item esh-orders_detail-item--mark col-xs-2"">$ ");
            EndContext();
            BeginContext(4321, 11, false);
#line 84 "C:\Program Files (x86)\Go Agent\pipelines\release-v20.3.1-Build\csEshopWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                           Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(4332, 76, true);
            WriteLiteral("</section>\r\n            </article>\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
