﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// DespatchBigCommentCode lists the large comment virtual field definitions for table DespatchSend. 
/// </summary>
public partial class DESPATCHBIGCOMMENTCODE
{
    /// <summary>
    /// The name of the virtual field and the primary key of the lookup table.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// A verbose description of this virtual field.
    /// </summary>
    public string DESCRIPTION { get; set; }

    public virtual ICollection<DESPATCHBIGCOMMENT> DESPATCHBIGCOMMENT { get; set; } = new List<DESPATCHBIGCOMMENT>();
}