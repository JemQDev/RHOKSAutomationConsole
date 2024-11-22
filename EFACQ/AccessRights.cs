﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the access rights to a secure entity.
/// </summary>
public partial class AccessRights
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int AccessRightsId { get; set; }

    /// <summary>
    /// The Role this access rights is linked to.
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// The Secure Entity this grants access to.
    /// </summary>
    public int SecureEntityId { get; set; }

    /// <summary>
    /// The Create Permission.
    /// </summary>
    public bool Create { get; set; }

    /// <summary>
    /// The Read Permission.
    /// </summary>
    public bool Read { get; set; }

    /// <summary>
    /// The Write Permission.
    /// </summary>
    public bool Write { get; set; }

    /// <summary>
    /// The Delete Permission.
    /// </summary>
    public bool Delete { get; set; }

    public virtual Role Role { get; set; }

    public virtual SecureEntity SecureEntity { get; set; }
}