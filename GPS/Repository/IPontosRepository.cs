using GPS.Models;

namespace GPS.Repository {
    public interface IPontosRepository {

        Task<IEnumerable<PontosInteresse>> GetAll();
        Task<PontosInteresse> Post(PontosInteresse dto);

    }
}
