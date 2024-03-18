using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayrollVendorAccumulatorFrequency")]
public partial class TPayrollVendorAccumulatorFrequency
{
    [Key]
    [StringLength(15)]
    public string PayrollVendorAccumulatorFrequencyCode { get; set; } = null!;

    public string? PayrollVendorAccumulatorFrequencyDescription { get; set; }

    [Column("PayrollVendorAccumulatorFrequencyGUID")]
    public Guid PayrollVendorAccumulatorFrequencyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("PayrollVendorAccumulatorFrequencyCodeNavigation")]
    public virtual ICollection<TPayrollVendorCompanyAccumulator> TPayrollVendorCompanyAccumulators { get; set; } = new List<TPayrollVendorCompanyAccumulator>();
}
