﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2020;

public partial class GeoLogDrilling
{
    public string GLD_HoleID { get; set; }

    public DateOnly GLD_Date { get; set; }

    public string GLD_RigId { get; set; }

    public decimal? GLD_StartMetres { get; set; }

    public decimal? GLD_StopMetres { get; set; }

    public string GLD_Geologist { get; set; }

    public virtual Drill_Design GLD_Hole { get; set; }

    public virtual DrillRigs GLD_Rig { get; set; }
}