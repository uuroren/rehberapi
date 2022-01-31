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
        public string email { get; set; }
        public string telefon { get; set; }
        public string konum { get; set; }
    }
}
