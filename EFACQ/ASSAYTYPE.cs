﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// AssayType stores the names of element. These are virtual fields and are generated and defined on site. The values or analytical results for the elements are numeric. Geological information is stored in other tables: PointGeology and GeoInterval. The data in AssayType.Name are virtual fields. These can be included when defining a form definition based upon an Assay compound definition. For example, if AssayType.Name has the following records; AuPPM, AuRpt1and AuRpt2 an Assay form definition could have the following fields: SampleID HoleID ProjectCode SampFrom SampTo SampleType â€¦ AuPPM AuRpt1 AuRpt2 Thus the user is able to define the field names for the elements assayed to meet the needs of the company, the project and/or the project commodity. This list can be added to at any time.  
/// </summary>
public partial class ASSAYTYPE
{
    public string NAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string UNITS { get; set; }

    public string ANALYSISMETHOD { get; set; }

    public string ELEMENT { get; set; }

    public double? RANK { get; set; }

    public string DIGESTDEGREE { get; set; }

    public string DIGESTTYPE { get; set; }

    public double? ANALYTICALWEIGHT { get; set; }

    public string COMMENTS { get; set; }

    public string GENERICCODE { get; set; }

    public virtual ANALYSISMETHOD ANALYSISMETHODNavigation { get; set; }

    public virtual DIGESTDEGREE DIGESTDEGREENavigation { get; set; }

    public virtual DIGESTTYPE DIGESTTYPENavigation { get; set; }

    public virtual ELEMENT ELEMENTNavigation { get; set; }

    public virtual ASSAYGENERICCODE GENERICCODENavigation { get; set; }

    public virtual UNITS UNITSNavigation { get; set; }
}