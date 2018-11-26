
using Microsoft.EntityFrameworkCore;

namespace StoreApi.Models
{
  public class StoreContext : DbContext
  {
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {

    }

    // Add the Entities Info
    public DbSet<User> Users { get; set; }
  }

}
