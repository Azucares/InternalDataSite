#pragma checksum "I:\Websites\AOAdata\AOAdata\Views\Home\InvPartials\InvList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "039a4fd3e766ff64c90907edec5bda7fc5e94a6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InvPartials_InvList), @"mvc.1.0.view", @"/Views/Home/InvPartials/InvList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/InvPartials/InvList.cshtml", typeof(AspNetCore.Views_Home_InvPartials_InvList))]
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
#line 1 "I:\Websites\AOAdata\AOAdata\Views\_ViewImports.cshtml"
using AOAdata.Models;

#line default
#line hidden
#line 2 "I:\Websites\AOAdata\AOAdata\Views\_ViewImports.cshtml"
using AOAdata.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"039a4fd3e766ff64c90907edec5bda7fc5e94a6a", @"/Views/Home/InvPartials/InvList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8dae985486c5542737c70d2a9d0a1eac696915b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InvPartials_InvList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PartsInventory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "I:\Websites\AOAdata\AOAdata\Views\Home\InvPartials\InvList.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(62, 35, true);
            WriteLiteral("    <p>No parts in inventory!</p>\r\n");
            EndContext();
#line 6 "I:\Websites\AOAdata\AOAdata\Views\Home\InvPartials\InvList.cshtml"
}
else
{
    foreach (PartsInventory i in @Model)
    {

#line default
#line hidden
            BeginContext(158, 26, true);
            WriteLiteral("<div class=\"col-10\">\r\n    ");
            EndContext();
            BeginContext(185, 52, false);
#line 12 "I:\Websites\AOAdata\AOAdata\Views\Home\InvPartials\InvList.cshtml"
Write(await  Html.PartialAsync("InvPartials/InvUpdate", i));

#line default
#line hidden
            EndContext();
            BeginContext(237, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 14 "I:\Websites\AOAdata\AOAdata\Views\Home\InvPartials\InvList.cshtml"
           
    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PartsInventory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
