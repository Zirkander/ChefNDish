#pragma checksum "E:\Coding Dojo\C#\Asp\ChefNDish\Views\Dish\Dishs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a318b8fefe00f0b6cff2248d588510b15c75ece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Dishs), @"mvc.1.0.view", @"/Views/Dish/Dishs.cshtml")]
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
#line 1 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\_ViewImports.cshtml"
using ChefNDish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\_ViewImports.cshtml"
using ChefNDish.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a318b8fefe00f0b6cff2248d588510b15c75ece", @"/Views/Dish/Dishs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12487503386d53f6648e653d060ea532047ca121", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Dishs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\Dish\Dishs.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"" style=""display: flex; justify-content: space-between;"">
    <div style=""margin-left: 200px; border-bottom: 3px solid black; width: 600px; padding-bottom: 15px;"">
        <h1 class=""display-4"">
            <a href=""index"">Chefs</a> | Dishes
        </h1>
        <h4 style=""flex-direction: column;"">Yum, take a look at our tsty dishes!</h4>
    </div>
    <p><a href=""/dish/new"">Add a Dish</a></p>
    <hr>
</div>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Chef</th>
            <th scope=""col"">Tastiness</th>
            <th scope=""col"">Calories</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\Dish\Dishs.cshtml"
         foreach (var dish in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\Dish\Dishs.cshtml"
               Write(dish.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\Dish\Dishs.cshtml"
               Write(dish.DishChef.ChefName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\Dish\Dishs.cshtml"
               Write(dish.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\Dish\Dishs.cshtml"
               Write(dish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "E:\Coding Dojo\C#\Asp\ChefNDish\Views\Dish\Dishs.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591