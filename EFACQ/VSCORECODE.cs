﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class VSCORECODE
{
    public string NAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string DATATYPE { get; set; }

    public virtual ICollection<VSCOREDETAILS> VSCOREDETAILS { get; set; } = new List<VSCOREDETAILS>();
}