﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBusinessDirectoryCategory
{
    public int BusinessDirectoryCategoryId { get; set; }

    public string BusinessDirectoryCategoryName { get; set;}

    public string BusinessDirectoryCategoryIcon { get; set;}

    public TblSchool SchoolId { get; set; }

    public bool BusinessDirectoryCategoryDeleted { get; set; }

    public int BusinessDirectoryCategoryCreatedBy { get; set; }

    public DateTime BusinessDirectoryCategoryCreatedByDate { get; set; }

    public int? BusinessDirectoryCategoryUpdatedBy { get; set; }

    public DateTime? BusinessDirectoryCategoryUpdatedDate { get; set; }

    public List<TblBusinessDirectory> BusinessDirectoryCategory { get; set; }

    public TblSchool School { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
