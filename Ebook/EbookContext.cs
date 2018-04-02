using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook
{
    class EbookContext : DbContext
    {
        public EbookContext() : base("Data Source =.\\ebook.db")
        {

        }
    
        public DbSet<User> Users { get; set; }
    }
}
