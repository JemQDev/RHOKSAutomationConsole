﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the pending processing requests.
/// </summary>
public partial class ProcessingRequest
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public long ProcessingRequestId { get; set; }

    /// <summary>
    /// The Processing Type which will be processed.
    /// </summary>
    public int ProcessingTypeId { get; set; }

    /// <summary>
    /// The Processing Event Type which triggered this process request.
    /// </summary>
    public int ProcessingEventTypeId { get; set; }

    /// <summary>
    /// The Date and time the request was made.
    /// </summary>
    public DateTime RequestDatetime { get; set; }

    /// <summary>
    /// The XML details regarding the request.
    /// </summary>
    public string RequestDetails { get; set; }

    public virtual ProcessingTypeEventType ProcessingTypeEventType { get; set; }
}