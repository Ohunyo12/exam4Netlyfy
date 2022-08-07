using System.ComponentModel.DataAnnotations;

namespace smartwallet1.web.Data.Entities
{
    public class Country: BaseEntity <Guid>
    {
        
        [Required]
      [MaxLength(200)]
        public string Names { get; set; }
        [Required]
        [MaxLength(5)]
        public string IsoCode { get; set; }
        [Required]
        [MaxLength(5)]
        public string CallCode { get; set; }


    }
}
