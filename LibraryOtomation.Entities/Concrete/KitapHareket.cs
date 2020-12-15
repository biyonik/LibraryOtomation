using System;
using LibraryOtomation.Entities.Abtract;

namespace LibraryOtomation.Entities.Concrete
{
    public class KitapHareket: IEntity
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public int VerilisSuresi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public int DegerlendirmeKondisyon { get; set; }
        public int DegerlendirmeZamanlama { get; set; }
        public int DegerlendirmeYetkili { get; set; }
        public string Aciklama { get; set; }

        public virtual Kitap Kitap { get; set; }
        public virtual Uye Uye { get; set; }
    }
}