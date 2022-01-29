using HastaneRandevuSistemiDataAccess;
using HastaneRandevuSistemiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiBusiness
{
    public class HastaManager
    {
        //global alan

        MyContext myDbContext = new MyContext();

        public List<Hasta> TumHastalariGetir()
        {
            try
            {
                return myDbContext.Hastalar.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Hasta> TCNumarasinaGoreHastayiBul(string tc)
        {
            try
            {
                return myDbContext.Hastalar.Where(x => x.TCNumarasi.StartsWith(tc)||x.TCNumarasi.EndsWith(tc)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool YeniHastaEkle(Hasta hasta)
        {
            try
            {
                myDbContext.Hastalar.Add(hasta);
                myDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
