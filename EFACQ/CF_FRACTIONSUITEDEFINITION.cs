﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Reference table defining the fractions associated with a fraction suite. 
/// </summary>
public partial class CF_FRACTIONSUITEDEFINITION
{
    /// <summary>
    /// A unique name and part of the primary key of a fraction suite.
    /// </summary>
    public string FRACTIONSUITE { get; set; }

    /// <summary>
    /// A unique identifier of a fraction, also primary key.
    /// </summary>
    public string FRACTIONID { get; set; }

    /// <summary>
    /// The verbose descriptions of a fraction as part of suite definition.
    /// </summary>
    public string DESCRIPTION { get; set; }

    /// <summary>
    /// The sort order of the FractionID within a Fractionsuite.
    /// </summary>
    public int? FIELDORDER { get; set; }

    public virtual CF_FRACTIONSUITE FRACTIONSUITENavigation { get; set; }
}