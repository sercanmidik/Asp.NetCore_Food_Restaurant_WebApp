using EntityLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class FoodContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("data source=SERCAN;initial catalog=MyFood;user id=sa;password=wv2l5ct7m22056;");
            optionsBuilder.UseSqlServer(@"data source=.\MSSQLSERVER2019;initial catalog=MyFood;user id=sercanmidik;password=Wv2l5ct7m22056;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TeamFriend> TeamFriends { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
    }
}
