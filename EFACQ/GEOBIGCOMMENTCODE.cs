﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// GeoBigCommentCode stores the names of the virtual fields for GeoBigComment (long comments) that are associated with the Geology compound definition. 
/// </summary>
public partial class GEOBIGCOMMENTCODE
{
    public string NAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string PRIMARYCODE { get; set; }

    public string DATATYPE { get; set; }

    public virtual ICollection<CHECKGEOBIGCOMMENT> CHECKGEOBIGCOMMENT { get; set; } = new List<CHECKGEOBIGCOMMENT>();

    public virtual DATATYPE DATATYPENavigation { get; set; }

    public virtual ICollection<GEOBIGCOMMENT> GEOBIGCOMMENT { get; set; } = new List<GEOBIGCOMMENT>();

    public virtual ICollection<POINTGEOBIGCOMMENT> POINTGEOBIGCOMMENT { get; set; } = new List<POINTGEOBIGCOMMENT>();

    public virtual GEOLOGYCODEPRIMARY PRIMARYCODENavigation { get; set; }
}