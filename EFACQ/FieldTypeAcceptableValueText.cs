﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class FieldTypeAcceptableValueText
{
    public int FieldTypeId { get; set; }

    public string Value { get; set; }

    public string Description { get; set; }

    public int OrderNumber { get; set; }

    public string Label { get; set; }

    public string GroupName { get; set; }

    public double? NumericValue { get; set; }

    public bool IsActive { get; set; }

    public virtual FieldType FieldType { get; set; }
}