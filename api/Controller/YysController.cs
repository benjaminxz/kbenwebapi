﻿using System;
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
            
            string name= CustomTableItemProvider.GetItems("bjm.apiCrud").FirstOrDefault().GetStringValue("apiName", "");
            return name;

        }

    }
}