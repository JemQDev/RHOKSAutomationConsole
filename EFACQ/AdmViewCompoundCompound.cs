﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Maintains an cache of references from view compounds in presentation to compounds in the meta system.
/// </summary>
public partial class AdmViewCompoundCompound
{
    /// <summary>
    /// The identity of the view.
    /// </summary>
    public int ViewId { get; set; }

    /// <summary>
    /// The name of the compound as referenced inside the xml of the view compound.
    /// </summary>
    public string CompoundName { get; set; }

    public virtual View View { get; set; }
}