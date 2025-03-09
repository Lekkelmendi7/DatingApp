using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {



     /*   public static void Seed(DataContext context)
        {
            if(!context.Users.Any()){
                context.Users.AddRange(
                    new AppUser{ UserName="LekeKelmendi"},
                    new AppUser{UserName="FilanFisteku2001"}
                );
                context.SaveChanges();  
            }
        }*/
        public DbSet<AppUser> Users{ get; set; }
    }
}