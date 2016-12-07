using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using api.ProductList.DTO;
using CMS.CustomTables;

namespace api.ProductList.Controllers
{
    public class ProductListController : ApiController
    {
        public List<apiProduct> Get(int id)
        {
            List<apiProduct> stringList = new List<apiProduct>();//这里必须这样声明
            var TableItems = CustomTableItemProvider.GetItems("bjm.apiProduct").WhereEquals("BusinessId", id).OrderBy("OrderNumber");//DESC 
            if (TableItems.HasResults())
            {
                foreach (var item in TableItems)
                {

                    var apiProductItem = new apiProduct
                    {
                        OrderNumber = item.GetIntegerValue("OrderNumber", 0),
                        ProductName = item.GetStringValue("ProductName", ""),
                    };
                    stringList.Add(apiProductItem);

                }

            }
            return stringList;
        }
    }
}
