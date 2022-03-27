using System;

namespace Reiseziele
{
    public class ReiseZiel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ReiseZiel(string name, string description)
        {
            var rand = new Random();
            Id = rand.Next(101);
            Name = name;    
            Description = description;
        }
    }
}
