using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBH.HelpfulClasses
{
    public class FilterClass
    {
        public int? Cat_id { get; set; }
        public int? Brand_id { get; set; }
        public int Product_id { get; set; }
        public string SearchKey { get; set; }
        public int? Page_id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}