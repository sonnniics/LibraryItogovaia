using Library.Model;
using Microsoft.EntityFrameworkCore;

namespace Library.DataBase;

public class Context : DbContext
{
    public DbSet<Autor> Autors { get; set; }
    public DbSet<Janr> Janrs { get; set; }
    public DbSet<Kniga> Knigas { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Vidacha> Vidachas { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=UrbanMuseModels.db"); 
    }
}