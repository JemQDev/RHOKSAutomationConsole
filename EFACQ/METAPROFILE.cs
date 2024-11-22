﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Stores data on acQuire Direct profiles.
/// </summary>
public partial class METAPROFILE
{
    /// <summary>
    /// The name of the profile.
    /// </summary>
    public string PROFILE { get; set; }

    /// <summary>
    /// The module to which the data pertains.
    /// </summary>
    public string MODULE { get; set; }

    /// <summary>
    /// A blob containing the data for this profile and this module.
    /// </summary>
    public byte[] VALUE { get; set; }

    /// <summary>
    /// A description of the profile.
    /// </summary>
    public string DESCRIPTION { get; set; }
}