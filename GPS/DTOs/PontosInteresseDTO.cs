using System.ComponentModel.DataAnnotations;

namespace GPS.DTOs {
    public class PontosInteresseDTO {
        public string? Nome { get; set; }
        public double x { get; set; }
        public double y { get; set; }
    }
}
