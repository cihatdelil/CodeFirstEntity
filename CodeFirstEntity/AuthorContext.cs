using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Emit;

namespace CodeFirstEntity
{
    internal class AuthorContext:DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }

        public DbSet<Customer> customers { get; set; }

        public DbSet<Sales> sales  { get; set; }

        public AuthorContext():base("LibraryContext") 
        {
                
        }
    }
}
