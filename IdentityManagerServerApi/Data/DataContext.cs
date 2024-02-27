using Microsoft.EntityFrameworkCore;

namespace IdentityManagerServerApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
    }
}
