﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2020;

public partial class ColourCode
{
    public string VCC_ColourCode { get; set; }

    public string VCC_Description { get; set; }

    public bool? VCC_Active { get; set; }

    public virtual ICollection<GeoLoggingSampling> GeoLoggingSampling { get; set; } = new List<GeoLoggingSampling>();
}