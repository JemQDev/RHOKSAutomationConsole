﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Stores details of the individual pieces of equipment themselves, i.e. each individual item of equipment.
/// </summary>
public partial class EQUIPMENT
{
    /// <summary>
    /// The unique identifier for this individual item of equipment.
    /// </summary>
    public string EQUIPMENTCODE { get; set; }

    /// <summary>
    /// The unique identifier for the make and model of this item of equipment.
    /// </summary>
    public string EQUIPMENTMODELCODE { get; set; }

    /// <summary>
    /// The unique identifier for the company using this item of equipment.
    /// </summary>
    public string COMPANYCODE { get; set; }

    /// <summary>
    /// The description of this item of equipment.
    /// </summary>
    public string DESCRIPTION { get; set; }

    /// <summary>
    /// Is this equipment available for use or not.
    /// </summary>
    public byte? ACTIVE { get; set; }

    /// <summary>
    /// The validity period of a calibration.
    /// </summary>
    public int? CONFIGURATIONPERIOD { get; set; }

    /// <summary>
    /// The unit in which the validity period is measured.
    /// </summary>
    public string CONFIGURATIONPERIODUNITS { get; set; }

    public virtual ICollection<AC_ACTIVITYREPORT> AC_ACTIVITYREPORT { get; set; } = new List<AC_ACTIVITYREPORT>();

    public virtual COMPANY COMPANYCODENavigation { get; set; }

    public virtual UNITS CONFIGURATIONPERIODUNITSNavigation { get; set; }

    public virtual ICollection<EQUIPMENTBIGCOMMENT> EQUIPMENTBIGCOMMENT { get; set; } = new List<EQUIPMENTBIGCOMMENT>();

    public virtual ICollection<EQUIPMENTCOMMENT> EQUIPMENTCOMMENT { get; set; } = new List<EQUIPMENTCOMMENT>();

    public virtual ICollection<EQUIPMENTCONFIG> EQUIPMENTCONFIG { get; set; } = new List<EQUIPMENTCONFIG>();

    public virtual ICollection<EQUIPMENTDETAILS> EQUIPMENTDETAILS { get; set; } = new List<EQUIPMENTDETAILS>();

    public virtual EQUIPMENTMODEL EQUIPMENTMODELCODENavigation { get; set; }
}