#pragma checksum "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab680261575c8efa4eb8a35dd61da8cd2f48d08"
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
#line 1 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\_ViewImports.cshtml"
using CovidTrackingMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\_ViewImports.cshtml"
using CovidTrackingMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab680261575c8efa4eb8a35dd61da8cd2f48d08", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957da6d497b26422617b5003253680bda1f185ae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CovidTrackingMVC.Models.CovidDataModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.11.1/bootstrap-table.min.js""></script>
<link href=""//cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.11.1/bootstrap-table.min.css"" rel=""stylesheet""/>
<link rel=""stylesheet"" type=""text/css"" href=""extensions/filter-control/bootstrap-table-filter-control.css"">
<script src=""extensions/filter-control/bootstrap-table-filter-control.js""></script>


");
#nullable restore
#line 10 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
  
    ViewData["Covid Tracking Home Page"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Covid Tracking via information provided by the  <a href=""https://covidtracking.com/"">Covid Tracking</a> website </P
</div>


<div>
    <p>Please enter the two letter abbreviation for the state you wish to search</p>
      <table id=""table"" data-toggle=""table"" data-sort-name=""Positive"" data-sort-order=""desc"" data-search=""true"">
            <thead>
                <tr>
                    <th  data-field=""State"" data-filter-control=""select"" data-searchable=""true"">");
#nullable restore
#line 25 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                                                                                           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 26 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 27 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th data-field=\"Positive\" data-sortable=\"true\">");
#nullable restore
#line 28 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                                                              Write(Html.DisplayNameFor(model => model.Positive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 29 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Negative));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 30 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Hospitalized));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>              \r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Positive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Negative));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Hospitalized));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\eehar\Desktop\CovidTrackerMVC\CovidTrackingMVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n                        <script>\r\n$(\'#sortTable\').DataTable();\r\n\r\n</script>\r\n\r\n                        <script>\r\n  $(function() {\r\n    $(\'#table\').bootstrapTable()\r\n  })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CovidTrackingMVC.Models.CovidDataModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
