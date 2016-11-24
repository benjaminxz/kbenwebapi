using CMS.DataEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using api.CMS_MvcModule;
using CMS;


[assembly: RegisterModule(typeof(CMS_MvcModule))]

namespace api.CMS_MvcModule
{
    public class CMS_MvcModule:Module
    {
        public CMS_MvcModule()
            : base(new CMS_MvcModuleMetadata())
        {
        }
        protected override void OnInit()
        {
            base.OnInit();

            //AuthenticationConfig.ConfigureGlobal(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configuration.Routes.MapHttpRoute("api", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            GlobalConfiguration.Configuration.Formatters.Insert(0, new JsonpMediaTypeFormatter());
            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
