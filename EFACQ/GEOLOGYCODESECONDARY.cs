﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// GeologyCodeSecondary is the storage of SecondaryCode(s) - each SecondaryCode may be associated with a PrimaryCode that must be defined first in GeologyCodePrimary  
/// </summary>
public partial class GEOLOGYCODESECONDARY
{
    public string NAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string PRIMARYCODE { get; set; }

    public string DATATYPE { get; set; }

    public string UNITS { get; set; }

    public virtual ICollection<CHECKGEOLOGY> CHECKGEOLOGY { get; set; } = new List<CHECKGEOLOGY>();

    public virtual DATATYPE DATATYPENavigation { get; set; }

    public virtual ICollection<GEODETAILS> GEODETAILS { get; set; } = new List<GEODETAILS>();

    public virtual ICollection<POINTGEOLOGY> POINTGEOLOGY { get; set; } = new List<POINTGEOLOGY>();

    public virtual GEOLOGYCODEPRIMARY PRIMARYCODENavigation { get; set; }
}