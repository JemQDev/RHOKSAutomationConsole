﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Defines the range grouping elements for range type compounds defined in AdmQomCompound.
/// </summary>
public partial class AdmQomCompoundRangeGroupingElement
{
    /// <summary>
    /// The primary key of the compound details record to which this range grouping element entry belongs.
    /// </summary>
    public int AdmQomCompoundId { get; set; }

    /// <summary>
    /// The order number of this range grouping element entry within the given compound details record.
    /// </summary>
    public int OrderNumber { get; set; }

    /// <summary>
    /// The name of the field being used as a range grouping element in the compound to be created. This or ParentCompoundName should be set, but not both.
    /// </summary>
    public string CompoundFieldName { get; set; }

    /// <summary>
    /// The name of the parent compound which will define the relationship being used as a range grouping element in the compound to be created. This or CompoundFieldName should be set, but not both.
    /// </summary>
    public string ParentCompoundName { get; set; }

    public virtual AdmQomCompound AdmQomCompound { get; set; }
}