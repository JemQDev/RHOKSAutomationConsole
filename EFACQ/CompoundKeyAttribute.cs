﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Contains Key/Value attributes for compounds.
/// </summary>
public partial class CompoundKeyAttribute
{
    /// <summary>
    /// The id of the Compound to which the attribute applies.
    /// </summary>
    public int CompoundId { get; set; }

    public string Key { get; set; }

    public string Value { get; set; }

    /// <summary>
    /// The id of the source system for the row.
    /// </summary>
    public short DataSourceId { get; set; }

    public virtual Compound Compound { get; set; }
}