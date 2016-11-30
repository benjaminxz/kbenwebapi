using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using CMS.CustomTables;
using CMS.Helpers;

namespace api.Object.Controllers
{
    public class PictureController: ApiController
    {
        public string Get()
        {

            string name = CustomTableItemProvider.GetItems("bjm.apiBusiness").FirstObject.GetStringValue("Picture", "");

            return URLHelper.GetAbsoluteUrl(name);
        }
    }
}
