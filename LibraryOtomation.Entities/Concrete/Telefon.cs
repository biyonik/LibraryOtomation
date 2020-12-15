using LibraryOtomation.Entities.Abtract;

namespace LibraryOtomation.Entities.Concrete
{
    public class Telefon: IEntity
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }
        public string Yakinlik { get; set; }
        public string Telefonu { get; set; }
        
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }
    }
}