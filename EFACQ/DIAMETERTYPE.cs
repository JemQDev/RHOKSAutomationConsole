﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// DiameterType is a &apos;list&apos; of the different drilling diameters downhole. For example, for diamond drilling the entries could include HQ, NQ and BQ. Accompanying the different types is the opportunity to record the diameter size. This information is helpful when evaluation costs of projects for government departments and future budget planning. 
/// </summary>
public partial class DIAMETERTYPE
{
    public string DIAMETERTYPE1 { get; set; }

    public double? DIAMETERSIZE { get; set; }

    public string UNITS { get; set; }

    public virtual ICollection<DRILLHOLEDIAMETER> DRILLHOLEDIAMETER { get; set; } = new List<DRILLHOLEDIAMETER>();

    public virtual UNITS UNITSNavigation { get; set; }
}