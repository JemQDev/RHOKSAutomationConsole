﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// The method used to dissolve the sample into a solution for analysis.
/// </summary>
public partial class DIGESTTYPE
{
    public string DIGESTTYPE1 { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<ASSAYTYPE> ASSAYTYPE { get; set; } = new List<ASSAYTYPE>();
}