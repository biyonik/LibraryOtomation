using LibraryOtomation.Entities.Abtract;

namespace LibraryOtomation.Entities.Concrete
{
    public class Tanim: IEntity
    {
        public int Id { get; set; }
        public string Tanimi { get; set; }
        public string Aciklama { get; set; }
    }
}