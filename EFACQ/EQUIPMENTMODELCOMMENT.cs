﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Comment table associated with the EQUIPMENTMODEL table virtual field system. 
/// </summary>
public partial class EQUIPMENTMODELCOMMENT
{
    public string EQUIPMENTMODELCODE { get; set; }

    public string NAME { get; set; }

    public string VALUE { get; set; }

    public virtual EQUIPMENTMODEL EQUIPMENTMODELCODENavigation { get; set; }

    public virtual EQUIPMENTMODELCOMMENTCODE NAMENavigation { get; set; }
}