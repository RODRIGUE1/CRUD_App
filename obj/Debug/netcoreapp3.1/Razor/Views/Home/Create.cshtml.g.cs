#pragma checksum "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5b31212de19301ff1e665465127f5148268cdcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
#line 1 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Create.cshtml"
using Microsoft.EntityFrameworkCore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Create.cshtml"
using OdeToFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5b31212de19301ff1e665465127f5148268cdcb", @"/Views/Home/Create.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OdeToFood.Models.Restaurant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/header.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n \n");
#nullable restore
#line 6 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Create.cshtml"
   
     Layout = "~/Pages/Shared/_Layout.cshtml";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n\n");
            WriteLiteral("        \n<div class=\"row\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c5b31212de19301ff1e665465127f5148268cdcb4136", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
<div class=""row"">
    <div class=""col-md-2""></div><div class=""col-md-8"">
        <div class=""text-center""><h3 style=""color: #2270C0;"">Add Restaurant</h3></div>
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" name=""Name"" class=""form-control""/>
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cuisine"" class=""control-label""></label>
                <select asp-for=""Cuisine"" name=""Cuisine"" class=""form-control"">

");
#nullable restore
#line 28 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Create.cshtml"
                     foreach (CuisineType c in (CuisineType[]) Enum.GetValues(typeof(CuisineType)))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1183, "\"", 1210, 1);
#nullable restore
#line 31 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Create.cshtml"
WriteAttributeValue("", 1191, Convert.ToInt32(c), 1191, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Create.cshtml"
                                                       Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 32 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Create.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\n                <span asp-validation-for=\"Cuisine\" class=\"text-danger\"></span>\n            </div>\n\n            <div class=\"form-group\">\n                <input type=\"submit\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1445, "\"", 1455, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"Save\" class=\"btn btn-primary\"/>\n            </div>\n        </form>\n    </div>\n     </div><div class=\"col-md-2\"></div>\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
