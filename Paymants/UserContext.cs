using System.Data.Entity;

namespace Paymants
{
    class UserContext : DbContext
    {
        public UserContext()
            :base("DBConnection")
        { }
          
        public DbSet<User> Users { get; set; }
    }
}