﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class METATRACKINGTABLE
{
    public string CATEGORY { get; set; }

    public string TABLETYPE { get; set; }

    public string TABLENAME { get; set; }

    public virtual METATRACKINGREF METATRACKINGREF { get; set; }
}