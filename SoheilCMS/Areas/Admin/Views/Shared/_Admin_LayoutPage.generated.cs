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
    
    #line 1 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
    using PluginBase;
    
    #line default
    #line hidden
    using SoheilCMS;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/_Admin_LayoutPage.cshtml")]
    public partial class _Areas_Admin_Views_Shared__Admin_LayoutPage_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Shared__Admin_LayoutPage_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 7 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");

WriteLiteral("    ");

            
            #line 8 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
Write(Styles.Render("~/Content/css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
   Write(Styles.Render("~/Content/Menu"));

            
            #line default
            #line hidden
WriteLiteral("\r\n       \r\n</head>\r\n<body>\r\n    <div>\r\n        <div");

WriteLiteral(" class=\"container-fulid\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                    <header");

WriteLiteral(" id=\"header\"");

WriteLiteral("></header>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-xs-2 col-md-2 col-md-push-10\"");

WriteLiteral(">\r\n                    <nav >\r\n");

            
            #line 21 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                           Html.RenderAction("Menu","Home",new {Area="Admin"}); 
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </nav>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-xs-10 col-md-10 col-md-pull-2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"contentBody\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-xs-12 col-md-12 \"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                                 if (Model != null && (Model is BaseViewModel))
                                {
                                    if (Model.State != ActionState.None)
                                    {
                                        if (Model.State == ActionState.Success)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <div");

WriteLiteral(" class=\"alert alert-success text-center\"");

WriteLiteral(">");

            
            #line 34 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                                                                                    Write(Model.Message);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 35 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <div");

WriteLiteral(" class=\"alert alert-Error text-center\"");

WriteLiteral(">");

            
            #line 38 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                                                                                  Write(Model.Message);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 39 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                                        }
                                    }
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </div>\r\n");

WriteLiteral("                            ");

            
            #line 43 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
                       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                <" +
"/div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");

WriteLiteral("    ");

            
            #line 53 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 54 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
Write(Scripts.Render("~/bundles/Menu"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 55 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
Write(Scripts.Render("~/bundles/Admin"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 56 "..\..\Areas\Admin\Views\Shared\_Admin_LayoutPage.cshtml"
   Write(RenderSection("script", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n</body>\r\n</html>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
