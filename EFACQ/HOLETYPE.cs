﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// HoleType defines the data type: either DRILLHOLE or GEOCHEM. If the information collected in HoleLocation refers to a drillhole, a costean, trench or face samples, for example, the entry is DRILLHOLE. If the information is about geochemical or geotechnical sampling, the entry is GEOCHEM. See: HoleLocation. 
/// </summary>
public partial class HOLETYPE
{
    public string HOLETYPE1 { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<HOLELOCATION> HOLELOCATION { get; set; } = new List<HOLELOCATION>();
}