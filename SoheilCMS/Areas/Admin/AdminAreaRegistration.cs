﻿using System.Web.Mvc;

namespace SoheilCMS.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            
            context.MapRoute(
                "Admin_Pagger",
                "Admin/{controller}/{action}/{page}",
                new { controller = "home", action = "Index", page = UrlParameter.Optional },
                namespaces: new[] { string.Format("{0}.Controllers", this.GetType().Namespace) }
            );

            context.MapRoute(
               "Admin_default",
               "Admin/{controller}/{action}/{id}",
               new { controller = "home", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { string.Format("{0}.Controllers", this.GetType().Namespace) }
           );

        }
    }
}