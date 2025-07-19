using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Register_Login_Test.Models
{
    public class Appdbcontext : IdentityDbContext<User>
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options):base(options)
        {
            
        }
        public DbSet<User> users { get; set; }
    }
}
