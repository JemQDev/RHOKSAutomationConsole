﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Sample is a list of named samples (SampleID) with associated locations (for point sampling). The Sample table is central to Assay, PointSample and SampleGeoAssay compound definitions. It is in these compound definitions that your analytical results are stored. 
/// </summary>
public partial class SAMPLE
{
    /// <summary>
    /// The unique identifying name of a sample, the primary key.
    /// </summary>
    public string SAMPLEID { get; set; }

    /// <summary>
    /// The name of a hole a sample belongs to.
    /// </summary>
    public string HOLEID { get; set; }

    /// <summary>
    /// The name of the project a sample belongs to.
    /// </summary>
    public string PROJECTCODE { get; set; }

    /// <summary>
    /// The start position of a sample interval, for example start depth.
    /// </summary>
    public double? SAMPFROM { get; set; }

    /// <summary>
    /// The end position of a sample interval, for example end depth.
    /// </summary>
    public double? SAMPTO { get; set; }

    /// <summary>
    /// The type of sample collected, for example soil, lag, core etc.
    /// </summary>
    public string SAMPLETYPE { get; set; }

    /// <summary>
    /// The prospect a GEOCHEM sample belongs to.
    /// </summary>
    public string POINTPROSPECT { get; set; }

    /// <summary>
    /// The X coordinate of a GEOCHEM sample.
    /// </summary>
    public double? POINTEAST { get; set; }

    /// <summary>
    /// The Y coordinate of a GEOCHEM sample.
    /// </summary>
    public double? POINTNORTH { get; set; }

    /// <summary>
    /// The Z coordinate or Reduce Level of a GEOCHEM sample.
    /// </summary>
    public double? POINTRL { get; set; }

    /// <summary>
    /// The ranking of a sample in respect to some sampling property .
    /// </summary>
    public double? PRIORITY { get; set; }

    /// <summary>
    /// The name of the grid a GEOCHEM sample belongs to.
    /// </summary>
    public string POINTGRIDNAME { get; set; }

    /// <summary>
    /// The name of the tenement a GEOCHEM sample belongs to.
    /// </summary>
    public string POINTTENEMENTID { get; set; }

    /// <summary>
    /// The global identifier for this row.
    /// </summary>
    public Guid GLOBALID { get; set; }

    public virtual ICollection<CORPSAMPLEASSAY> CORPSAMPLEASSAY { get; set; } = new List<CORPSAMPLEASSAY>();

    public virtual GRID POINTGRIDNAMENavigation { get; set; }

    public virtual TENEMENT POINTTENEMENT { get; set; }

    public virtual ICollection<SAMPLEBIGCOMMENT> SAMPLEBIGCOMMENT { get; set; } = new List<SAMPLEBIGCOMMENT>();

    public virtual SAMPLETYPE SAMPLETYPENavigation { get; set; }
}