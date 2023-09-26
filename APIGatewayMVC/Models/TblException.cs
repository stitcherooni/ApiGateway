using System;
using System.Collections.Generic;

namespace Models;

public partial class TblException
{
    public int ExceptionId { get; set; }

    public string ExceptionEvent { get; set; }

    public string ExceptionMessage { get; set; }

    public string ExceptionDetail { get; set; }

    public string ExceptionStackTrace { get; set; }

    public string ExceptionTagContext { get; set; }

    public string ExceptionForm { get; set; }

    public string ExceptionExtendedInfo { get; set; }

    public string ExceptionApplication { get; set; }

    public string ExceptionIpaddress { get; set; }

    public string ExceptionQueryString { get; set; }

    public string ExceptionMachineName { get; set; }

    public int? ExceptionTypeId { get; set; }

    public DateTime ExceptionCreatedDate { get; set; }
}
