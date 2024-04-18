using Microsoft.EntityFrameworkCore;

namespace CP2___MVC.Data {
public class DataContext : DbContext
{

    public DataContext(DbContextOptions<DataContext> options) : base(options)

    {
    }

    public DbSet<User> MVC_Usuarios { get; set; }

}
}

