#pragma checksum "C:\Users\Bitard\Desktop\RiderProjects\SortingAlgorithmsASP\SortingAlgorithmsASP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffc8c3525f5e96760e95488472a135f9c2907c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Bitard\Desktop\RiderProjects\SortingAlgorithmsASP\SortingAlgorithmsASP\Views\_ViewImports.cshtml"
using SortingAlgorithmsASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bitard\Desktop\RiderProjects\SortingAlgorithmsASP\SortingAlgorithmsASP\Views\_ViewImports.cshtml"
using SortingAlgorithmsASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffc8c3525f5e96760e95488472a135f9c2907c2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f7b28d6ddab3ef602aa2a34e153d9628c631d7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>
    <div class=""table"">
        <h2>Сортировка пузырьком</h2>
        <table class=""table"">
            <tr><th>Количество</th><th>Время(tick/msec)</th></tr>
            <tr><td>100</td> <td>5777/0</td></tr>
            <tr><td>500</td> <td>142819/14</td></tr>
            <tr><td>1000</td> <td>567149/56</td></tr>
            <tr><td>2000</td> <td>2196658/219</td></tr>
            <tr><td>5000</td> <td>13821207/382</td></tr>
        </table>
    </div>

    <div class=""table"">
        <h2>Быстрая сортировка</h2>
        <table class=""table"">
            <tr><th>Количество</th><th>Время(tick/msec)</th></tr>
            <tr><td>100</td> <td>674/0</td></tr>
            <tr><td>500</td> <td>5589/0</td></tr>
            <tr><td>1000</td> <td>13104/1</td></tr>
            <tr><td>2000</td> <td>34961/3</td></tr>
            <tr><td>5000</td> <td>167617/16</td></tr>
        </table>
    </div>
</main>
");
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
