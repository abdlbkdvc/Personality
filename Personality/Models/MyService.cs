namespace Personality.Models
{
    public class MyService
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
     
        public List<Person> Person { get; set; }
    }
}
