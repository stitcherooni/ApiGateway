using System;
using System.Collections.Generic;

namespace Models;

public partial class TblFile
{
    public int FileId { get; set; }

    public string FileName { get; set;}

    public string FileDescription { get; set; }

    public TblFileType FileType { get; set; }

    public bool FileMeetingMinutes { get; set; }

    public bool FileAttachToOrder { get; set; }

    public TblSchool School { get; set; }

    public bool FileDeleted { get; set; }

    public TblCustomer FileCreatedBy { get; set; }

    public DateTime FileCreatedDate { get; set; }

    public TblCustomer FileUpdatedBy { get; set; }

    public DateTime? FileUpdatedDate { get; set; }

    public List<TblEventFile> EventFile { get; set; }
}
