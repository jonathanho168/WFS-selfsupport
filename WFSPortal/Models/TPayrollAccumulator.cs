using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayrollAccumulator")]
[Index("PayrollAccumulatorGuid", Name = "RG_tPayrollAccumulator", IsUnique = true)]
public partial class TPayrollAccumulator
{
    [Key]
    [StringLength(15)]
    public string PayrollAccumulatorCode { get; set; } = null!;

    [Column("PayrollAccumulatorGUID")]
    public Guid PayrollAccumulatorGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PayrollAccumulatorDescription { get; set; }

    [InverseProperty("PayrollAccumulatorCodeNavigation")]
    public virtual ICollection<TPayrollAccumulatorRollup> TPayrollAccumulatorRollups { get; set; } = new List<TPayrollAccumulatorRollup>();

    [InverseProperty("PayrollAccumulatorCodeNavigation")]
    public virtual ICollection<TPersonYearToDateEarning> TPersonYearToDateEarnings { get; set; } = new List<TPersonYearToDateEarning>();
}
