using System.Collections.Generic;
using LibraryOtomation.Entities.Abtract;

namespace LibraryOtomation.Entities.Concrete
{
    public class Sinif: IEntity
    {
        public int Id { get; set; }
        public string OkulTuru { get; set; }
        public string Sinifi { get; set; }
        public string Sube { get; set; }
        public string Bolumu { get; set; }
        public string Aciklama { get; set; }

        public virtual ICollection<Uye> Uyeler { get; set; }
    }
}