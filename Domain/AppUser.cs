using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Bio { get; set; }
        public Personality Personality { get; set; }
        public ICollection<TestResult> TestResults { get; set; }
    }
}