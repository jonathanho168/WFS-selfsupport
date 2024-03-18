using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonBasePayFactTable
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string PersonBasePayCurrencyCode { get; set; } = null!;

    [StringLength(15)]
    public string PersonBasePayFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string PersonBasePayPayrollFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string PayrollCode { get; set; } = null!;

    public bool PersonBasePayCurrentFlag { get; set; }

    [Column(TypeName = "money")]
    public decimal? PersonBasePayAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBasePayStartDate { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [StringLength(15)]
    public string ScheduleCode { get; set; } = null!;

    public int? Age { get; set; }

    public int? ServiceYears { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HourlySalary { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MonthlySalary { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualSalary { get; set; }
}
