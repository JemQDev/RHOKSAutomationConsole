﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2020;

public partial class SURTECH_DETAILS
{
    public DateOnly SD_DATE { get; set; }

    public string SD_VEHICLE { get; set; }

    public decimal? SD_OPENHOLE { get; set; }

    public int? SD_D_OPENHOLE { get; set; }

    public decimal? SD_PCT_OPEN_HOLE { get; set; }

    public decimal? SD_INROD { get; set; }

    public decimal? SD_D_INROD { get; set; }

    public decimal? SD_PCT_IN_ROD { get; set; }

    public decimal? SD_TOTAL_LOG { get; set; }

    public int? SD_TOTAL_AVL { get; set; }

    public decimal? SD_PCT_LOG { get; set; }

    public string SD_DETAIL { get; set; }

    public virtual SURTECH_SHIFT SURTECH_SHIFT { get; set; }
}