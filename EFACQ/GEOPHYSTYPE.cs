﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class GEOPHYSTYPE
{
    public string TYPE { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<GEOPHYSHEADER> GEOPHYSHEADER { get; set; } = new List<GEOPHYSHEADER>();
}