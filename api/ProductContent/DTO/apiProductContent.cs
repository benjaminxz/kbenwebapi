using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.ProductContent.DTO
{
    public class apiProductContent
    {
        public int OrderNumber { get; set; }
        public bool IsPicture { get; set; }
        public string ContentTextd { get; set; }
        public string ContentPicture { get; set; }
    }
}
