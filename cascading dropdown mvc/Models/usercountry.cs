using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cascading_dropdown_mvc.Models
{
    public class usercountry
    {
        public int countryid { get; set; }
        public int stateid { get; set; }
        public int cityid { get; set; }

        public string name { get; set; }

        public SelectList countylist { get; set; }
        public SelectList statelist { get; set; }
        public SelectList citylist { get; set; }
    }
    public class ddl
    {
        public int id { get;set; }
        public string name { get; set; }
    }
}