using System.ComponentModel.DataAnnotations;

namespace rehberapi.models
{
    public class rehber
    {
        [Key]
        public int UUId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string firma { get; set; }
        public string iletisim { get; set; }
        public string konum { get; set; }
    }
}
