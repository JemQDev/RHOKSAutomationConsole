﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Maintains an cache of excluded derived fields, in order to speed up MetaSystem processing.
/// </summary>
public partial class AdmFailedDerivedField
{
    /// <summary>
    /// The derived field name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The SQL code for the derived field.
    /// </summary>
    public string DerivedFieldCode { get; set; }

    /// <summary>
    /// An encoded list of fields used for comparison to the ADM source information.
    /// </summary>
    public string FieldList { get; set; }

    /// <summary>
    /// An encoded list of tables used for comparison to the ADM source information.
    /// </summary>
    public string TableList { get; set; }

    /// <summary>
    /// The most significant error which caused the exclusion of the derived field.
    /// </summary>
    public int? ErrorMessageId { get; set; }

    /// <summary>
    /// The arguments to be passed to the error message format.
    /// </summary>
    public string Arguments { get; set; }
}