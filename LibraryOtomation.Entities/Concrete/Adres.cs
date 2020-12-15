using LibraryOtomation.Entities.Abtract;

namespace LibraryOtomation.Entities.Concrete
{
    public class Adres: IEntity
    {
        public int Id { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adresi { get; set; }
        public string Aciklama { get; set; }
        
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }
    }
}