﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Stores locking attributes of a single invoice.
/// </summary>
public partial class AC_INVOICELOCK
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
    /// Indicate whether the invoice has been paid up and the report details need to be preserved. Not null enforced in trigger.
    /// </summary>
    public byte? ISLOCKED { get; set; }

    /// <summary>
    /// Date when invoice and associated records are locked or unlocked.
    /// </summary>
    public DateTime? LOCKCHANGEDATE { get; set; }

    /// <summary>
    /// Name of database user who locked or unlocked the invoice.
    /// </summary>
    public string LOCKCHANGEUSER { get; set; }

    /// <summary>
    /// Name of network system user who locked or unlocked the invoice.
    /// </summary>
    public string LOCKCHANGESYSTEMUSER { get; set; }
}