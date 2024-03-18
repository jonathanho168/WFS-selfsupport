using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonCertificationFactTable
{
    [Column("PersonCertificationGUID")]
    public Guid PersonCertificationGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string CertificationCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AchievedDate { get; set; }

    public int? AchievedDateYear { get; set; }

    public int? AchievedDateQuarter { get; set; }

    public int? AchievedDateMonth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    public int? ExpirationDateYear { get; set; }

    public int? ExpirationDateQuarter { get; set; }

    public int? ExpirationDateMonth { get; set; }

    public int ExpiredFlag { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public int? Age { get; set; }

    public int? NumberOfServiceYears { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HourlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MonthlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualRate { get; set; }
}
