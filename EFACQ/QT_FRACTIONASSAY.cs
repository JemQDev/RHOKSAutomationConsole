﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Internal table maintained by acQuire containing all Fraction Assays. This is not a user updateable table.
/// </summary>
public partial class QT_FRACTIONASSAY
{
    public string SAMPLEID { get; set; }

    public string NAME { get; set; }

    public int PRIORITY { get; set; }

    public double? VALUE { get; set; }

    public string DSC { get; set; }

    public string LABJOBNO { get; set; }

    public DateTime LOADDATE { get; set; }

    public int? ANALYSISORDER { get; set; }

    public string FRACTIONID { get; set; }

    public int FRACTIONLEVEL { get; set; }

    public string CHECKID { get; set; }

    public string DUPLICATENO { get; set; }

    public string ASSAYNAME { get; set; }
}