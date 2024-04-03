using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDepartment")]
[Index("DepartmentGuid", Name = "RG_tDepartment", IsUnique = true)]
public partial class TDepartment
{
    [Key]
    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("DepartmentGUID")]
    public Guid DepartmentGuid { get; set; }

    public int RowVersion { get; set; }

    public string? DepartmentDescription { get; set; }

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<TIncident> TIncidents { get; set; } = new List<TIncident>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<TPersonIncident> TPersonIncidents { get; set; } = new List<TPersonIncident>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("TempDepartmentCodeNavigation")]
    public virtual ICollection<TPersonOvertimeHist> TPersonOvertimeHists { get; set; } = new List<TPersonOvertimeHist>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("CostDepartmentCodeNavigation")]
    public virtual ICollection<TPersonTraining> TPersonTrainingCostDepartmentCodeNavigations { get; set; } = new List<TPersonTraining>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<TPersonTrainingExpense> TPersonTrainingExpenses { get; set; } = new List<TPersonTrainingExpense>();

    [InverseProperty("TuitionDepartmentCodeNavigation")]
    public virtual ICollection<TPersonTraining> TPersonTrainingTuitionDepartmentCodeNavigations { get; set; } = new List<TPersonTraining>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<TRequisition> TRequisitions { get; set; } = new List<TRequisition>();
}
