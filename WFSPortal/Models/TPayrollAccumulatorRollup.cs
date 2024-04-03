using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayrollAccumulatorRollup")]
public partial class TPayrollAccumulatorRollup
{
    [Key]
    [Column("PayrollAccumulatorRollupGUID")]
    public Guid PayrollAccumulatorRollupGuid { get; set; }

    [Column("PayrollVendorCompanyAccumulatorGUID")]
    public Guid PayrollVendorCompanyAccumulatorGuid { get; set; }

    [StringLength(15)]
    public string PayrollAccumulatorCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("PayrollAccumulatorCode")]
    [InverseProperty("TPayrollAccumulatorRollups")]
    public virtual TPayrollAccumulator PayrollAccumulatorCodeNavigation { get; set; } = null!;

    [ForeignKey("PayrollVendorCompanyAccumulatorGuid")]
    [InverseProperty("TPayrollAccumulatorRollups")]
    public virtual TPayrollVendorCompanyAccumulator PayrollVendorCompanyAccumulator { get; set; } = null!;
}
