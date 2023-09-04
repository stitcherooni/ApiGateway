using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBusinessDirectory
{
    public int BusinessDirectoryId { get; set; }

    public TblBusinessDirectoryCategory BusinessDirectoryCategory { get; set; }

    public string BusinessDirectoryName { get; set;}

    public string BusinessDirectoryDescription { get; set; }

    public string BusinessDirectoryTelephone { get; set; }

    public string BusinessDirectoryEmail { get; set; }

    public string BusinessDirectoryLogo { get; set; }

    public string BusinessDirectoryUrl { get; set; }

    public string BusinessDirectoryFacebook { get; set; }

    public string BusinessDirectoryTwitter { get; set; }

    public string BusinessDirectoryInstagram { get; set; }

    public string BusinessDirectoryPinterest { get; set; }

    public DateTime? BusinessDirectoryStartDate { get; set; }

    public DateTime? BusinessDirectoryEndDate { get; set; }

    public TblSchool School { get; set; }

    public bool BusinessDirectoryDeleted { get; set; }

    public TblCustomer BusinessDirectoryCreatedBy { get; set; }

    public DateTime BusinessDirectoryCreatedByDate { get; set; }

    public TblCustomer BusinessDirectoryUpdatedBy { get; set; }

    public DateTime? BusinessDirectoryUpdatedDate { get; set; }
}
