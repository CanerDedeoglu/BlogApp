using BlogAPP.Entity;
using BlogAPP.Entity.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

namespace BlogAPP.Data.Concrete.EfCore
{
    public class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BlogContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
            }

            if (!context.Tags.Any())
            {
                context.Tags.AddRange(
                    new Tag() { Text = "Web Programlama" },
                    new Tag() { Text = "Backend " },
                    new Tag() { Text = "Fullstack" },
                    new Tag() { Text = "Game" }

                );
                context.SaveChanges();
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User() { UserName = "CanerDedeoglu" },
                    new User() { UserName = "ahmetkaya" }
                );
                context.SaveChanges();
            }
            if (!context.Posts.Any())
            {
                context.Posts.AddRange(
                    new Post()
                    {
                        Title = "Web Programlama",
                        Content = "Web Programlama dersleri işlenecek",
                        Image = "1.jpeg",
                        UserId = 1,
                        isActive = true,
                        Publishedon = DateTime.Now.AddDays(-5),
                        Tags = context.Tags.Take(2).ToList()
                    },
                    new Post()
                    {
                        Title = "Backend Bootcamp",
                        Content = "Backend Bootcamp dersleri işlenecek",
                        Image = "2.jpeg",
                        UserId = 2,
                        isActive = true,
                        Publishedon = DateTime.Now.AddDays(-10),
                        Tags = context.Tags.Take(4).ToList()

                    },
                    new Post()
                    {
                        Title = "Fullstack Bootcamp",
                        Content = "Fullstack Bootcamp dersleri işlenecek",
                        Image = "3.jpeg",
                        UserId = 1,
                        isActive = true,
                        Publishedon = DateTime.Now.AddDays(-15),
                        Tags = context.Tags.Take(3).ToList()
                    }

                );
                context.SaveChanges();
            }

        }


    }
}