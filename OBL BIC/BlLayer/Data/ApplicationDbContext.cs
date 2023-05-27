using Microsoft.EntityFrameworkCore;
//using OBL.BIC.Models;
//using OBL.BIC.Models;
namespace OBL.BIC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //public DbSet<AccBengalInsuranceTransactionLog> AccEwuTransactionLogs { get; set; }


    }
}
