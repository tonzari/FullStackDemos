using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Demo_03_API_With_EFC.Models;

public partial class Menu
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
