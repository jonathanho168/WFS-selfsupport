using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayrollVendorCompanyAccumulator")]
[Index("PayrollVendorCompanyGuid", "PayrollVendorCompanyAccumulatorCode", Name = "AK_tPayrollVendorCompanyAccumulator", IsUnique = true)]
public partial class TPayrollVendorCompanyAccumulator
{
    [Column("PayrollVendorCompanyGUID")]
    public Guid PayrollVendorCompanyGuid { get; set; }

    [StringLength(15)]
    public string PayrollVendorCompanyAccumulatorCode { get; set; } = null!;

    public string? PayrollVendorCompanyAccumulatorDescription { get; set; }

    [StringLength(15)]
    public string PayrollVendorAccumulatorTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string PayrollVendorAccumulatorFrequencyCode { get; set; } = null!;

    public bool AccumulatorImportFlag { get; set; }

    [Key]
    [Column("PayrollVendorCompanyAccumulatorGUID")]
    public Guid PayrollVendorCompanyAccumulatorGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PayrollVendorAccumulatorFrequencyCode")]
    [InverseProperty("TPayrollVendorCompanyAccumulators")]
    public virtual TPayrollVendorAccumulatorFrequency PayrollVendorAccumulatorFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PayrollVendorAccumulatorTypeCode")]
    [InverseProperty("TPayrollVendorCompanyAccumulators")]
    public virtual TPayrollVendorAccumulatorType PayrollVendorAccumulatorTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PayrollVendorCompanyGuid")]
    [InverseProperty("TPayrollVendorCompanyAccumulators")]
    public virtual TPayrollVendorCompany PayrollVendorCompany { get; set; } = null!;

    [InverseProperty("PayrollVendorCompanyAccumulator")]
    public virtual ICollection<TPayrollAccumulatorRollup> TPayrollAccumulatorRollups { get; set; } = new List<TPayrollAccumulatorRollup>();
}
