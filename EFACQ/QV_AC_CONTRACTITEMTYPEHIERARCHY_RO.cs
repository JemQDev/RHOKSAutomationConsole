﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RHOKSAutomationConsole.EFACQ;

public partial class QV_AC_CONTRACTITEMTYPEHIERARCHY_RO
{
    /// <summary>
    /// The unique identifier for the actual contract item type.
    /// </summary>
    public string CONTRACTITEMTYPECODE { get; set; }

    /// <summary>
    /// Bit flag to identify contract item types that can be charged pro rata.
    /// </summary>
    public byte? CANPRORATA { get; set; }

    /// <summary>
    /// The unique identifier for the parent of this contract item type.
    /// </summary>
    public string PARENTCONTRACTITEMTYPECODE { get; set; }

    /// <summary>
    /// Whether or not the contract item type is defined for range data.
    /// </summary>
    public byte? ISRANGEDATA { get; set; }

    /// <summary>
    /// The value used for contract item types that are defined for point data rather than range data.
    /// </summary>
    public double? SINGLEVALUE { get; set; }

    /// <summary>
    /// The value used for contract item types that expect text data.
    /// </summary>
    public string TEXTVALUE { get; set; }

    /// <summary>
    /// The start of a range used for contract item types that are defined for range data.
    /// </summary>
    public double? STARTVALUE { get; set; }

    /// <summary>
    /// The end of a range used for contract item types that are defined for range data.
    /// </summary>
    public double? ENDVALUE { get; set; }

    /// <summary>
    /// A description of this contract item type.
    /// </summary>
    public string DESCRIPTION { get; set; }

    /// <summary>
    /// A unique identifier for the top level of the contract item type that effectively identifies the whole contract item type hierarchy.
    /// </summary>
    public string TOPLEVELCODE { get; set; }

    /// <summary>
    /// The units used by the contract item type.
    /// </summary>
    public string UNITS { get; set; }

    /// <summary>
    /// The unique identifying name for the contract item type group of the contract item type.
    /// </summary>
    public string GROUPNAME { get; set; }

    /// <summary>
    /// The level of the contract item type within hierarchy.
    /// </summary>
    public int? LEVEL { get; set; }

    public byte? ISBOTTOMLEVEL { get; set; }
}