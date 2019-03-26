// System.Data.SqlClient.dll
// Microsoft.EntityFrameworkCore.SqlServer.dll
// System.Configuration.ConfigurationManager.dll 
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MemoEngine.Models
{
    public partial class MemoEngineContext : DbContext
    {
        public MemoEngineContext()
        {
            // Empty
        }

        public MemoEngineContext(DbContextOptions<MemoEngineContext> options)
            : base(options)
        {
            // 공식과 같은 코드 
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings[
                    "ConnectionString"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString); 
            }
        }

        /// <summary>
        /// Domains 속성
        /// </summary>
        public DbSet<DomainModel> Domains { get; set; }

        /// <summary>
        /// UserProfiles 속성
        /// </summary>
        public DbSet<UserProfileModel> UserProfiles { get; set; }
    }
}
