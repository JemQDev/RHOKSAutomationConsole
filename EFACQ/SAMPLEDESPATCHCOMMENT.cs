﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// SampleDespatchComment stores comments about individual samples in a dispatch. The field names are defined in SampleDespatchComCode.Name. 
/// </summary>
public partial class SAMPLEDESPATCHCOMMENT
{
    public string SAMPLEID { get; set; }

    public string DESPATCHNO { get; set; }

    public string NAME { get; set; }

    public string VALUE { get; set; }

    public virtual SAMPLEDESPATCHCOMCODE NAMENavigation { get; set; }
}