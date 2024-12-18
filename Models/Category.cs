﻿using System;
using System.Collections.Generic;

namespace werver.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsPublished { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
