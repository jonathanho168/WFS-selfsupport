using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlanPerson")]
public partial class UsysSalaryPlanPerson
{
    [Key]
    [Column("SalaryPlanPersonGUID")]
    public Guid SalaryPlanPersonGuid { get; set; }

    [Column("SalaryPlanGUID")]
    public Guid SalaryPlanGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysSalaryPlanPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("UsysSalaryPlanPeople")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("SalaryPlanGuid")]
    [InverseProperty("UsysSalaryPlanPeople")]
    public virtual UsysSalaryPlan SalaryPlan { get; set; } = null!;

    [InverseProperty("SalaryPlanPerson")]
    public virtual ICollection<UsysSalaryPlanBasePayPersonDetail> UsysSalaryPlanBasePayPersonDetails { get; set; } = new List<UsysSalaryPlanBasePayPersonDetail>();

    [InverseProperty("SalaryPlanPerson")]
    public virtual ICollection<UsysSalaryPlanOtherPayPersonDetail> UsysSalaryPlanOtherPayPersonDetails { get; set; } = new List<UsysSalaryPlanOtherPayPersonDetail>();
}
