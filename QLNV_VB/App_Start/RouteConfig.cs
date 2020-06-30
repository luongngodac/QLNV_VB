﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QLNV_VB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Action",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "GioiThieu", action = "GioiThieu", id = UrlParameter.Optional }
            );
        }
    }
}
