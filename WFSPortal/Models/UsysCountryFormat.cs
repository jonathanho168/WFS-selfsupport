using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCountryFormat")]
public partial class UsysCountryFormat
{
    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(20)]
    public string FormatType { get; set; } = null!;

    [StringLength(200)]
    public string? FormatExample { get; set; }

    [StringLength(80)]
    public string? FormatLabel { get; set; }

    public bool? FormatSuppressFlag { get; set; }

    [StringLength(80)]
    public string? FormatDefaultValue { get; set; }

    [Key]
    [Column("CountryFormatGUID")]
    public Guid CountryFormatGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("UsysCountryFormats")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;
}
