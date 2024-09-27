namespace AglixBackend.Domain.Entities
{
    public class AgileImplementationElement
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Type { get; set; } 
        public string Description { get; set; }

        public int AgileImplementationId { get; set; }
        public AgileImplementation AgileImplementation { get; set; }
    }
}
