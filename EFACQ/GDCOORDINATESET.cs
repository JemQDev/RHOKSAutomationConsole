﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class GDCOORDINATESET
{
    public string COORDINATESET { get; set; }

    public string GRIDNAME { get; set; }

    public string SURVEYMETHOD { get; set; }

    public int RANK { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<GEOPHYSLOOPCOORD> GEOPHYSLOOPCOORD { get; set; } = new List<GEOPHYSLOOPCOORD>();

    public virtual GRID GRIDNAMENavigation { get; set; }

    public virtual ICollection<HOLECOORD> HOLECOORD { get; set; } = new List<HOLECOORD>();

    public virtual ICollection<SAMPLECOORD> SAMPLECOORD { get; set; } = new List<SAMPLECOORD>();

    public virtual GDSURVEYMETHOD SURVEYMETHODNavigation { get; set; }
}