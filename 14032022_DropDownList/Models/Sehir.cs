using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _14032022_DropDownList.Models
{
    public class Sehir
    {
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
        public int UlkeID { get; set; }

        public static List<Sehir> SehirData()
        {
            List<Sehir> liste = new List<Sehir>()
            {
                new Sehir(){SehirId=1,SehirAdi="İstanbul",UlkeID=1},
                new Sehir()
                {SehirId=2,SehirAdi="İzmir",UlkeID=1 },
                new Sehir()
                {SehirId=3,SehirAdi="Paris",UlkeID=2 },
                new Sehir()
                {SehirId=4,SehirAdi="Lens",UlkeID=2 }
            };
            return liste;
        }
    }
}