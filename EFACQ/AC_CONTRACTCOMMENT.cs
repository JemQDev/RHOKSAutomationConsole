﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Comment table associated with AC_CONTRACT. 
/// </summary>
public partial class AC_CONTRACTCOMMENT
{
    /// <summary>
    /// The unique identifier for this instance of the contract.
    /// </summary>
    public string CONTRACTCODE { get; set; }

    /// <summary>
    /// The name of the virtual comment field.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// The value stored in the virtual comment field.
    /// </summary>
    public string VALUE { get; set; }

    public virtual AC_CONTRACT CONTRACTCODENavigation { get; set; }

    public virtual AC_CONTRACTCOMMENTCODE NAMENavigation { get; set; }
}