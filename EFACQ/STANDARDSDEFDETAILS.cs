﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details table associate with table STANDARDSDEFINITION.
/// </summary>
public partial class STANDARDSDEFDETAILS
{
    /// <summary>
    /// The identifying name of a standard.
    /// </summary>
    public string STANDARDID { get; set; }

    /// <summary>
    /// The name of a virtual details field.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// The content of a virtual details field.
    /// </summary>
    public string VALUE { get; set; }

    public virtual STANDARDSDEFCODE NAMENavigation { get; set; }
}