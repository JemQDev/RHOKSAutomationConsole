﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Code table associated with AC_JOBDETAILS.
/// </summary>
public partial class AC_JOBCODE
{
    /// <summary>
    /// The unique name of a virtual field.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// The descriptions of a virtual field.
    /// </summary>
    public string DESCRIPTION { get; set; }

    /// <summary>
    /// Defines the data type of a virtual field.
    /// </summary>
    public string DATATYPE { get; set; }

    /// <summary>
    /// Defines the units used when a numeric data type is used.
    /// </summary>
    public string UNITS { get; set; }

    public virtual ICollection<AC_JOBDETAILS> AC_JOBDETAILS { get; set; } = new List<AC_JOBDETAILS>();

    public virtual DATATYPE DATATYPENavigation { get; set; }
}