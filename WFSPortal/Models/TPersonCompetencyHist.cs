using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonCompetencyHist")]
[Index("PersonGuid", "CompetencyCode", "PersonCompetencyStartDate", Name = "AK_tPersonCompetencyHist", IsUnique = true)]
[Index("CompetencyCode", Name = "IX_tPersonCompetencyHist_CompetencyCode")]
public partial class TPersonCompetencyHist
{
    [Key]
    [Column("PersonCompetencyGUID")]
    public Guid PersonCompetencyGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string CompetencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonCompetencyStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonCompetencyEndDate { get; set; }

    public bool PersonCompetencyCurrentFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompetencyAcquiredDate { get; set; }

    [StringLength(15)]
    public string HowAcquiredCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CompetencyLastUsedDate { get; set; }

    [StringLength(15)]
    public string ProficiencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ProficiencyEffectiveDate { get; set; }

    [StringLength(125)]
    public string? ProficiencyAssessedBy { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string EmployeeProficiencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? EmployeeProficiencyEffectiveDate { get; set; }

    [StringLength(15)]
    public string SupervisorProficiencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? SupervisorProficiencyEffectiveDate { get; set; }

    [Column("SupervisorProficiencyAssessedByPersonGUID")]
    public Guid? SupervisorProficiencyAssessedByPersonGuid { get; set; }

    [StringLength(15)]
    public string OtherProficiencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? OtherProficiencyEffectiveDate { get; set; }

    [StringLength(125)]
    public string? OtherProficiencyAssessedBy { get; set; }

    [StringLength(80)]
    public string? CompetencyEvidence { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonGoalGUID")]
    public Guid? PersonGoalGuid { get; set; }

    [ForeignKey("CompetencyCode")]
    [InverseProperty("TPersonCompetencyHists")]
    public virtual TCompetency CompetencyCodeNavigation { get; set; } = null!;

    [ForeignKey("EmployeeProficiencyCode")]
    [InverseProperty("TPersonCompetencyHistEmployeeProficiencyCodeNavigations")]
    public virtual TProficiency EmployeeProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("HowAcquiredCode")]
    [InverseProperty("TPersonCompetencyHists")]
    public virtual THowAcquired HowAcquiredCodeNavigation { get; set; } = null!;

    [ForeignKey("OtherProficiencyCode")]
    [InverseProperty("TPersonCompetencyHistOtherProficiencyCodeNavigations")]
    public virtual TProficiency OtherProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonCompetencyHistPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonGoalGuid")]
    [InverseProperty("TPersonCompetencyHists")]
    public virtual TPersonGoal? PersonGoal { get; set; }

    [ForeignKey("ProficiencyCode")]
    [InverseProperty("TPersonCompetencyHistProficiencyCodeNavigations")]
    public virtual TProficiency ProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SupervisorProficiencyAssessedByPersonGuid")]
    [InverseProperty("TPersonCompetencyHistSupervisorProficiencyAssessedByPeople")]
    public virtual TPerson? SupervisorProficiencyAssessedByPerson { get; set; }

    [ForeignKey("SupervisorProficiencyCode")]
    [InverseProperty("TPersonCompetencyHistSupervisorProficiencyCodeNavigations")]
    public virtual TProficiency SupervisorProficiencyCodeNavigation { get; set; } = null!;
}
