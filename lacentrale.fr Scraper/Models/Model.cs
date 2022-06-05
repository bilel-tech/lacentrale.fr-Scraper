namespace lacentrale.fr_Scraper.Models
{
    public class Model
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return Name?.Equals(((Model)obj)?.Name) ?? false;
        }
    }
}
