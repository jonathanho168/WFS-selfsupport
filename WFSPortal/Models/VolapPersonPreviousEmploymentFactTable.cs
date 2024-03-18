using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonPreviousEmploymentFactTable
{
    [Column("PersonEmploymentGUID")]
    public Guid PersonEmploymentGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    public int? Age { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonEmploymentStartDate { get; set; }

    public int? PreviousStartYear { get; set; }

    public int? PreviousStartQuarter { get; set; }

    public int? PreviousStartMonth { get; set; }

    [StringLength(80)]
    public string? CompanyName { get; set; }

    [StringLength(15)]
    public string DepartureReasonCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? EndingPay { get; set; }

    [StringLength(15)]
    public string EndingPayFrequencyCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? PreviousAnnualSalary { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? PreviousMonthlySalary { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? PreviousHourlySalary { get; set; }

    public int? PreviousServiceYears { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }
}
