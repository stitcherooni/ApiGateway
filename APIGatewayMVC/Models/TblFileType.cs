using System;
using System.Collections.Generic;

namespace Models;

public partial class TblFileType
{
    public int FileTypeId { get; set; }

    public string FileTypeName { get; set;}

    public string FileTypeMimeType { get; set;}

    public string FileTypeExtension { get; set;}

    public string FileTypeIcon { get; set; }

    public bool FileTypeDeleted { get; set; }

    public int FileTypeCreatedBy { get; set; }

    public DateTime FileTypeCreatedDate { get; set; }

    public int? FileTypeUpdatedBy { get; set; }

    public DateTime? FileTypeUpdatedDate { get; set; }
}
