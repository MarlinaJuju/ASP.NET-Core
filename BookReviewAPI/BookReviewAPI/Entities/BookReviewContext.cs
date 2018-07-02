using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookReviewAPI.Entities
{
    public class BookReviewContext:DbContext
    {
        public BookReviewContext(DbContextOptions<BookReviewContext> options):base(options)
        {
            //Database.Migrate();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Follower> Followers { get; set; }
    }
    //public class BookReviewContextFactory : IDesignTimeDbContextFactory<BookReviewContext>
    //{
    //    public BookReviewContext CreateDbContext(string[] args)
    //    {
    //        var builder = new DbContextOptionsBuilder<BookReviewContext>();
    //        String connectionString = @"Server=(localdb)\mssqllocaldb;Database=BookReviewDB;Trusted_Connection=True;";
    //        builder.UseSqlServer(connectionString);
    //        return new BookReviewContext(builder.Options);
    //    }
    //}
}
