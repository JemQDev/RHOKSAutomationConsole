﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Large comments as virtual fields for Despatches sent to a laboratory. 
/// </summary>
public partial class DESPATCHBIGCOMMENT
{
    /// <summary>
    /// The the despatch code with the instructions for the laboratory, also part of primary key.
    /// </summary>
    public string DESPATCHNO { get; set; }

    /// <summary>
    /// The name of a virtual field, also part of primary key.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// The mandatory value of a virtual field.
    /// </summary>
    public string VALUE { get; set; }

    public virtual DESPATCHBIGCOMMENTCODE NAMENavigation { get; set; }
}