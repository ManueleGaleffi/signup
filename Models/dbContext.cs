using Microsoft.EntityFrameworkCore;

class dbContext : DbContext
{
    private readonly DbContextOptions?_options;

    //public dbContext(){}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");
    public DbSet<Prenotazione> Prenotazioni { get; set; }
    public DbSet<Prodotto> Prodotti { get; set; }
    }