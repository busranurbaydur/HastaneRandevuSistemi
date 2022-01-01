using HastaneRandevuSistemiDataAccess;
using HastaneRandevuSistemiEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiBusiness
{
    public class DoktorManager
    {
        MyContext myDbContext = new MyContext();
        public List<Doktor> TumAktifDoktorlariGetir()
        {
            try
            {
                //where ile sadece aktifler çekilecek bunu daha sonra yapacağız..
                return myDbContext.Doktorlar.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool YeniDoktorEkle(Doktor yeniDr)
        {
            try
            {
                //1.yol
                myDbContext.Doktorlar.Add(yeniDr);
                //2.yol
                // myDbContext.Set<Doktor>().Add(yeniDr);

                myDbContext.SaveChanges();

                //çakma
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Doktor> BransaGoreDoktorlariGetir(Branslar brans)
        {
            try
            {
                return myDbContext.Doktorlar.Where(x => x.Brans == brans).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Doktor DoktoruIdyeGoreBul(int id)
        {
            try
            {
                Doktor dr = myDbContext.Doktorlar.FirstOrDefault(x => x.DoktorId == id);
                return dr;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}
