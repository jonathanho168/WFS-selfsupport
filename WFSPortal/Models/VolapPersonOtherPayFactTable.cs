using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonOtherPayFactTable
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string OtherPayTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonOtherPayStartDate { get; set; }

    [StringLength(15)]
    public string OtherPayReasonCode { get; set; } = null!;

    public bool PersonOtherPayCurrentFlag { get; set; }

    [Column(TypeName = "money")]
    public decimal? PersonOtherPayAmount { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int? Age { get; set; }

    public int? ServiceYears { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HourlySalary { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MonthlySalary { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualSalary { get; set; }
}
