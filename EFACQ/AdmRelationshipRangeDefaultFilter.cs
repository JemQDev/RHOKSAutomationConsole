﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the filters to be applied to the range base tables for derived relationships.
/// </summary>
public partial class AdmRelationshipRangeDefaultFilter
{
    /// <summary>
    /// The Relationship Range Id from the AdmRelationshipRange table.
    /// </summary>
    public int RelationshipRangeId { get; set; }

    /// <summary>
    /// The field to filter.
    /// </summary>
    public string FilterField { get; set; }

    /// <summary>
    /// The calculation type to use if relevant for this filter.
    /// </summary>
    public string Calculation { get; set; }

    /// <summary>
    /// The fixed value the filter field must match if relevant.
    /// </summary>
    public string Value { get; set; }

    public virtual AdmRelationshipRange RelationshipRange { get; set; }
}