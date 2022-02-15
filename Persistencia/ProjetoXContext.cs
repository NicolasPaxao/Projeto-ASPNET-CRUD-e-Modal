using Microsoft.EntityFrameworkCore;
using ProjetoTreino0702.Models;

namespace ProjetoTreino0702.Persistencia
{
    public class ProjetoXContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public ProjetoXContext(DbContextOptions op):base(op)
        {

        }
    }
}
