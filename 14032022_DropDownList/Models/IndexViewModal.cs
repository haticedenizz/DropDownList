using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14032022_DropDownList.Models
{
    public class IndexViewModal
    {
        public int SecilenSehirID { get; set; }
        public int SecilenUlkeID { get; set; }
        public SelectList Sehir { get; set; }
        public SelectList Ulke { get; set; }
    }
}