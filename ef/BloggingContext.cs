using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ef.Model;

namespace ef
{
    public partial class BloggingContext : DbContext
    {
        public BloggingContext() : base("name=BloggingContext")
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
