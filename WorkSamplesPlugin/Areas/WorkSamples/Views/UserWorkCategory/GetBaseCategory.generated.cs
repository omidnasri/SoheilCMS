﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using WorkSamplesPlugin;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/WorkSamples/Views/UserWorkCategory/GetBaseCategory.cshtml")]
    public partial class _Areas_WorkSamples_Views_UserWorkCategory_GetBaseCategory_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<WorkSample.Contracts.WorkCategoryBaseDTO>>
    {
        public _Areas_WorkSamples_Views_UserWorkCategory_GetBaseCategory_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 text-center\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"block-header\"");

WriteLiteral(">\r\n                نمونه کارهای ما\r\n            </h2>\r\n            <h3>فعلا نمونه" +
" کاری نداریم این تصاویر فعلا الکیه</h3>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"portfolio_wrapper\"");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"text-center filters col-sm-12\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" id=\"firtlable\"");

WriteLiteral(">\r\n                <li><a");

WriteLiteral(" class=\"selected\"");

WriteLiteral(" data-filter=\"*\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">همه</a></li>\r\n");

            
            #line 15 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
                
            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
                 foreach (var item in Model)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li><a");

WriteLiteral(" data-filter=\".");

            
            #line 17 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
                                    Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 17 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
                                                                  Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 18 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n            <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n        </div>\r\n        <!-- Items -->\r\n\r\n    <ul");

WriteLiteral(" class=\"items-row row cols-3 portfolio firtlable clearfix isotope\"");

WriteLiteral(" id=\"portfolioContainer\"");

WriteLiteral(">\r\n\r\n");

            
            #line 26 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
         foreach (var item in Model)
        {
            foreach (var sample in item.Samples)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteAttribute("class", Tuple.Create(" class=\"", 1066), Tuple.Create("\"", 1120)
, Tuple.Create(Tuple.Create("", 1074), Tuple.Create("item", 1074), true)
, Tuple.Create(Tuple.Create(" ", 1078), Tuple.Create("col-sm-6", 1079), true)
, Tuple.Create(Tuple.Create(" ", 1087), Tuple.Create("col-md-4", 1088), true)
, Tuple.Create(Tuple.Create(" ", 1096), Tuple.Create("isotope-item", 1097), true)
            
            #line 30 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
, Tuple.Create(Tuple.Create(" ", 1109), Tuple.Create<System.Object, System.Int32>(item.Name
            
            #line default
            #line hidden
, 1110), false)
);

WriteLiteral(">\r\n\r\n                    <!-- Image -->\r\n\r\n                    <div");

WriteLiteral(" class=\"portfolio_item_image\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" alt=\"\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1255), Tuple.Create("\"", 1287)
            
            #line 35 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
, Tuple.Create(Tuple.Create("", 1261), Tuple.Create<System.Object, System.Int32>(Url.Content(sample.Image)
            
            #line default
            #line hidden
, 1261), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"portfolio_links\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" class=\"p-view prettyPhoto\"");

WriteLiteral(" title=\"\"");

WriteLiteral(" rel=\"prettyPhoto[pp_gal]\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1438), Tuple.Create("\"", 1485)
            
            #line 37 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
                   , Tuple.Create(Tuple.Create("", 1445), Tuple.Create<System.Object, System.Int32>(Url.Content("~/example/intro_img1.jpg")
            
            #line default
            #line hidden
, 1445), false)
);

WriteLiteral("></a>\r\n                            <a");

WriteLiteral(" class=\"p-link\"");

WriteLiteral(" title=\"\"");

WriteAttribute("href", Tuple.Create(" \r\n                            href=\"", 1547), Tuple.Create("\"", 1710)
            
            #line 39 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
, Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Url.Action("Show","UserWorkSample",
                                 new {id=sample.Id,Name=sample.Slug,Area="WorkSamples"})
            
            #line default
            #line hidden
, 1584), false)
);

WriteLiteral("></a>\r\n                        </div>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"item_title\"");

WriteLiteral(">\r\n                        <h4>\r\n                            <a");

WriteLiteral(" class=\"p-link\"");

WriteLiteral(" title=\"\"");

WriteAttribute("href", Tuple.Create("\r\n                               href=\"", 1908), Tuple.Create("\"", 2076)
            
            #line 46 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
, Tuple.Create(Tuple.Create("", 1947), Tuple.Create<System.Object, System.Int32>(Url.Action("Show","UserWorkSample",
                                    new {id=sample.Id,Name=sample.Slug,Area="WorkSamples"})
            
            #line default
            #line hidden
, 1947), false)
);

WriteLiteral(">\r\n\r\n");

WriteLiteral("                                ");

            
            #line 49 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
                           Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n                        </h4>\r\n              " +
"      </div>\r\n                </li>\r\n");

            
            #line 54 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
            }

        }

            
            #line default
            #line hidden
WriteLiteral("     \r\n\r\n\r\n    </ul>\r\n    </div> <!--eof portfolio_wrapper-->\r\n\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"text-center loadmore\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2455), Tuple.Create("\"", 2564)
            
            #line 66 "..\..\Areas\WorkSamples\Views\UserWorkCategory\GetBaseCategory.cshtml"
, Tuple.Create(Tuple.Create("", 2462), Tuple.Create<System.Object, System.Int32>(Url.Action("ShowAll","UserWorkSample",
                                    new {Area="WorkSamples"})
            
            #line default
            #line hidden
, 2462), false)
);

WriteLiteral(" class=\"theme_btn inverse\"");

WriteLiteral(">\r\n                    مشاهده بیشتر\r\n                </a>\r\n            </p>\r\n    " +
"    </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
