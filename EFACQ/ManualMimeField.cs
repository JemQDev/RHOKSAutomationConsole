﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the MIME fields to be created.
/// </summary>
public partial class ManualMimeField
{
    /// <summary>
    /// The identity key for the Manual Mime Field table.
    /// </summary>
    public int ManualMimeFieldId { get; set; }

    /// <summary>
    /// The name to be given to the mime field.
    /// </summary>
    public string MimeFieldName { get; set; }

    /// <summary>
    /// The schema of the table that this mime field is from.
    /// </summary>
    public string TableSchema { get; set; }

    /// <summary>
    /// The name of the table that this mime field is from.
    /// </summary>
    public string TableName { get; set; }

    /// <summary>
    /// The type for this component of the mime field. ie Value, Type, SupportedValues
    /// </summary>
    public string FieldType { get; set; }

    /// <summary>
    /// The type of xml to be created, ElementPath or LockedFieldValue 
    /// </summary>
    public string XmlType { get; set; }

    /// <summary>
    /// The name of the field containing the information for this part of the mime.
    /// </summary>
    public string ComprisingFieldName { get; set; }

    /// <summary>
    /// The supported values for this part of the mime field.
    /// </summary>
    public string LockedFieldValue { get; set; }

    /// <summary>
    /// The order in which the ComprisingFields / LockedFieldValues are put into the xml for the mime field.
    /// </summary>
    public int OrderNumber { get; set; }
}