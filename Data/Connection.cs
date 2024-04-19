using Microsoft.EntityFrameworkCore;

namespace Data;

    public class Connection : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        string path = $@"Data Source=(localdb)\MSSQLLocalDB;
                         Initial Catalog=db.ServerMails;
                         Integrated Security=True;
                         Trust Server Certificate=False;";
            optionsBuilder.UseSqlServer(path);
        }
    }
