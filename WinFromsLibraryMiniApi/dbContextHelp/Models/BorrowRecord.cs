using System;
using System.Collections.Generic;

namespace dbContextHelp.Models;

public partial class BorrowRecord
{
    public int RecordId { get; set; }

    public int UserId { get; set; }

    public int BookId { get; set; }

    public DateTime BorrowDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
