﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Aggregate of AdmJobTasks that will be run according to a schedule.
/// </summary>
public partial class AUTO_JOB
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int JOBID { get; set; }

    /// <summary>
    /// The name of the Job.
    /// </summary>
    public string LABEL { get; set; }

    /// <summary>
    /// A description of the Job.
    /// </summary>
    public string DESCRIPTION { get; set; }

    /// <summary>
    /// The ID of a record in the AcqManagement.Schedule table determining when this Job will run.
    /// </summary>
    public int SCHEDULEID { get; set; }

    /// <summary>
    /// The last date and time the Job was run.
    /// </summary>
    public DateTime? LASTSTARTTIME { get; set; }

    /// <summary>
    /// The last date and time the Job completed successfully.
    /// </summary>
    public DateTime? LASTSUCCESSFULTIME { get; set; }

    /// <summary>
    /// Job properties in an xml format.
    /// </summary>
    public string JOBPROPERTIES { get; set; }

    /// <summary>
    /// Whether an email should be sent as part of the job.
    /// </summary>
    public bool SENDMAIL { get; set; }

    public virtual AUTO_JOBRUN AUTO_JOBRUN { get; set; }

    public virtual ICollection<AUTO_JOBTASK> AUTO_JOBTASK { get; set; } = new List<AUTO_JOBTASK>();

    public virtual AUTO_SCHEDULE SCHEDULE { get; set; }

    public virtual ICollection<AUTO_LOG> LOG { get; set; } = new List<AUTO_LOG>();

    public virtual ICollection<AUTO_MAILTEMPLATE> MAILTEMPLATE { get; set; } = new List<AUTO_MAILTEMPLATE>();
}