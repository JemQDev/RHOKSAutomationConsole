﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the links from a role to its parent roles.
/// </summary>
public partial class LocalRoleParentRole
{
    /// <summary>
    /// The parent role.
    /// </summary>
    public Guid ParentRoleGlobalId { get; set; }

    /// <summary>
    /// The child role.
    /// </summary>
    public Guid ChildRoleGlobalId { get; set; }
}