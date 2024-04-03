using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJob")]
[Index("JobGuid", Name = "RG_tJob", IsUnique = true)]
public partial class TJob
{
    [Key]
    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string? AlternateJobCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EvaluationPoints { get; set; }

    [Column("EEOCategoryCode")]
    [StringLength(15)]
    public string EeocategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string JobCategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string JobFamilyCode { get; set; } = null!;

    [StringLength(15)]
    public string JobGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string OvertimeStatusCode { get; set; } = null!;

    [StringLength(15)]
    public string GradeCode { get; set; } = null!;

    [StringLength(15)]
    public string WorkersCompensationCode { get; set; } = null!;

    [StringLength(15)]
    public string JobReportsToJobCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("JobGUID")]
    public Guid JobGuid { get; set; }

    [StringLength(15)]
    public string OrgPublisherPositionTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? JobTitle { get; set; }

    [Column("EEACategoryCode")]
    [StringLength(15)]
    public string EeacategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string? JobTimeGroupCode { get; set; }

    [ForeignKey("EeacategoryCode")]
    [InverseProperty("TJobs")]
    public virtual TEeacategory EeacategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("EeocategoryCode")]
    [InverseProperty("TJobs")]
    public virtual TEeocategory EeocategoryCodeNavigation { get; set; } = null!;

    [InverseProperty("JobReportsToJobCodeNavigation")]
    public virtual ICollection<TJob> InverseJobReportsToJobCodeNavigation { get; set; } = new List<TJob>();

    [ForeignKey("JobCategoryCode")]
    [InverseProperty("TJobs")]
    public virtual TJobCategory JobCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("JobFamilyCode")]
    [InverseProperty("TJobs")]
    public virtual TJobFamily JobFamilyCodeNavigation { get; set; } = null!;

    [ForeignKey("JobGroupCode")]
    [InverseProperty("TJobs")]
    public virtual TJobGroup JobGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("JobReportsToJobCode")]
    [InverseProperty("InverseJobReportsToJobCodeNavigation")]
    public virtual TJob JobReportsToJobCodeNavigation { get; set; } = null!;

    [ForeignKey("JobTimeGroupCode")]
    [InverseProperty("TJobs")]
    public virtual TTimeGroup? JobTimeGroupCodeNavigation { get; set; }

    [ForeignKey("OrgPublisherPositionTypeCode")]
    [InverseProperty("TJobs")]
    public virtual TOrgPublisherPositionType OrgPublisherPositionTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("OvertimeStatusCode")]
    [InverseProperty("TJobs")]
    public virtual TOvertimeStatus OvertimeStatusCodeNavigation { get; set; } = null!;

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TJobCertification> TJobCertifications { get; set; } = new List<TJobCertification>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TJobCompetency> TJobCompetencies { get; set; } = new List<TJobCompetency>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TJobCourse> TJobCourses { get; set; } = new List<TJobCourse>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TJobDescription> TJobDescriptions { get; set; } = new List<TJobDescription>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TJobLanguage> TJobLanguages { get; set; } = new List<TJobLanguage>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TJobTrainingProgram> TJobTrainingPrograms { get; set; } = new List<TJobTrainingProgram>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TPerformanceQuestionJob> TPerformanceQuestionJobs { get; set; } = new List<TPerformanceQuestionJob>();

    [InverseProperty("FirstReportCompletedByPersonJobCodeNavigation")]
    public virtual ICollection<TPersonIncident> TPersonIncidentFirstReportCompletedByPersonJobCodeNavigations { get; set; } = new List<TPersonIncident>();

    [InverseProperty("RegularJobCodeNavigation")]
    public virtual ICollection<TPersonIncident> TPersonIncidentRegularJobCodeNavigations { get; set; } = new List<TPersonIncident>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHists { get; set; } = new List<TPersonJobHist>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TPersonNomination> TPersonNominations { get; set; } = new List<TPersonNomination>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TPersonPerformanceHist> TPersonPerformanceHists { get; set; } = new List<TPersonPerformanceHist>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TRequisition> TRequisitions { get; set; } = new List<TRequisition>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TSurveyDatum> TSurveyData { get; set; } = new List<TSurveyDatum>();

    [InverseProperty("JobCodeNavigation")]
    public virtual ICollection<TSurveyFilterSetJob> TSurveyFilterSetJobs { get; set; } = new List<TSurveyFilterSetJob>();

    [ForeignKey("WorkersCompensationCode")]
    [InverseProperty("TJobs")]
    public virtual TWorkersCompensation WorkersCompensationCodeNavigation { get; set; } = null!;
}
