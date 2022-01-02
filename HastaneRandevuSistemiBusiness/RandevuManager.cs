using HastaneRandevuSistemiDataAccess;
using HastaneRandevuSistemiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiBusiness
{
   public  class RandevuManager
    {

        //Global alan
        MyContext myDBContext = new MyContext();

        public List<Randevu> DoktorunRandevulariniTariheGoreGetir(Doktor dr, DateTime trh)
        {
            try
            {
                List<Randevu> rndList = new List<Randevu>();
                List<Randevu> returnList = new List<Randevu>();

                rndList = myDBContext.Randevular.Where(x => x.DoktorId == dr.DoktorId).ToList();
                //burada foreach kullanmadık Çünkü foreach döngüsünde koleksiyon bozulamaz. Oysa biz burada tarihi eşleşmeyen randevuları listemizden sileceğiz
                foreach (Randevu item in rndList)
                {
                    if (item.RandevuTarihi.ToShortDateString()
                        == trh.ToShortDateString())
                    {
                        returnList.Add(item);
                    }
                }

                return returnList;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public bool HastaninSecilenTarihveSaatteRandevusuVarMi(Hasta hasta, DateTime trh)
        {
            try
            {
                bool sonuc = false;

                var liste = myDBContext.Randevular.Where(x => x.HastaId == hasta.HastaId
                && x.RandevuTarihi == trh).ToList();

                sonuc = liste.Count > 0 ? true : false;

                return sonuc;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool RandevuyuAl(Randevu rnd)
        {
            try
            {
                myDBContext.Randevular.Add(rnd);
                if (myDBContext.SaveChanges() > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public RandevuViewModel RandevuyuViewModeleAktar(Randevu rnd)
        {
            try
            {
                RandevuViewModel rndView = new RandevuViewModel()
                {
                    RandevuId = rnd.Id,
                    DoktorId = rnd.DoktorId,
                    HastaId = rnd.HastaId,
                    RandevuTarihi = rnd.RandevuTarihi
                };

                Hasta hst = myDBContext.Hastalar.FirstOrDefault(x => x.HastaId == rnd.HastaId);
                rndView.HastaAdSoyad = hst?.HastaAdi + " " + hst?.HastaSoyadi;

                Doktor dr = myDBContext.Doktorlar.FirstOrDefault(x => x.DoktorId == rnd.DoktorId);
                rndView.DoktorAdSoyad = dr?.DoktorAdi + " " + dr?.DoktorSoyadi;
                // Servis
                rndView.Servis = EnumManager.BransiTurkceStringOlarakVer(rnd.Doktor.Brans);

                return rndView;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
