﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// ProjectDetails stores data for the Project virtual fields. It is associated with the Project table to make up the Projects compound definition. 
/// </summary>
public partial class PROJECTDETAILS
{
    public string PROJECTCODE { get; set; }

    public string NAME { get; set; }

    public string VALUE { get; set; }

    public virtual PROJECTCODE NAMENavigation { get; set; }
}