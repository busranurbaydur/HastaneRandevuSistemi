using HastaneRandevuSistemiEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiDataAccess
{
    public class MyContext:DbContext
    {
        public MyContext()
            :base("name=MyCon")
        {

        }

        public virtual DbSet<Doktor> Doktorlar { get; set; }
        public virtual DbSet<Hasta> Hastalar { get; set; }
        public virtual DbSet<Randevu> Randevular { get; set; }

    }
}
