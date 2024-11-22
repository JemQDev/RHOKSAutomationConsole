﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Connects a system wide setting with the type of Event that should be raised when changed.
/// </summary>
public partial class SettingProcessingEventType
{
    /// <summary>
    /// The context within which the setting is applicable.
    /// </summary>
    public string Context { get; set; }

    /// <summary>
    /// The name of the setting within the given context.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Name of Procesing Event to raise on modification of value.
    /// </summary>
    public string ProcessingEventTypeName { get; set; }

    public virtual Setting Setting { get; set; }
}