﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// The virtual field names for the comment aspect of a Collar compound definition are defined in this table. 
/// </summary>
public partial class HOLECOMMENTCODE
{
    public string NAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string DATATYPE { get; set; }

    public virtual DATATYPE DATATYPENavigation { get; set; }

    public virtual ICollection<HOLECOMMENT> HOLECOMMENT { get; set; } = new List<HOLECOMMENT>();
}