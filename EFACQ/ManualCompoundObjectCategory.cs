﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the manually defined associations between Compounds and Object Categories to be created.
/// </summary>
public partial class ManualCompoundObjectCategory
{
    /// <summary>
    /// The name of the Compound.
    /// </summary>
    public string CompoundName { get; set; }

    /// <summary>
    /// The unqiue identifier of the Object Category.
    /// </summary>
    public Guid ObjectCategoryGlobalId { get; set; }

    public virtual ManualObjectCategory ObjectCategoryGlobal { get; set; }
}