﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Identifies the composites present in the database. 
/// </summary>
public partial class CF_COMPOSITE
{
    /// <summary>
    /// A unique identifier and primary key of a composite.
    /// </summary>
    public string COMPOSITEID { get; set; }

    /// <summary>
    /// The type of composite, for example raw indicates that it is based on raw samples.
    /// </summary>
    public string COMPOSITETYPE { get; set; }

    /// <summary>
    /// The method used to derive the composite.
    /// </summary>
    public string COMPOSITEMETHOD { get; set; }

    public virtual CF_COMPOSITEMETHOD COMPOSITEMETHODNavigation { get; set; }

    public virtual CF_COMPOSITETYPE COMPOSITETYPENavigation { get; set; }
}