using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayrollVendorAccumulatorType")]
public partial class TPayrollVendorAccumulatorType
{
    [Key]
    [StringLength(15)]
    public string PayrollVendorAccumulatorTypeCode { get; set; } = null!;

    public string? PayrollVendorAccumulatorTypeDescription { get; set; }

    [StringLength(15)]
    public string CurrencyCode { get; set; } = null!;

    [Column("PayrollVendorAccumulatorTypeGUID")]
    public Guid PayrollVendorAccumulatorTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CurrencyCode")]
    [InverseProperty("TPayrollVendorAccumulatorTypes")]
    public virtual TCurrency CurrencyCodeNavigation { get; set; } = null!;

    [InverseProperty("PayrollVendorAccumulatorTypeCodeNavigation")]
    public virtual ICollection<TPayrollVendorCompanyAccumulator> TPayrollVendorCompanyAccumulators { get; set; } = new List<TPayrollVendorCompanyAccumulator>();
}
