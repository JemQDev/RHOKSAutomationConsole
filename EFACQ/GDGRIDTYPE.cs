﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// This reference table has a DLO of 0 and cannot be edited. 
/// </summary>
public partial class GDGRIDTYPE
{
    public string GRIDTYPE { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<GDCOORDINATESYSTEM> GDCOORDINATESYSTEM { get; set; } = new List<GDCOORDINATESYSTEM>();

    public virtual ICollection<GRID> GRID { get; set; } = new List<GRID>();
}