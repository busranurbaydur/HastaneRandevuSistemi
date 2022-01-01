using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiEntities
{
    public class RandevuViewModel
    {
        public int RandevuId { get; set; }
        public int DoktorId { get; set; }
        public Doktor Doktor { get; set; }
        public string DoktorAdSoyad { get; set; }
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }
        public string HastaAdSoyad { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string Servis { get; set; }
    }
}
