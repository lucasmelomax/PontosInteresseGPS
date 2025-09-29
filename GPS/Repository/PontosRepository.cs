using GPS.Context;
using GPS.Models;
using Microsoft.EntityFrameworkCore;

namespace GPS.Repository {
    public class PontosRepository : IPontosRepository {

        private readonly PontosDbContext _context;

        public PontosRepository(PontosDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<PontosInteresse>> GetAll() {
            return await _context.Set<PontosInteresse>().ToListAsync();
        }

        public async Task<PontosInteresse> Post(PontosInteresse dto) {
            await _context.Set<PontosInteresse>().AddAsync(dto);
            return dto;
        }
    }
}
