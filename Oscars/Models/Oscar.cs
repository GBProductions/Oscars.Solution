namespace Oscars.Models
{
    public class Oscar
    {
        public int OscarId { get; set; }
        public string Category { get; set; }
        public string Nominee { get; set; }
        public int Year { get; set; }
        public bool Win { get; set; }
    }
}