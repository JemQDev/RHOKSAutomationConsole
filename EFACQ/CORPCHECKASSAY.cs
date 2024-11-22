﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// CorpCheckAssay stores the analytical results for the check samples. The combination of CheckID, DuplicateNo and Name must be unique in the database. The values must be numeric. 
/// </summary>
public partial class CORPCHECKASSAY
{
    public string CHECKID { get; set; }

    public string DUPLICATENO { get; set; }

    /// <summary>
    /// the tag for the virtual field (virtual field name)
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// A value of 1 means accepted, 2 pending and 3+ rejected
    /// </summary>
    public int PRIORITY { get; set; }

    /// <summary>
    /// Stores the assay result
    /// </summary>
    public double? VALUE { get; set; }

    /// <summary>
    /// Stores a description on the assay result
    /// </summary>
    public string DSC { get; set; }

    /// <summary>
    /// ID used by the lab for the lab batch
    /// </summary>
    public string LABJOBNO { get; set; }

    /// <summary>
    /// date the assay results was load to the database
    /// </summary>
    public DateTime LOADDATE { get; set; }

    /// <summary>
    /// The order that samples were analysed in the lab batch
    /// </summary>
    public int? ANALYSISORDER { get; set; }

    public virtual CHECKSAMPLE CHECKSAMPLE { get; set; }

    public virtual CORPASSAYSTATUS DSCNavigation { get; set; }
}