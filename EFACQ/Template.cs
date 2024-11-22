﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Details the templates available including their code behind. This is for 4.x backward compatibility only.
/// </summary>
public partial class Template
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int TemplateId { get; set; }

    /// <summary>
    /// The Name of the Template.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The code to be used for this template.
    /// </summary>
    public string TemplateCode { get; set; }

    public virtual ICollection<Compound> Compound { get; set; } = new List<Compound>();
}