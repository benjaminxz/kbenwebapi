using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using api.BusinessSearch.DTO;
using CMS.CustomTables;

namespace api.BusinessSearch.Controllers
{
    public class BusinessSearchController:ApiController
    {
        public List<apiBusiness> Get(string searchBusinessName)
        {
            List<apiBusiness> stringList = new List<apiBusiness>();//这里必须这样声明
            var TableItems = CustomTableItemProvider.GetItems("bjm.apiBusiness").WhereContains("BusinessName", searchBusinessName);//DESC WhereLike("BusinessName", searchBusinessName)
            if (TableItems.HasResults())
            {
                foreach (var item in TableItems)
                {

                    var apiBusinessItem = new apiBusiness
                    {
                        ItemId = item.GetIntegerValue("ItemId", 0),
                        BusinessName = item.GetStringValue("BusinessName", ""),
                        BusinessPicture = item.GetStringValue("BusinessPicture", ""),
                    };
                    stringList.Add(apiBusinessItem);

                }

            }
            return stringList;
        }
    }
}
