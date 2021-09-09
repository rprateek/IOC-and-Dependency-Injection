using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace IEnumerable
{
    // Customer  context is inheriting DBcontext     
    public class CustomerContext:DbContext
    {
        // logging this to see what is going on in the console
        private readonly ILoggerFactory loggerFactory
            = LoggerFactory.Create(conf => conf.AddConsole());
              

        private readonly string _connStr;
        public CustomerContext(string connStr)
        {
            _connStr = connStr;
            _connStr = connStr;
        }
        
        // Creating simple dbset of Customers 
        public DbSet<Customer> Customers { get; set; }

        //passing the connection String by overriding OnCofiguring To configure the connection in DBContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //initialise the logger and connection to the database. 
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlServer(_connStr);
        }
    }
}
