using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlanStatus")]
[Index("SalaryPlanStatusGuid", Name = "RG_USysSalaryPlanStatus", IsUnique = true)]
public partial class UsysSalaryPlanStatus
{
    [Key]
    [StringLength(15)]
    public string SalaryPlanStatusCode { get; set; } = null!;

    [Column("SalaryPlanStatusGUID")]
    public Guid SalaryPlanStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? SalaryPlanStatusDescription { get; set; }

    [InverseProperty("SalaryPlanStatusCodeNavigation")]
    public virtual ICollection<UsysSalaryPlan> UsysSalaryPlans { get; set; } = new List<UsysSalaryPlan>();
}
