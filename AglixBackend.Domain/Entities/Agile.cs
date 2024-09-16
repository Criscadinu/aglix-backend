namespace AglixBackend.Domain.Entities
{
    public class Agile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }    
        public ICollection<AgileImplementation> Implementations { get; set; } = new List<AgileImplementation>();
    }
}
