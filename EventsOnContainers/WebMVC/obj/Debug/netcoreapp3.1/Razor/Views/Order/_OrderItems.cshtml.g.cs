#pragma checksum "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f44f7da81d3a33f72de11e394ef78b14c993292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__OrderItems), @"mvc.1.0.view", @"/Views/Order/_OrderItems.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f44f7da81d3a33f72de11e394ef78b14c993292", @"/Views/Order/_OrderItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__OrderItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMVC.Models.OrderModels.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<section class=\"esh-orders_new-section\">\r\n    <article class=\"esh-orders_new-titles row\">\r\n        <section class=\"esh-orders_new-title col-xs-12\">Order details</section>\r\n    </article>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
     for (int i = 0; i < Model.OrderItems.Count; i++)
    {
        var item = Model.OrderItems[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("        <article class=\"esh-orders_new-items esh-orders_new-items--border row\">\r\n            <section class=\"esh-orders_new-item col-md-4 hidden-md-down\">\r\n                <img class=\"esh-basket-image\"");
            BeginWriteAttribute("src", " src=\"", 540, "\"", 562, 1);
#nullable restore
#line 15 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 546, item.PictureUrl, 546, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"250\" height=\"150\">\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 627, "\"", 651, 1);
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 635, item.PictureUrl, 635, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 652, "", 695, 1);
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 658, "orderitems[" + i + "].PictureUrl", 658, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-xs-4\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 883, "\"", 908, 1);
#nullable restore
#line 20 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 891, item.ProductName, 891, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 909, "", 953, 1);
#nullable restore
#line 20 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 915, "orderitems[" + i + "].ProductName", 915, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-xs-1\">\r\n                $ ");
#nullable restore
#line 23 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
             Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1141, "\"", 1164, 1);
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1149, item.UnitPrice, 1149, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 1165, "", 1207, 1);
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1171, "orderitems[" + i + "].UnitPrice", 1171, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-xs-1\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
           Write(item.Units);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1389, "\"", 1408, 1);
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1397, item.Units, 1397, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 1409, "", 1447, 1);
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1415, "orderitems[" + i + "].Units", 1415, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-xs-2\">$ ");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
                                                                                   Write(Math.Round(item.Units * item.UnitPrice, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n        </article>\r\n");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>

<section class=""esh-orders_new-section esh-orders_new-section--right"">
    <article class=""esh-orders_new-titles row"">
        <section class=""esh-orders_new-title col-xs-9""></section>
        <section class=""esh-orders_new-title col-xs-2"">Total</section>
    </article>

    <article class=""esh-orders_new-items row"">
        <section class=""esh-orders_new-item col-xs-9""></section>
        <section class=""esh-orders_new-item esh-orders_new-item--mark col-xs-2"">
            $ ");
#nullable restore
#line 44 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
         Write(Model.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2199, "\"", 2224, 1);
#nullable restore
#line 45 "C:\Users\Admin\Desktop\Git\WebApplication-MicroServices\EventsOnContainers\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 2207, Model.OrderTotal, 2207, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Total\"/>\r\n        </section>\r\n    </article>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMVC.Models.OrderModels.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
