using System.Collections.Generic;

namespace lacentrale.fr_Scraper.Models
{
    public class Make
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Model> Models { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Make))
                return Name.Equals(((Make)obj).Name);
            return base.Equals(obj);
        }
    }
}
