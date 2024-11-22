﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class GEOPHYSHEADER
{
    public int GEOPHYSGID { get; set; }

    public string HOLEID { get; set; }

    public string PROJECTCODE { get; set; }

    public string TYPE { get; set; }

    public decimal DEPTHSTEP { get; set; }

    public int RUN { get; set; }

    public int PRIORITY { get; set; }

    public string LOOP { get; set; }

    public virtual ICollection<GEOPHYSDETAILS> GEOPHYSDETAILS { get; set; } = new List<GEOPHYSDETAILS>();

    public virtual ICollection<GEOPHYSHEADERBIGCOMMENT> GEOPHYSHEADERBIGCOMMENT { get; set; } = new List<GEOPHYSHEADERBIGCOMMENT>();

    public virtual ICollection<GEOPHYSHEADERCOMMENT> GEOPHYSHEADERCOMMENT { get; set; } = new List<GEOPHYSHEADERCOMMENT>();

    public virtual ICollection<GEOPHYSHEADERDETAILS> GEOPHYSHEADERDETAILS { get; set; } = new List<GEOPHYSHEADERDETAILS>();

    public virtual HOLELOCATION HOLELOCATION { get; set; }

    public virtual GEOPHYSLOOP LOOPNavigation { get; set; }

    public virtual GEOPHYSTYPE TYPENavigation { get; set; }
}