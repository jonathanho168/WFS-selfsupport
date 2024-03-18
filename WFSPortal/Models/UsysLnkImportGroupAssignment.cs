using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportGroupAssignment")]
public partial class UsysLnkImportGroupAssignment
{
    [StringLength(15)]
    public string ImportGroupCode { get; set; } = null!;

    [Column("PayrollVendorCompanyGUID")]
    public Guid? PayrollVendorCompanyGuid { get; set; }

    [Key]
    [Column("LnkImportGroupAssignmentGUID")]
    public Guid LnkImportGroupAssignmentGuid { get; set; }

    public int? RowVersion { get; set; }

    [ForeignKey("ImportGroupCode")]
    [InverseProperty("UsysLnkImportGroupAssignments")]
    public virtual UsysLnkImportGroup ImportGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("PayrollVendorCompanyGuid")]
    [InverseProperty("UsysLnkImportGroupAssignments")]
    public virtual TPayrollVendorCompany? PayrollVendorCompany { get; set; }
}
