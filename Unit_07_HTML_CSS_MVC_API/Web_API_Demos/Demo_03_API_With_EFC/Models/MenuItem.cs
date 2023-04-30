using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Demo_03_API_With_EFC.Models;

public partial class MenuItem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Category { get; set; } = null!;

    public decimal Price { get; set; }
    [JsonIgnore]
    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();
}
