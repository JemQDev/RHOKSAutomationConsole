﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// PointGeology was designed to store geological information associated with point samples (geochemical and geotechnical samples for example) or for drilling where both the geological and assay sampling intervals are both the same (for example, production RC drilling).  This table is part of the compound definitions PointSample (for HoleIDs with a HoleType=GEOCHEM) and SampleGeoAssay (for HoleIDs with a HoleType=DRILLHOLE). Where the geological and assay sampling intervals differ, the drillhole geology is stored in GeoInterval. The primary keys are SampleID and Name. Value is a required field. 
/// </summary>
public partial class POINTGEOLOGY
{
    public string SAMPLEID { get; set; }

    public string NAME { get; set; }

    public string VALUE { get; set; }

    public virtual GEOLOGYCODESECONDARY NAMENavigation { get; set; }
}