﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Stores in the database the methods used to create fractions. 
/// </summary>
public partial class CF_FRACTIONMETHOD
{
    /// <summary>
    /// A unique name and primary key of a fraction method.
    /// </summary>
    public string FRACTIONMETHOD { get; set; }

    /// <summary>
    /// A unique descriptive name of a fraction category.
    /// </summary>
    public string FRACTIONCATEGORY { get; set; }

    /// <summary>
    /// The verbose descriptions of a fraction method.
    /// </summary>
    public string DESCRIPTION { get; set; }

    /// <summary>
    /// A flag to permit repeated use of same FractionID at same level.
    /// </summary>
    public byte? LEVELFRACTIONREPEAT { get; set; }

    /// <summary>
    /// The order in which fractionation methods must be applied.
    /// </summary>
    public short? METHODORDER { get; set; }

    /// <summary>
    /// The fraction category group.
    /// </summary>
    public string CATEGORYGROUP { get; set; }

    public virtual ICollection<CF_FRACTION> CF_FRACTION { get; set; } = new List<CF_FRACTION>();

    public virtual CF_FRACTIONCATEGORY FRACTIONCATEGORYNavigation { get; set; }
}