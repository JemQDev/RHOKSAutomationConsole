﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Particulars associated with the virtual fields created in SampleCode (they can be defined as either Text, Numeric or Date) related to CheckID are stored in this table. 
/// </summary>
public partial class CHECKDETAILS
{
    public string CHECKID { get; set; }

    public string DUPLICATENO { get; set; }

    public string NAME { get; set; }

    public string VALUE { get; set; }

    public virtual SAMPLECODE NAMENavigation { get; set; }
}