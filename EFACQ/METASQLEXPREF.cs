﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class METASQLEXPREF
{
    public string DFIELDNAME { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<METASQLEXP> METASQLEXP { get; set; } = new List<METASQLEXP>();

    public virtual ICollection<METASQLEXPFIELD> METASQLEXPFIELD { get; set; } = new List<METASQLEXPFIELD>();
}