using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayrollVendorCompany")]
[Index("VendorCode", "PayrollVendorCompanyCode", Name = "AK_tPayrollVendorCompany", IsUnique = true)]
public partial class TPayrollVendorCompany
{
    [StringLength(15)]
    public string VendorCode { get; set; } = null!;

    [StringLength(15)]
    public string PayrollVendorCompanyCode { get; set; } = null!;

    public string? PayrollVendorCompanyDescription { get; set; }

    [Key]
    [Column("PayrollVendorCompanyGUID")]
    public Guid PayrollVendorCompanyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string PayrollCode { get; set; } = null!;

    [ForeignKey("PayrollCode")]
    [InverseProperty("TPayrollVendorCompanies")]
    public virtual TPayroll PayrollCodeNavigation { get; set; } = null!;

    [InverseProperty("PayrollVendorCompany")]
    public virtual ICollection<TPayrollVendorCompanyAccumulator> TPayrollVendorCompanyAccumulators { get; set; } = new List<TPayrollVendorCompanyAccumulator>();

    [InverseProperty("PayrollVendorCompany")]
    public virtual ICollection<UsysLnkImportGroupAssignment> UsysLnkImportGroupAssignments { get; set; } = new List<UsysLnkImportGroupAssignment>();

    [ForeignKey("VendorCode")]
    [InverseProperty("TPayrollVendorCompanies")]
    public virtual TVendor VendorCodeNavigation { get; set; } = null!;
}
