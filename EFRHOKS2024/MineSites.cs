﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2024;

public partial class MineSites
{
    public string MineSiteID { get; set; }

    public string MineSiteName { get; set; }

    public string MineSiteCompany { get; set; }

    public virtual Companies MineSiteCompanyNavigation { get; set; }

    public virtual ICollection<PlodHeader> PlodHeader { get; set; } = new List<PlodHeader>();
}