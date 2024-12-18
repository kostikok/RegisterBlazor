using System;
using System.Collections.Generic;

namespace werver.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsPublished { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
