using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonYearToDateEarnings")]
public partial class TPersonYearToDateEarning
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public short? Year { get; set; }

    [StringLength(15)]
    public string PayrollAccumulatorCode { get; set; } = null!;

    public byte? Period { get; set; }

    [StringLength(15)]
    public string PayrollCode { get; set; } = null!;

    [StringLength(15)]
    public string PersonYearToDateEarningsCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? CurrentAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? MonthToDateAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? QuarterToDateAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? YearToDateAmount { get; set; }

    [Key]
    [Column("PersonYearToDateEarningsGUID")]
    public Guid PersonYearToDateEarningsGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public bool ArchivedFlag { get; set; }

    [ForeignKey("PayrollAccumulatorCode")]
    [InverseProperty("TPersonYearToDateEarnings")]
    public virtual TPayrollAccumulator PayrollAccumulatorCodeNavigation { get; set; } = null!;

    [ForeignKey("PayrollCode")]
    [InverseProperty("TPersonYearToDateEarnings")]
    public virtual TPayroll PayrollCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonYearToDateEarnings")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonYearToDateEarningsCurrencyCode")]
    [InverseProperty("TPersonYearToDateEarnings")]
    public virtual TCurrency PersonYearToDateEarningsCurrencyCodeNavigation { get; set; } = null!;
}
