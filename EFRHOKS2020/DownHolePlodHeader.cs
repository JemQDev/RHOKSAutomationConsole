﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2020;

public partial class DownHolePlodHeader
{
    public string DHPH_PlodId { get; set; }

    public string DHPH_Client { get; set; }

    public string DHPH_Operation { get; set; }

    public string DHPH_Lease { get; set; }

    public string DHPH_Location { get; set; }

    public DateOnly DHPH_Date { get; set; }

    public string DHPH_Operator { get; set; }

    public string DHPH_VehicleID { get; set; }

    public string DHPH_ChargeBasis { get; set; }

    public bool? DHPH_Valid { get; set; }

    public string DHPH_Filename { get; set; }

    public virtual DownholePlodVehicle DHPH_Vehicle { get; set; }

    public virtual ICollection<DownholePlodData> DownholePlodData { get; set; } = new List<DownholePlodData>();

    public virtual ICollection<DownholePlodEquipmentOnsite> DownholePlodEquipmentOnsite { get; set; } = new List<DownholePlodEquipmentOnsite>();

    public virtual ICollection<DownholePlodHeaderError> DownholePlodHeaderError { get; set; } = new List<DownholePlodHeaderError>();
}