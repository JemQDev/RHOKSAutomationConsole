﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details information pertaining to a saved Expression.
/// </summary>
public partial class Expression
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int ExpressionId { get; set; }

    /// <summary>
    /// The Creator of the Expression.
    /// </summary>
    public int CreatorId { get; set; }

    /// <summary>
    /// Is the Expression public.
    /// </summary>
    public bool IsPublic { get; set; }

    /// <summary>
    /// The xml data comprising the Expression.
    /// </summary>
    public string ExpressionData { get; set; }

    public virtual User Creator { get; set; }

    public virtual ICollection<ViewCompound> ViewCompound { get; set; } = new List<ViewCompound>();
}