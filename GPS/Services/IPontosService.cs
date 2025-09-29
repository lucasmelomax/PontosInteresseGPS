using GPS.DTOs;

namespace GPS.Services {
    public interface IPontosService {
        Task<IEnumerable<PontosInteresseDTO>> GetAll();
        Task<PontosInteresseDTO> Post(PontosInteresseDTO dto);
        Task<IEnumerable<PontosInteresseDTO>> PontosProximos(double x, double y, double dist);
    }
}
