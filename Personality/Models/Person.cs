using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Personality.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string LinkedInUrl { get; set; }
        public string GithubUrl { get; set; }
        public string XUrl { get; set; }
        public string SelfDescription { get; set; }
        public int Age { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public string Gender { get; set; }
        public string? Address { get; set; }

        public string? City { get; set; }
        public string? Country { get; set; }
        public string PhotoUrl { get; set; }

        public List<MyService> MyServices { get; set; }


    }
}
