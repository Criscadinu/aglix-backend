namespace AglixBackend.Domain.Entities
{
    public class AgileImplementationElement
    {
        public int Id { get; set; }
        public string Name { get; set; } // e.g., Standups, Retrospectives
        public string Type { get; set; } // e.g., Ceremony, Tool, Event
        public string Description { get; set; }

        public int AgileImplementationId { get; set; }
        public AgileImplementation AgileImplementation { get; set; }
    }
}
