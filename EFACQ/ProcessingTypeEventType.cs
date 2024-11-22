﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Associates all processing event types which can trigger a process with those processes.
/// </summary>
public partial class ProcessingTypeEventType
{
    /// <summary>
    /// The primary key of the process type which will be triggered when the given processing event type is raised.
    /// </summary>
    public int ProcessingTypeId { get; set; }

    /// <summary>
    /// The primary key of the processing event type which triggers the given process type.
    /// </summary>
    public int ProcessingEventTypeId { get; set; }

    /// <summary>
    /// The priority of the given processing event type as it applies to the given processing type.
    /// </summary>
    public int ProcessingEventTypePriority { get; set; }

    public virtual AdmProcessingTypeEventType AdmProcessingTypeEventType { get; set; }

    public virtual ProcessingEventType ProcessingEventType { get; set; }

    public virtual ICollection<ProcessingRequest> ProcessingRequest { get; set; } = new List<ProcessingRequest>();

    public virtual ProcessingType ProcessingType { get; set; }
}