﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details attributes on a compound.
/// </summary>
public partial class CompoundAttribute
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int CompoundAttributeId { get; set; }

    /// <summary>
    /// The type of attribute.
    /// </summary>
    public string AttributeType { get; set; }

    /// <summary>
    /// XML definition of the attribute.
    /// </summary>
    public string Definition { get; set; }

    /// <summary>
    /// The main compound which this compound attribute is based on.
    /// </summary>
    public int CompoundId { get; set; }

    /// <summary>
    /// The data source which the details of this record were primarily obtained from.
    /// </summary>
    public short DataSourceId { get; set; }

    public virtual AdmCoordinateData AdmCoordinateData { get; set; }

    public virtual Compound Compound { get; set; }

    public virtual DataSource DataSource { get; set; }
}