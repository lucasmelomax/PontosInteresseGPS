using GPS.Repository;

namespace GPS.UnitOfWork {
    public interface IUnitOfWork {

        IPontosRepository  PontosRepository { get; }
        Task<bool> CommitAsync();
    }
}
