﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Stores the category of a contract, e.g. Grade Control, Resource Definition, Geology, Geotech or differing geographical regions.
/// </summary>
public partial class AC_CONTRACTCATEGORY
{
    /// <summary>
    /// The unique identifier of the contract category.
    /// </summary>
    public string CONTRACTCATEGORYCODE { get; set; }

    /// <summary>
    /// A description of the contract category.
    /// </summary>
    public string DESCRIPTION { get; set; }

    public virtual ICollection<AC_ACTIVITYREPORT> AC_ACTIVITYREPORT { get; set; } = new List<AC_ACTIVITYREPORT>();

    public virtual ICollection<AC_CONTRACT> AC_CONTRACT { get; set; } = new List<AC_CONTRACT>();
}