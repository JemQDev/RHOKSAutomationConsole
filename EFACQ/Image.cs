﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

/// <summary>
/// Contains images that should be available to any acQuire application that uses this database.
/// </summary>
public partial class Image
{
    /// <summary>
    /// The auto incrementing integer primary key.
    /// </summary>
    public int ImageId { get; set; }

    /// <summary>
    /// The title of the image (e.g. file name or something else useful to users).
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The binary image data.
    /// </summary>
    public byte[] ImageValue { get; set; }

    /// <summary>
    /// The MIME type of the image.
    /// </summary>
    public string ImageType { get; set; }
}