﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Stores the set of map projections usable by acQuire.
/// </summary>
public partial class GDPROJECTION
{
    /// <summary>
    /// The name of the map projection.
    /// </summary>
    public string PROJECTION { get; set; }

    /// <summary>
    /// The projection system used.
    /// </summary>
    public string TYPE { get; set; }

    /// <summary>
    /// The units used for length measurements.
    /// </summary>
    public string UNITS { get; set; }

    /// <summary>
    /// The value of the P1 parameter required to define the projection. (Each parameters&apos; definition changes depending on the projection system used.)
    /// </summary>
    public string PARAMETERP1 { get; set; }

    /// <summary>
    /// The value of the P2 parameter required to define the projection. (Each parameters&apos; definition changes depending on the projection system used.)
    /// </summary>
    public string PARAMETERP2 { get; set; }

    /// <summary>
    /// The value of the P3 parameter required to define the projection. (Each parameters&apos; definition changes depending on the projection system used.)
    /// </summary>
    public string PARAMETERP3 { get; set; }

    /// <summary>
    /// The value of the P4 parameter required to define the projection. (Each parameters&apos; definition changes depending on the projection system used.)
    /// </summary>
    public string PARAMETERP4 { get; set; }

    /// <summary>
    /// The value of the P5 parameter required to define the projection. (Each parameters&apos; definition changes depending on the projection system used.)
    /// </summary>
    public string PARAMETERP5 { get; set; }

    /// <summary>
    /// The value of the P6 parameter required to define the projection. (Each parameters&apos; definition changes depending on the projection system used.)
    /// </summary>
    public string PARAMETERP6 { get; set; }

    /// <summary>
    /// The value of the P7 parameter required to define the projection. (Each parameters&apos; definition changes depending on the projection system used.)
    /// </summary>
    public string PARAMETERP7 { get; set; }

    /// <summary>
    /// The value of the P8 parameter required to define the projection. (Each parameters&apos; definition changes depending on the projection system used.)
    /// </summary>
    public string PARAMETERP8 { get; set; }

    public virtual ICollection<GDCOORDINATESYSTEM> GDCOORDINATESYSTEM { get; set; } = new List<GDCOORDINATESYSTEM>();

    public virtual ICollection<GRID> GRID { get; set; } = new List<GRID>();

    public virtual ICollection<QT_FME_COORDSYS> QT_FME_COORDSYS { get; set; } = new List<QT_FME_COORDSYS>();

    public virtual GDUNITS UNITSNavigation { get; set; }
}