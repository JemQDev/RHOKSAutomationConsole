﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2024;

public partial class PlodHole
{
    public int PlodID { get; set; }

    public int HoleLine { get; set; }

    public string HoleNumber { get; set; }

    public string HolePurpose { get; set; }

    public decimal? Dip { get; set; }

    public decimal? Azi { get; set; }

    public decimal? DrillStart { get; set; }

    public decimal? DrillEnd { get; set; }

    public decimal? DrillTotal { get; set; }

    public bool? HoleComplete { get; set; }

    public virtual PlodHeader Plod { get; set; }
}