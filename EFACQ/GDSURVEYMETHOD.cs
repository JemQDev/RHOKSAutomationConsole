﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class GDSURVEYMETHOD
{
    public string SURVEYMETHOD { get; set; }

    public string DESCRIPTION { get; set; }

    public int? RANK { get; set; }

    public virtual ICollection<GDCOORDINATESET> GDCOORDINATESET { get; set; } = new List<GDCOORDINATESET>();
}