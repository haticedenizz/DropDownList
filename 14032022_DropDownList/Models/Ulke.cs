using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _14032022_DropDownList.Models
{
    public class Ulke
    {
        public int UlkeID { get; set; }
        public string UlkeAdi { get; set; }

        public static List<Ulke> UlkeData()
        {
            List<Ulke> liste = new List<Ulke>() 
            { 
            new Ulke{UlkeID=1,UlkeAdi="Türkiye"},
            new Ulke{UlkeID=2,UlkeAdi="Fransa"}
            };
            return liste;
        }
    }
}