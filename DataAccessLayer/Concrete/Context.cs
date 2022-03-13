using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer.Concrete;
namespace DataAccessLayer.Concrete
{
    public class Context:DbContext  //DbContext sınıfından kalıtımla tüm özellikleri al
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
