using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBankedWebHook
{
    public int BankedWebHookId { get; set; }

    public int OrderId { get; set; }

    public string BankedWebHookBankedId { get; set;}

    public string BankedWebHookEndToEndId { get; set; }

    public string BankedWebHookEvent { get; set; }

    public string BankedWebHookType { get; set; }

    public string BankedWebHookStatus { get; set; }

    public string BankedWebHookContent { get; set; }

    public DateTime BankedWebHookCreatedDate { get; set; }
    public TblOrder Order { get; set; }
}
