﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class GEOPHYSHEADERDETAILSCODE
{
    public string NAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string DATATYPE { get; set; }

    public string UNITS { get; set; }

    public string HCATEGORY { get; set; }

    public virtual DATATYPE DATATYPENavigation { get; set; }

    public virtual ICollection<GEOPHYSHEADERDETAILS> GEOPHYSHEADERDETAILS { get; set; } = new List<GEOPHYSHEADERDETAILS>();

    public virtual GEOPHYSHEADERCATEGORY HCATEGORYNavigation { get; set; }

    public virtual UNITS UNITSNavigation { get; set; }
}