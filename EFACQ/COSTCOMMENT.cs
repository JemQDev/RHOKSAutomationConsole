﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
///  Data loading order: 4 
/// </summary>
public partial class COSTCOMMENT
{
    public string COSTCODE { get; set; }

    public string NAME { get; set; }

    public string VALUE { get; set; }

    public virtual COSTCOMMENTCODE NAMENavigation { get; set; }
}