
using GPS.Context;
using GPS.Repository;

namespace GPS.UnitOfWork {
    public class UUnitOfWork : IUnitOfWork {

        private readonly PontosDbContext _context;
        public IPontosRepository PontosRepository {  get;}
        public PontosDbContext Context { get; }

        public UUnitOfWork(PontosDbContext context, IPontosRepository pontosRepository) {
            _context = context;
            PontosRepository = pontosRepository;
        }
        public async Task<bool> CommitAsync() {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose() {
            _context.Dispose();
        }
    }
}
