using LibraryOtomation.Entities.Abtract;

namespace LibraryOtomation.Entities.Concrete
{
    public class Barkod: IEntity
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public int Kondisyon { get; set; }
        public string Salon { get; set; }
        public string Dolap { get; set; }
        public string Raf { get; set; }
        public string Sira { get; set; }
        public string Aciklama { get; set; }

        public virtual Kitap Kitap { get; set; }
    }
}