using System;
using System.Collections.Generic;

namespace dbContextHelp.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Author { get; set; }

    public string? Publisher { get; set; }

    public string? Isbn { get; set; }

    public decimal? Price { get; set; }

    public int Stock { get; set; }

    public string? Summary { get; set; }

    public virtual ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
}
