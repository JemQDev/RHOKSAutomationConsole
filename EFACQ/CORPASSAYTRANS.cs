﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// This table is used to define a relationship between an assay virtual field, a non-numeric analytical result and a numeric translation value for the non-numeric result. A non-numeric results is transformed into the equivalent numeric value when acQuire&apos;s BestAssay form definitions are used (either for viewing or exporting data). These translations are dynamically generated when the compounds are used, leaving the original data unchanged.
/// </summary>
public partial class CORPASSAYTRANS
{
    /// <summary>
    /// Assay name used in virtual field.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// Expected description on the assay result
    /// </summary>
    public string DSC { get; set; }

    /// <summary>
    /// Expected assay result
    /// </summary>
    public double? VALUE { get; set; }

    /// <summary>
    /// Numeric conversion of DSC, or DSC and Value combined.
    /// </summary>
    public double EXPRULE1 { get; set; }

    /// <summary>
    /// Numeric conversion for exports to GEMS.
    /// </summary>
    public string EXPRULE2 { get; set; }

    public virtual CORPASSAYSTATUS DSCNavigation { get; set; }

    public virtual ASSAYTYPE NAMENavigation { get; set; }
}