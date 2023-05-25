using System;
using System.Collections.Generic;

namespace Models;

public partial class TblFile
{
    public int FileId { get; set; }

    public string FileName { get; set;}

    public string FileDescription { get; set; }

    public int FileTypeId { get; set; }

    public bool FileMeetingMinutes { get; set; }

    public bool FileAttachToOrder { get; set; }

    public int SchoolId { get; set; }

    public bool FileDeleted { get; set; }

    public int FileCreatedBy { get; set; }

    public DateTime FileCreatedDate { get; set; }

    public int? FileUpdatedBy { get; set; }

    public DateTime? FileUpdatedDate { get; set; }
}
