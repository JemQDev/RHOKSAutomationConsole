﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Manual override details for columns in the database.
/// </summary>
public partial class ManualDatabaseColumn
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int ManualDatabaseColumnId { get; set; }

    /// <summary>
    /// The schema of the table the column belongs to.
    /// </summary>
    public string DatabaseTableSchema { get; set; }

    /// <summary>
    /// The name of the table the column belongs to.
    /// </summary>
    public string DatabaseTableName { get; set; }

    /// <summary>
    /// The Name of the database column.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The name of the field type to be manually added to the column.
    /// </summary>
    public string FieldTypeName { get; set; }

    /// <summary>
    /// Can the fields value be generated by the database.
    /// </summary>
    public bool? IsGenerated { get; set; }
}