using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBusinessDirectoryCategory
{
    public int BusinessDirectoryCategoryId { get; set; }

    public string BusinessDirectoryCategoryName { get; set;}

    public string BusinessDirectoryCategoryIcon { get; set;}

    public TblSchool School { get; set; }

    public bool BusinessDirectoryCategoryDeleted { get; set; }

    public TblCustomer BusinessDirectoryCategoryCreatedBy { get; set; }

    public DateTime BusinessDirectoryCategoryCreatedByDate { get; set; }

    public TblCustomer BusinessDirectoryCategoryUpdatedBy { get; set; }

    public DateTime? BusinessDirectoryCategoryUpdatedDate { get; set; }
}
