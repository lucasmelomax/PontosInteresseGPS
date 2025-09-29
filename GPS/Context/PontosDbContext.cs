
using GPS.Models;
using Microsoft.EntityFrameworkCore;

namespace GPS.Context {
        public class PontosDbContext : DbContext {
            public PontosDbContext(DbContextOptions<PontosDbContext> options)
                : base(options) {
            }

            public DbSet<PontosInteresse> PontosInteresse { get; set; }
        }

    }
