using Newtonsoft.Json;
using PeopleSearcher.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace PeopleSearcher
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            GlobalConfiguration.Configuration.Formatters
                   .JsonFormatter.SerializerSettings.Re‌​ferenceLoopHandling
                   = ReferenceLoopHandling.Ignore;

            //Database.SetInitializer<PeopleSearcherContext>(new DropCreateDatabaseIfModelChanges<PeopleSearcherContext>());
        }
    }
}
