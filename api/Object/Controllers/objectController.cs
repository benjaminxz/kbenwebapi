using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using api.Object.DTO;
using CMS.CustomTables;

namespace api.Object.Controllers
{
    public class ObjectController : ApiController
    {
        public List<apiCrud> Get()
        {

            //string name = CustomTableItemProvider.GetItems("bjm.apiCrud").FirstOrDefault().GetStringValue("apiName", "");
            //return name;
            List<apiCrud> stringList = new List<apiCrud>();//这里必须这样声明
            var TableItems = CustomTableItemProvider.GetItems("bjm.apiCrud");
            foreach (var item in TableItems)
            {
                if (item.GetStringValue("apiName", "") != null)
                {
                    var apiCrudItem = new apiCrud();
                    apiCrudItem.apiCrudID = item.ItemID;
                    apiCrudItem.apiName = item.GetStringValue("apiName", "");
                    stringList.Add(apiCrudItem);
                }
            }
            return stringList;

        }

        public string Get(int id)
        {
            string name = CustomTableItemProvider.GetItems("bjm.apiCrud").FirstOrDefault().GetStringValue("apiName", "");
            return name;
            //List<string> stringList = new List<string>();//这里必须这样声明
            //var TableItems = CustomTableItemProvider.GetItems("bjm.apiCrud");
            //foreach (var item in TableItems)
            //{
            //    if (item.GetStringValue("apiName", "") != null)
            //    {
            //        stringList.Add(item.GetStringValue("apiName", ""));
            //    }
            //}
            //return stringList;
        }

        [HttpPost]
        public string SaveData(dynamic obj)
        {
            string strName = Convert.ToString(obj.NAME);
            if (!string.IsNullOrEmpty(strName))
            {
                var newApiCrudItem = new CustomTableItem("bjm.apiCrud");
                newApiCrudItem.SetValue("apiName", strName);
                newApiCrudItem.Insert();
                return "save " + strName + " success";
            }
            else
            {
                return "not success:you insert a null value.";
            }

        }
    }
}
