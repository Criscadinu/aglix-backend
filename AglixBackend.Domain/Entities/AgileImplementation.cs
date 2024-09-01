namespace AglixBackend.Domain.Entities
{
    public class AgileImplementation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int AgileId { get; set; }
        public Agile Agile { get; set; }

        public ICollection<AgileElement> Elements { get; set; }
    }
}
