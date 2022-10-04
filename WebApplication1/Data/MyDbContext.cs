using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace WebApplication1.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options ) : base(options) { }      
            
        
        #region DbSet
            public DbSet<HangHoa> hangHoas { get; set; }
            public DbSet<Loai> Loais { get; set; }
            #endregion    
    }
}
