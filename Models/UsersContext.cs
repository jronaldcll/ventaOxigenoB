using Microsoft.EntityFrameworkCore;  

namespace ventaOxigenoB.Models 
{     
  public class UsersContext : DbContext     
    {         
      public UsersContext(DbContextOptions<UsersContext> options)                            : base(options)         
      {         
      }       
      public DbSet<Users> Users { get; set; }     
    
    } 
}