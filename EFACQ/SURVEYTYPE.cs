﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// SurveyType stores particulars about the method or the instrument used for the survey - Eastman, Maxibore, Gyro and so on. The RANK of a survey type can be used to preferentially select data. For explanation of rank in a similar context refer to the page on AssayType Rank. 
/// </summary>
public partial class SURVEYTYPE
{
    public string SURVTYPE { get; set; }

    public string DESCRIPTION { get; set; }

    public int? RANK { get; set; }

    public byte? ACTIVE { get; set; }

    public virtual ICollection<HOLESURVEY> HOLESURVEY { get; set; } = new List<HOLESURVEY>();
}