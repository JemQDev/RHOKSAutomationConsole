﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2020;

public partial class LoggingStrands
{
    public string LS_Strand { get; set; }

    public string LS_Description { get; set; }

    public bool? LS_Active { get; set; }

    public virtual ICollection<GeoLoggingSampling> GeoLoggingSampling { get; set; } = new List<GeoLoggingSampling>();
}