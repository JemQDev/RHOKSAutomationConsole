﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2020;

public partial class DownholePlodVehicle
{
    public string DPV_VehicleID { get; set; }

    public bool DPV_Active { get; set; }

    public virtual ICollection<DownHolePlodHeader> DownHolePlodHeader { get; set; } = new List<DownHolePlodHeader>();
}