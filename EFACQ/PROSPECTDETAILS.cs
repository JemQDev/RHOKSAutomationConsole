﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// ProspectDetails stores data for the Prospect virtual fields. It is associated with the Prospect table to make up the Prospects compound definition. 
/// </summary>
public partial class PROSPECTDETAILS
{
    public string PROSPECT { get; set; }

    public string PROJECTCODE { get; set; }

    public string NAME { get; set; }

    public string VALUE { get; set; }

    public virtual PROSPECTCODE NAMENavigation { get; set; }
}