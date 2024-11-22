﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFRHOKS2020;

public partial class IRLASHeader
{
    public string IRGPH_Drillhole { get; set; }

    public string IRGPH_Mine { get; set; }

    public string IRGPH_LASVersion { get; set; }

    public bool IRGPH_Wrapped { get; set; }

    public decimal IRGPH_StartDepth { get; set; }

    public string IRGPH_StartDepthUnits { get; set; }

    public decimal IRGPH_StopDepth { get; set; }

    public string IRGPH_StopDepthUnits { get; set; }

    public decimal IRGPH_StepDepth { get; set; }

    public string IRGPH_StepDepthUnits { get; set; }

    public string IRGPH_ServiceCompany { get; set; }

    public DateOnly IRGPH_SurveyDate { get; set; }

    public string IRGPH_TargetCompany { get; set; }

    public string IRGPH_FieldName { get; set; }

    public string IRGPH_Province { get; set; }

    public string IRGPH_LicenceNumber { get; set; }

    public string IRGPH_State { get; set; }

    public string IRGPH_Location { get; set; }

    public string IRGPH_County { get; set; }

    public string IRGPH_SurveyType { get; set; }

    public virtual ICollection<IRLASCurves> IRLASCurves { get; set; } = new List<IRLASCurves>();

    public virtual ICollection<IRLASHeaderDetails> IRLASHeaderDetails { get; set; } = new List<IRLASHeaderDetails>();

    public virtual ICollection<IRLASReadings> IRLASReadings { get; set; } = new List<IRLASReadings>();
}