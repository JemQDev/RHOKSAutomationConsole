﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Code table associated with SAMPLECOMMENT.
/// </summary>
public partial class SAMPLECOMMENTCODE
{
    public string NAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string DATATYPE { get; set; }

    public virtual ICollection<CF_COMPOSITESAMPLETREECOMMENT> CF_COMPOSITESAMPLETREECOMMENT { get; set; } = new List<CF_COMPOSITESAMPLETREECOMMENT>();

    public virtual ICollection<CHECKCOMMENT> CHECKCOMMENT { get; set; } = new List<CHECKCOMMENT>();

    public virtual DATATYPE DATATYPENavigation { get; set; }

    public virtual ICollection<SAMPLECOMMENT> SAMPLECOMMENT { get; set; } = new List<SAMPLECOMMENT>();
}