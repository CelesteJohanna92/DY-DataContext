using EjemploEnClase.Model;
using Microsoft.EntityFrameworkCore;

namespace EjemploEnClase.DataContext
{
    public class DataContextNotrhwind : DbContext
    {
        public DataContextNotrhwind(DbContextOptions<DataContextNotrhwind> options) : base(options)
        { }
            public DbSet<Employees> Employees { get; set; }
        }
    }
