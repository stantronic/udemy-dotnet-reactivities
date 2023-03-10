namespace Domain
{
    public class Activity
    {

        // Entity framework requires these properties are all public and get/set-able        
        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Location { get; set; }

    }
}