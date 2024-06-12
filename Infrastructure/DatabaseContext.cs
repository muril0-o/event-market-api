using Microsoft.EntityFrameworkCore;
using Model.User;

namespace Infrastructure
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            var connectionString = config["ConnectionStrings:DefaultConnection"];
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 36)); // Substitua pela versão correta do seu servidor MySQL

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}