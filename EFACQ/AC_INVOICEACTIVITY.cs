﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// SLinks an Invoice to an Activity Report .
/// </summary>
public partial class AC_INVOICEACTIVITY
{
    /// <summary>
    /// The invoice number supplied by the contract company.
    /// </summary>
    public string INVOICENUMBER { get; set; }

    /// <summary>
    /// The company code of the contract company.
    /// </summary>
    public string COMPANYCODE { get; set; }

    /// <summary>
    /// The identifier, within the contractor company, to identify the activity report.
    /// </summary>
    public string ACTIVITYREPORTCODE { get; set; }

    public virtual AC_INVOICE AC_INVOICE { get; set; }
}