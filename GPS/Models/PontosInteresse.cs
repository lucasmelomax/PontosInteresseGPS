using System.ComponentModel.DataAnnotations;

namespace GPS.Models {
    public class PontosInteresse {
        public int PontosInteresseId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Required]
        public double x { get; set; }

        [Required]
        public double y { get; set; }
    }
}
