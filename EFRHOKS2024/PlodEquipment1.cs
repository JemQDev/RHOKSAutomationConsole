﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2024;

public partial class PlodEquipment1
{
    public string Vehicle { get; set; }

    public DateOnly Date { get; set; }

    public string Service { get; set; }

    public string Manufacturer { get; set; }

    public string ToolType { get; set; }

    public string SerialNumber { get; set; }

    public virtual PlodHeader1 PlodHeader1 { get; set; }
}