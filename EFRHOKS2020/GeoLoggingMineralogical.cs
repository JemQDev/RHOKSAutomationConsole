﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2020;

public partial class GeoLoggingMineralogical
{
    public long GLM_ID { get; set; }

    public long GLM_GLS_ID { get; set; }

    public string GLM_HOLEID { get; set; }

    public decimal GLM_IntervalFrom { get; set; }

    public decimal GLM_IntervalTo { get; set; }

    public short GLM_RecordNumber { get; set; }

    public string GLM_MetCode { get; set; }

    public int? GLM_MetPercentage { get; set; }

    public decimal? GLM_Hematite { get; set; }

    public decimal? GLM_Geothite { get; set; }

    public decimal? GLM_Manganese { get; set; }

    public decimal? GLM_Carbonate { get; set; }

    public decimal? GLM_Clay { get; set; }

    public decimal? GLM_Quartz { get; set; }

    public decimal? GLM_Sulphide { get; set; }

    public decimal? GLM_Other { get; set; }

    public virtual GeoLoggingSampling GLM_GLS { get; set; }

    public virtual Drill_Design GLM_HOLE { get; set; }

    public virtual MineralogicalCodes GLM_MetCodeNavigation { get; set; }
}