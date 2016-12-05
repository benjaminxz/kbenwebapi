using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using api.ProductContent.DTO;
using CMS.Base;
using CMS.CustomTables;
using CMS.Helpers;

namespace api.Content.Controllers
{
    public class ProductContentController : ApiController
    {
        public List<apiProductContent> Get(string productGuid)
        {
            Guid proGuid = new Guid(productGuid);//convert string to Guid
            List<apiProductContent> stringList = new List<apiProductContent>();//这里必须这样声明
            var TableItems = CustomTableItemProvider.GetItems("bjm.apiProductContent").WhereEquals("ProductGuid", proGuid).OrderBy("OrderNumber");//DESC 
            if (TableItems.HasResults())
            {
                foreach (var item in TableItems)
                {

                    var apiProductItem = new apiProductContent
                    {
                        OrderNumber = item.GetIntegerValue("OrderNumber", 0),
                        IsPicture = item.GetBooleanValue("IsPicture", false),
                        ContentTextd = item.GetStringValue("ContentText", ""),
                        ContentPicture = URLHelper.GetAbsoluteUrl(item.GetStringValue("ContentPicture", ""))
                    };
                    stringList.Add(apiProductItem);

                }

            }
            return stringList;
        }
    }
}
