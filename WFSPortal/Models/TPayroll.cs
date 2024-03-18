using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayroll")]
[Index("PayrollGuid", Name = "RG_tPayroll", IsUnique = true)]
public partial class TPayroll
{
    [Key]
    [StringLength(15)]
    public string PayrollCode { get; set; } = null!;

    [Column("PayrollGUID")]
    public Guid PayrollGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PayrollDescription { get; set; }

    [InverseProperty("PayrollCodeNavigation")]
    public virtual ICollection<TPayrollVendorCompany> TPayrollVendorCompanies { get; set; } = new List<TPayrollVendorCompany>();

    [InverseProperty("PayrollCodeNavigation")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHists { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("PayrollCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHists { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("PayrollCodeNavigation")]
    public virtual ICollection<TPersonYearToDateEarning> TPersonYearToDateEarnings { get; set; } = new List<TPersonYearToDateEarning>();
}
