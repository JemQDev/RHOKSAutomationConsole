﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Code table associated with AC_JOBBIGCOMMENT.
/// </summary>
public partial class AC_JOBBIGCOMMENTCODE
{
    /// <summary>
    /// The unique name of a virtual field.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// The description of a virtual field.
    /// </summary>
    public string DESCRIPTION { get; set; }

    public virtual ICollection<AC_JOBBIGCOMMENT> AC_JOBBIGCOMMENT { get; set; } = new List<AC_JOBBIGCOMMENT>();
}