﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the tables and views that need to be included in database table and column, but dont have keys.
/// </summary>
public partial class ManualTableInclusion
{
    /// <summary>
    /// The Schema of the object.
    /// </summary>
    public string Schema { get; set; }

    /// <summary>
    /// The name of the object.
    /// </summary>
    public string Name { get; set; }

    public virtual ICollection<ManualTableInclusionKey> ManualTableInclusionKey { get; set; } = new List<ManualTableInclusionKey>();
}