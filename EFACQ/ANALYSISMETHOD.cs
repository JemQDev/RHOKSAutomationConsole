﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// The method used by a lab to perform analysis.
/// </summary>
public partial class ANALYSISMETHOD
{
    public string ANALYSISMETHOD1 { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<ASSAYTYPE> ASSAYTYPE { get; set; } = new List<ASSAYTYPE>();

    public virtual ICollection<CORPLABPROPERTIES> CORPLABPROPERTIES { get; set; } = new List<CORPLABPROPERTIES>();
}