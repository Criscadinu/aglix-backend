namespace AglixBackend.Domain.Entities
{
    internal class Agile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<AgileImplementation> Implementations { get; set; }
    }
}
