using Bookshelf35.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf35.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Author>().HasData(
           new Author()
           {
               Id = 1,
               Name = "CS Lewis",
               ApplicationUserId = "9e960334-0e68-4a6f-b05a-438250fb5564"
           },
           new Author()
           {
               Id = 2,
               Name = "Rahl Dohl",
               ApplicationUserId = "9e960334-0e68-4a6f-b05a-438250fb5564"
           },
           new Author()
           {
               Id = 3,
               Name = "This Guy",
               ApplicationUserId = "aee7d25a-cdf7-45a0-8803-4a0d6979b334"
           }
           );

            modelBuilder.Entity<Book>().HasData(
             new Book()
             {
                 Id = 1,
                 Title = "Lion and some Wardrobe",
                 AuthorId = 1,
                 ApplicationUserId = "9e960334-0e68-4a6f-b05a-438250fb5564",
                 Rating = 5,
                 YearPublished = 1990,
                 Genre = "Fantasy"
             },
                 new Book()
                 {
                     Id = 2,
                     Title = "The Twits",
                     AuthorId = 2,
                     ApplicationUserId = "9e960334-0e68-4a6f-b05a-438250fb5564",
                     Rating = 4,
                     YearPublished = 1992,
                     Genre = "Humor"
                 },
                     new Book()
                     {
                         Id = 3,
                         Title = "This Book",
                         AuthorId = 3,
                         ApplicationUserId = "aee7d25a-cdf7-45a0-8803-4a0d6979b334",
                         Rating = 3,
                         YearPublished = 1996,
                         Genre = "Informative"
                     }
            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                {
                    Id = 1,
                    BookId = 1,
                    ApplicationUserId = "9e960334-0e68-4a6f-b05a-438250fb5564",
                    Text = "It has a lion. 5 Stars."
                },
                 new Comment()
                 {
                     Id = 2,
                     BookId = 1,
                     ApplicationUserId = "aee7d25a-cdf7-45a0-8803-4a0d6979b334",
                     Text = "Even thought I'm an athiest, I love this book."
                 },
                  new Comment()
                  {
                      Id = 3,
                      BookId = 2,
                      ApplicationUserId = "9e960334-0e68-4a6f-b05a-438250fb5564",
                      Text = "This is a fun guide in being a horrible person."
                  },
                 new Comment()
                 {
                     Id = 4,
                     BookId = 2,
                     ApplicationUserId = "aee7d25a-cdf7-45a0-8803-4a0d6979b334",
                     Text = "As a twit, I'm offended by this book."
                 },
                  new Comment()
                  {
                      Id = 5,
                      BookId = 3,
                      ApplicationUserId = "9e960334-0e68-4a6f-b05a-438250fb5564",
                      Text = "I LOVE This Guy's work!"
                  },
                 new Comment()
                 {
                     Id = 6,
                     BookId = 3,
                     ApplicationUserId = "aee7d25a-cdf7-45a0-8803-4a0d6979b334",
                     Text = "Literally who?"
                 }
            );
        }
    }
}