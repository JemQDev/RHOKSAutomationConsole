﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details manually defined equality relationships between compounds.
/// </summary>
public partial class ManualEqualityRelationship
{
    /// <summary>
    /// The name of the source compound.
    /// </summary>
    public string Compound1Name { get; set; }

    /// <summary>
    /// The name of the target compound.
    /// </summary>
    public string Compound2Name { get; set; }

    /// <summary>
    /// The relationship direction.
    /// </summary>
    public string RelationshipDirection { get; set; }

    /// <summary>
    /// Whether the source of this relationship is a parent of the target.
    /// </summary>
    public bool? IsParent { get; set; }

    /// <summary>
    /// The data source of this record.
    /// </summary>
    public short? DataSourceId { get; set; }

    /// <summary>
    /// The GUID primary key.
    /// </summary>
    public Guid ManualEqualityRelationshipGlobalId { get; set; }

    /// <summary>
    /// The Label of the specified relationship.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Specifies if the relationship should be visible, null does not override.
    /// </summary>
    public bool? IsVisible { get; set; }

    /// <summary>
    /// Flag indicating that the relationship must be set on the source compound.
    /// </summary>
    public bool? IsRequired { get; set; }

    /// <summary>
    /// Specifies kind of relationship with respect to rule propagation.
    /// </summary>
    public string RuleBehavior { get; set; }

    public virtual DataSource DataSource { get; set; }

    public virtual ICollection<ManualEqualityRelationshipJoin> ManualEqualityRelationshipJoin { get; set; } = new List<ManualEqualityRelationshipJoin>();
}