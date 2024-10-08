﻿using AglixBackend.Domain.Entities;

public class AgileImplementation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public int AgileId { get; set; }
    public Agile? Agile { get; set; }

    public ICollection<AgileImplementationElement> Elements { get; set; } = new List<AgileImplementationElement>();
}
