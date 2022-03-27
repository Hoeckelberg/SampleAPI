namespace Reiseziele
{
    public class PostReiseZielDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public PostReiseZielDTO(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
