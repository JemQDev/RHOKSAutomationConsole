﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class VSCOREREF
{
    public int PID { get; set; }

    public string PIDNAME { get; set; }

    public string DESCRIPTION { get; set; }

    public virtual ICollection<VSCORE> VSCORE { get; set; } = new List<VSCORE>();

    public virtual ICollection<VSCOREFIELD> VSCOREFIELD { get; set; } = new List<VSCOREFIELD>();
}