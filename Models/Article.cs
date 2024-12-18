using System;
using System.Collections.Generic;

namespace werver.Models;

public partial class Article
{
    public int ArticleId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int? CategoryId { get; set; }

    public int? AuthorId { get; set; }

    public bool? IsPublished { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
