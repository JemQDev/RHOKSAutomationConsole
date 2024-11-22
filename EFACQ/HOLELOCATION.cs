﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// The HoleLocation table is the entry point for data in an acQuire database. The data in this table is either the collar details of drillholes or the name of a geochemical sampling program. The primary key fields are HoleID and ProjectCode. Drillholes, costeans, downhole geotechnical surveys or face samples are considered to be linear samples and are classified as HoleType= DRILLHOLE. In a work program there probably would be numerous HoleID(s) associated with a ProjectCode. For example: HoleID = DDH013, DDH014 or DDH015 ProjectCode = King River HoleType = DRILLHOLE For geochemical or pit geotechnical samples (ie point samples but, NOT downhole point samples such as geotech drilling - they would be defined as DRILLHOLE) the HoleType would be GEOCHEM. In this case the HoleID would probably reflect the sampling type/method or program name.  For example: HoleID = BLEG97 (a sampling program) ProjectCode = King River HoleType = GEOCHEM SampleID = M03451, M03452 or M03453 and so on (SampleID are entered into the Sample table). 
/// </summary>
public partial class HOLELOCATION
{
    /// <summary>
    /// The identifying name of a hole, a kind of geographical anchor point, part of the primary key.
    /// </summary>
    public string HOLEID { get; set; }

    /// <summary>
    /// The name of the project the hole belongs to, part of the primary key.
    /// </summary>
    public string PROJECTCODE { get; set; }

    /// <summary>
    /// The name of the tenement the hole is geographically located in.
    /// </summary>
    public string TENEMENTID { get; set; }

    /// <summary>
    /// The name of the grid the hole coordinates refer to.
    /// </summary>
    public string GRIDNAME { get; set; }

    /// <summary>
    /// The type of hole, can be DRILLHOLE for linear/sequential groupings of samples, or GEOCHEM for dispersed samples.
    /// </summary>
    public string HOLETYPE { get; set; }

    /// <summary>
    /// The X coordinate of the hole anchor point.
    /// </summary>
    public double? EAST { get; set; }

    /// <summary>
    /// The Y coordinate of the hole anchor point.
    /// </summary>
    public double? NORTH { get; set; }

    /// <summary>
    /// The Z coordinate of the hole anchor point reduced to a reference point, for example sea level, hence the name Reduced Level.
    /// </summary>
    public double? RL { get; set; }

    /// <summary>
    /// The final distance from start to end point of a hole or sampling line.
    /// </summary>
    public double? DEPTH { get; set; }

    /// <summary>
    /// The sub-division of a project.
    /// </summary>
    public string PROSPECT { get; set; }

    /// <summary>
    /// The data work commenced on the hole or linear construction.
    /// </summary>
    public string STARTDATE { get; set; }

    /// <summary>
    /// The data work ended on the hole or linear construction.
    /// </summary>
    public string ENDDATE { get; set; }

    public Guid GLOBALID { get; set; }

    public virtual ICollection<AC_HOLELOCATIONACTIVITYREPORTITEM> AC_HOLELOCATIONACTIVITYREPORTITEM { get; set; } = new List<AC_HOLELOCATIONACTIVITYREPORTITEM>();

    public virtual ICollection<GEOPHYSHEADER> GEOPHYSHEADER { get; set; } = new List<GEOPHYSHEADER>();

    public virtual GRID GRIDNAMENavigation { get; set; }

    public virtual HOLETYPE HOLETYPENavigation { get; set; }

    public virtual TENEMENT TENEMENT { get; set; }
}