﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class VersionInfo
{
    public long Version { get; set; }

    public DateTime? AppliedOn { get; set; }

    public string Description { get; set; }
}
