﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the styling field groups defined in the system. This allows a group of compound fields to be styled in the same way.
/// </summary>
public partial class StylingFieldGroup
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int StylingFieldGroupId { get; set; }

    /// <summary>
    /// The name of the styling field group.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A description of the styling field group.
    /// </summary>
    public string Description { get; set; }

    public virtual ICollection<StylingFieldGroupStyling> StylingFieldGroupStyling { get; set; } = new List<StylingFieldGroupStyling>();

    public virtual ICollection<CompoundField> CompoundField { get; set; } = new List<CompoundField>();
}