using System;
using System.Collections.Generic;

namespace Models;

public partial class TblContentHash
{
    public int ContentHashId { get; set; }

    public string ContentHashName { get; set;}

    public string ContentHashValue { get; set;}

    public string ContentHashText { get; set;}

    public DateTime ContentHashCreatedDate { get; set; }

    public List<TblCustomer> CustomerHash { get; set; }
}
