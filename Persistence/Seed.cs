using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
            var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName = "Bob",
                        UserName = "bob",
                        Email = "bob@test.com"
                    },
                    new AppUser
                    {
                        DisplayName = "Jane",
                        UserName = "jane",
                        Email = "jane@test.com"
                    },
                    new AppUser
                    {
                        DisplayName = "Tom",
                        UserName = "tom",
                        Email = "tom@test.com"
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

            if(context.Questions.Any()) return;

            var questions = new List<Question> 
            {
                new Question 
                {
                    Content = "sdfs",
                    Index = 1
                },

                new Question 
                {
                    Content = "dcsafdsfrvsde",
                    Index = 2
                },
            };

            await context.Questions.AddRangeAsync(questions);
            await context.SaveChangesAsync();
        }
    }
}