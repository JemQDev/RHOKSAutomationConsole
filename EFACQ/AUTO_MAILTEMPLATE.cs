﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details a mail template to be used when constructing an email.
/// </summary>
public partial class AUTO_MAILTEMPLATE
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int MAILTEMPLATEID { get; set; }

    /// <summary>
    /// The unique name of the mail template.
    /// </summary>
    public string NAME { get; set; }

    /// <summary>
    /// The serialized information about the mail.
    /// </summary>
    public string MAILDATA { get; set; }

    /// <summary>
    /// The event type that will trigger the mail to be sent.
    /// </summary>
    public string MAILTRIGGEREVENTTYPE { get; set; }

    public virtual ICollection<AUTO_CACHEGROUP> CACHEGROUP { get; set; } = new List<AUTO_CACHEGROUP>();

    public virtual ICollection<AUTO_JOB> JOB { get; set; } = new List<AUTO_JOB>();

    public virtual ICollection<AUTO_JOBTASK> JOBTASK { get; set; } = new List<AUTO_JOBTASK>();
}