using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using CMS.CustomTables;

namespace api.Controller
{
    public class YysController : ApiController
    {
        public string Get()
        {

            string name = CustomTableItemProvider.GetItems("bjm.apiCrud").FirstOrDefault().GetStringValue("apiName", "");
            return name;

        }

        public List<string> Get(int a)
        {
            List<string> stringList = new List<string>() ;//这里必须这样声明
            var TableItems = CustomTableItemProvider.GetItems("bjm.apiCrud");
            foreach (var item in TableItems)
            {
                if (item.GetStringValue("apiName", "") != null)
                {
                    stringList.Add(item.GetStringValue("apiName", ""));
                }
            }
            return stringList;
        }

    }
}