﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the fields for each compound.
/// </summary>
public partial class CompoundField
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int CompoundFieldId { get; set; }

    /// <summary>
    /// The Name of the compound field.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Label of the compound field to be used for display purposes.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// The Compound this field belongs to.
    /// </summary>
    public int CompoundId { get; set; }

    /// <summary>
    /// The Order in which these fields should be displayed for a compound.
    /// </summary>
    public int? OrderNumber { get; set; }

    /// <summary>
    /// Is the data for this field read only.
    /// </summary>
    public bool IsReadOnly { get; set; }

    /// <summary>
    /// Is this field shown to the users.
    /// </summary>
    public bool IsShown { get; set; }

    /// <summary>
    /// The Database Table that houses this field, this will not be populated for derived fields.
    /// </summary>
    public int? DatabaseTableId { get; set; }

    /// <summary>
    /// The Table Context, PrimaryBase, Base, Virtual, Derived. Representing both the field and its table.
    /// </summary>
    public string TableContext { get; set; }

    /// <summary>
    /// The Database Column that this field relates to, only populated for fixed fields.
    /// </summary>
    public int? DatabaseColumnId { get; set; }

    /// <summary>
    /// The Virtual Field this field relatess to, only populated for virtual fields.
    /// </summary>
    public int? VirtualFieldId { get; set; }

    /// <summary>
    /// For cases where type is &quot;Derived&quot;, this is a link to the expression in the expression table (not implemented yet).
    /// </summary>
    public int? FieldExpressionId { get; set; }

    /// <summary>
    /// The related field type, which defines the fields datatype and other meta data about the field.
    /// </summary>
    public int FieldTypeId { get; set; }

    /// <summary>
    /// The expression outlining the construction of a derived field.
    /// </summary>
    public string DerivedFieldExpression { get; set; }

    public int? AdmDerivedFieldId { get; set; }

    /// <summary>
    /// The data source which the details of this record were primarily obtained from.
    /// </summary>
    public short DataSourceId { get; set; }

    /// <summary>
    /// An optional description of the purpose of the field.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// An xml encoded constant expression to be used as the default value for the field.
    /// </summary>
    public string DefaultValue { get; set; }

    public virtual AdmDerivedField AdmDerivedField { get; set; }

    public virtual Compound Compound { get; set; }

    public virtual ICollection<CompoundUniquenessField> CompoundUniquenessField { get; set; } = new List<CompoundUniquenessField>();

    public virtual DataSource DataSource { get; set; }

    public virtual DatabaseColumn DatabaseColumn { get; set; }

    public virtual DatabaseTable DatabaseTable { get; set; }

    public virtual FieldType FieldType { get; set; }

    public virtual ICollection<Range> RangeFromField { get; set; } = new List<Range>();

    public virtual ICollection<RangeGroupingElement> RangeGroupingElement { get; set; } = new List<RangeGroupingElement>();

    public virtual ICollection<Range> RangeToField { get; set; } = new List<Range>();

    public virtual ICollection<RelationshipJoin> RelationshipJoinCompoundField1 { get; set; } = new List<RelationshipJoin>();

    public virtual ICollection<RelationshipJoin> RelationshipJoinCompoundField2 { get; set; } = new List<RelationshipJoin>();

    public virtual ICollection<RelationshipOrdering> RelationshipOrdering { get; set; } = new List<RelationshipOrdering>();

    public virtual VirtualField VirtualField { get; set; }

    public virtual ICollection<AdmDerivedFieldParameter> AdmDerivedFieldParameter { get; set; } = new List<AdmDerivedFieldParameter>();

    public virtual ICollection<FieldAttribute> FieldAttribute { get; set; } = new List<FieldAttribute>();

    public virtual ICollection<StylingFieldGroup> StylingFieldGroup { get; set; } = new List<StylingFieldGroup>();
}