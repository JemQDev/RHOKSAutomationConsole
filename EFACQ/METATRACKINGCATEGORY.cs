﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class METATRACKINGCATEGORY
{
    public string CATEGORY { get; set; }

    public string STATUSTABLE { get; set; }

    public string PKEY { get; set; }

    public string PKEY1 { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<METATRACKINGREF> METATRACKINGREF { get; set; } = new List<METATRACKINGREF>();
}