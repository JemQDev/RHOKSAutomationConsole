﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Tenement refers to the actual ground / tenement / lease that has been granted to the company, by the government, for exploration and / or mining. Particulars about each tenement (the anniversary date, the expiry date and so on) can be stored in TenementCode and TenementDetails. 
/// </summary>
public partial class TENEMENT
{
    /// <summary>
    /// A unique identifying name and primary key of a tenement.
    /// </summary>
    public string TENEMENTID { get; set; }

    /// <summary>
    /// The official code the tenement is registered under.
    /// </summary>
    public string LICENCENUMBER { get; set; }

    /// <summary>
    /// The verbose description of the tenement.
    /// </summary>
    public string DESCRIPTION { get; set; }

    /// <summary>
    /// The type of licence, for example Exploration or Mining.
    /// </summary>
    public string LICENCETYPE { get; set; }

    /// <summary>
    /// Whether or not the tenement is active.
    /// </summary>
    public byte? ACTIVE { get; set; }

    public virtual ICollection<HOLELOCATION> HOLELOCATION { get; set; } = new List<HOLELOCATION>();

    public virtual ICollection<SAMPLE> SAMPLE { get; set; } = new List<SAMPLE>();
}