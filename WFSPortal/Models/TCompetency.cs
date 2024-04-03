using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCompetency")]
[Index("CompetencyGuid", Name = "RG_tCompetency", IsUnique = true)]
public partial class TCompetency
{
    [Key]
    [StringLength(15)]
    public string CompetencyCode { get; set; } = null!;

    [StringLength(15)]
    public string FunctionalAreaCode { get; set; } = null!;

    [Column("CompetencyGUID")]
    public Guid CompetencyGuid { get; set; }

    [StringLength(15)]
    public string ScaleCode { get; set; } = null!;

    [StringLength(15)]
    public string CompetencyClusterCode { get; set; } = null!;

    [StringLength(15)]
    public string CompetencyCategoryCode { get; set; } = null!;

    [StringLength(80)]
    public string? CompetencyAuthority { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CompetencyDescription { get; set; }

    public string? ExpandedDescription { get; set; }

    [ForeignKey("CompetencyCategoryCode")]
    [InverseProperty("TCompetencies")]
    public virtual TCompetencyCategory CompetencyCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("CompetencyClusterCode")]
    [InverseProperty("TCompetencies")]
    public virtual TCompetencyCluster CompetencyClusterCodeNavigation { get; set; } = null!;

    [ForeignKey("FunctionalAreaCode")]
    [InverseProperty("TCompetencies")]
    public virtual TFunctionalArea FunctionalAreaCodeNavigation { get; set; } = null!;

    [ForeignKey("ScaleCode")]
    [InverseProperty("TCompetencies")]
    public virtual TScale ScaleCodeNavigation { get; set; } = null!;

    [InverseProperty("AlternateCompetencyCodeNavigation")]
    public virtual ICollection<TAlternateCompetency> TAlternateCompetencyAlternateCompetencyCodeNavigations { get; set; } = new List<TAlternateCompetency>();

    [InverseProperty("CompetencyCodeNavigation")]
    public virtual ICollection<TAlternateCompetency> TAlternateCompetencyCompetencyCodeNavigations { get; set; } = new List<TAlternateCompetency>();

    [InverseProperty("CompetencyCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("CompetencyCodeNavigation")]
    public virtual ICollection<TCourseCompetency> TCourseCompetencies { get; set; } = new List<TCourseCompetency>();

    [InverseProperty("CompetencyCodeNavigation")]
    public virtual ICollection<TJobCompetency> TJobCompetencies { get; set; } = new List<TJobCompetency>();

    [InverseProperty("CompetencyCodeNavigation")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHists { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("CompetencyCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [InverseProperty("CompetencyCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();

    [InverseProperty("CompetencyCodeNavigation")]
    public virtual ICollection<TTrainingProgramCompetency> TTrainingProgramCompetencies { get; set; } = new List<TTrainingProgramCompetency>();
}
