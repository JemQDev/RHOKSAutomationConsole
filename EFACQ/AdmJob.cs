﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Aggregate of AdmJobTasks that will be run according to a schedule.
/// </summary>
public partial class AdmJob
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int AdmJobId { get; set; }

    /// <summary>
    /// The name of the Job.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// A description of the Job.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The ID of a record in the AcqManagement.Schedule table determining when this Job will run.
    /// </summary>
    public int ScheduleId { get; set; }

    /// <summary>
    /// The last date and time the Job was run.
    /// </summary>
    public DateTime? LastStartTime { get; set; }

    /// <summary>
    /// The last date and time the Job completed successfully.
    /// </summary>
    public DateTime? LastSuccessfulTime { get; set; }

    /// <summary>
    /// Job properties in an xml format.
    /// </summary>
    public string JobProperties { get; set; }

    /// <summary>
    /// Whether an email should be sent as part of the job.
    /// </summary>
    public bool SendMail { get; set; }

    public virtual AdmJobRun AdmJobRun { get; set; }

    public virtual ICollection<AdmJobTask> AdmJobTask { get; set; } = new List<AdmJobTask>();

    public virtual Schedule Schedule { get; set; }

    public virtual ICollection<AdmMailTemplate> AdmMailTemplate { get; set; } = new List<AdmMailTemplate>();

    public virtual ICollection<Log> Log { get; set; } = new List<Log>();
}