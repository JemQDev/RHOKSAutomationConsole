﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2024;

public partial class CompanyTypes
{
    public string CompanyTypeID { get; set; }

    public string CompanyType { get; set; }

    public virtual ICollection<Companies> Companies { get; set; } = new List<Companies>();

    public virtual ICollection<RangerDrillRigs> RangerDrillRigs { get; set; } = new List<RangerDrillRigs>();
}