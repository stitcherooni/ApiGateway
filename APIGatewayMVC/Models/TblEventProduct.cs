using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventProduct
{
    public int EventProductId { get; set; }

    public int EventId { get; set; }

    public int ProductId { get; set; }
}
