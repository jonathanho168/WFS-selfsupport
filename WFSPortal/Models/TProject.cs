using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tProject")]
[Index("ProjectGuid", Name = "RG_tProject", IsUnique = true)]
public partial class TProject
{
    [Key]
    [StringLength(15)]
    public string ProjectCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("ProjectGUID")]
    public Guid ProjectGuid { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ProjectBudget { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? ProjectBudgetHours { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProjectClosedDate { get; set; }

    [Column("CreatedByPersonGUID")]
    public Guid? CreatedByPersonGuid { get; set; }

    [StringLength(15)]
    public string ProjectBudgetCurrencyCode { get; set; } = null!;

    public string? ProjectDescription { get; set; }

    public bool? ResidentialFlag { get; set; }

    [ForeignKey("CreatedByPersonGuid")]
    [InverseProperty("TProjects")]
    public virtual TPerson? CreatedByPerson { get; set; }

    [ForeignKey("ProjectBudgetCurrencyCode")]
    [InverseProperty("TProjects")]
    public virtual TCurrency ProjectBudgetCurrencyCodeNavigation { get; set; } = null!;

    [InverseProperty("ProjectCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("ProjectCodeNavigation")]
    public virtual ICollection<TPersonOvertimeHist> TPersonOvertimeHists { get; set; } = new List<TPersonOvertimeHist>();

    [InverseProperty("ProjectCodeNavigation")]
    public virtual ICollection<TPersonProjectHist> TPersonProjectHists { get; set; } = new List<TPersonProjectHist>();

    [InverseProperty("ProjectCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("ProjectCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
