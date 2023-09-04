using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventProduct
{
    public int EventProductId { get; set; }

    public TblEvent Event { get; set; }

    public TblProduct Product { get; set; }
}
