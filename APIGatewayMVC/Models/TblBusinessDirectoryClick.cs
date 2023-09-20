using System;

namespace Models;

public partial class TblBusinessDirectoryClick
{
    public int BusinessDirectoryClickId { get; set; }

    public int BusinessDirectoryId { get; set; }

    public int? CustomerId { get; set; }

    public int SchoolId { get; set; }

    public string BusinessDirectoryClickFrom { get; set; }

    public string BusinessDirectoryClickPage { get; set; }

    public string BusinessDirectoryClickUserAgent { get; set; }

    public DateTime BusinessDirectoryClickDateTime { get; set; }

    public TblBusinessDirectory BusinessDirectory { get; set; }
    public TblCustomer Customer { get; set; }
    public TblSchool School { get; set; }
}
