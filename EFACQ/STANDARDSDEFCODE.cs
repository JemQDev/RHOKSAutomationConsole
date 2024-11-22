﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Code table associated with table STANDARDSDEFDETAILS.
/// </summary>
public partial class STANDARDSDEFCODE
{
    /// <summary>
    /// The unique name of a virtual details field.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// The description of a virtual details field.
    /// </summary>
    public string DESCRIPTION { get; set; }

    /// <summary>
    /// Defines the data type of a virtual details field.
    /// </summary>
    public string DATATYPE { get; set; }

    /// <summary>
    /// Defines the units used when a numeric data type is used.
    /// </summary>
    public string UNITS { get; set; }

    public virtual DATATYPE DATATYPENavigation { get; set; }

    public virtual ICollection<STANDARDSDEFDETAILS> STANDARDSDEFDETAILS { get; set; } = new List<STANDARDSDEFDETAILS>();
}