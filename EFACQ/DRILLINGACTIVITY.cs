﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// DrillingActivity provides the virtual fields for DrillingDetail in the compound form Events. New fields can be entered via the Virtual Field Wizard. 
/// </summary>
public partial class DRILLINGACTIVITY
{
    public string NAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string DATATYPE { get; set; }

    public string UNITS { get; set; }

    public virtual ICollection<CONTRACTDETAILS> CONTRACTDETAILS { get; set; } = new List<CONTRACTDETAILS>();

    public virtual DATATYPE DATATYPENavigation { get; set; }

    public virtual ICollection<DRILLINGDETAIL> DRILLINGDETAIL { get; set; } = new List<DRILLINGDETAIL>();
}