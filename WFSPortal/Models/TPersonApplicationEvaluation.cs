using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonApplicationEvaluation")]
public partial class TPersonApplicationEvaluation
{
    [Key]
    [Column("PersonApplicationEvaluationGUID")]
    public Guid PersonApplicationEvaluationGuid { get; set; }

    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EvaluationDate { get; set; }

    [StringLength(15)]
    public string EvaluationResultCode { get; set; } = null!;

    [StringLength(15)]
    public string EvaluationTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string EvaluatorCode { get; set; } = null!;

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledEvaluationDate { get; set; }

    [Column("ScheduledEvaluatorPersonGUID")]
    public Guid? ScheduledEvaluatorPersonGuid { get; set; }

    [Column("EvaluatorPersonGUID")]
    public Guid? EvaluatorPersonGuid { get; set; }

    public int? ScheduledEvaluationDuration { get; set; }

    [StringLength(40)]
    public string? ScheduledEvaluationLocation { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? EvaluationScore { get; set; }

    public string? ProfessionalLicense { get; set; }

    [Column("MVR")]
    public string? Mvr { get; set; }

    [Column("ACT168")]
    public string? Act168 { get; set; }

    public string? ScreeningNotes { get; set; }

    [Column("OIGResults_CompleteClear")]
    public bool? OigresultsCompleteClear { get; set; }

    [Column("OIGResults_Sanction")]
    public bool? OigresultsSanction { get; set; }

    [Column("OIGDate", TypeName = "datetime")]
    public DateTime? Oigdate { get; set; }

    [Column("EPLS_SAMResults_CompleteClear")]
    public bool? EplsSamresultsCompleteClear { get; set; }

    [Column("EPLS_SAMResults_Sanction")]
    public bool? EplsSamresultsSanction { get; set; }

    [Column("EPLS_SAMResultsDate", TypeName = "datetime")]
    public DateTime? EplsSamresultsDate { get; set; }

    [Column("PAMedicheck_CompleteClear")]
    public bool? PamedicheckCompleteClear { get; set; }

    [Column("PAMedicheck_Sanction")]
    public bool? PamedicheckSanction { get; set; }

    [Column("PAMedicheckDate", TypeName = "datetime")]
    public DateTime? PamedicheckDate { get; set; }

    [Column("ProfLicenseCertification_CompleteClear")]
    public bool? ProfLicenseCertificationCompleteClear { get; set; }

    [Column("ProfLicenseCertification_Sanction")]
    public bool? ProfLicenseCertificationSanction { get; set; }

    [Column("ProfLicenseCertification_NA")]
    public bool? ProfLicenseCertificationNa { get; set; }

    [Column("ProfLicenseCertification_Date", TypeName = "datetime")]
    public DateTime? ProfLicenseCertificationDate { get; set; }

    [StringLength(30)]
    public string? EmployerContact { get; set; }

    [StringLength(80)]
    public string? EmployerContactTitle { get; set; }

    [Column("PersonApplicationStatusGUID")]
    public Guid? PersonApplicationStatusGuid { get; set; }

    [ForeignKey("EvaluationResultCode")]
    [InverseProperty("TPersonApplicationEvaluations")]
    public virtual TEvaluationResult EvaluationResultCodeNavigation { get; set; } = null!;

    [ForeignKey("EvaluationTypeCode")]
    [InverseProperty("TPersonApplicationEvaluations")]
    public virtual TEvaluationType EvaluationTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("EvaluatorCode")]
    [InverseProperty("TPersonApplicationEvaluations")]
    public virtual TEvaluator EvaluatorCodeNavigation { get; set; } = null!;

    [ForeignKey("EvaluatorPersonGuid")]
    [InverseProperty("TPersonApplicationEvaluationEvaluatorPeople")]
    public virtual TPerson? EvaluatorPerson { get; set; }

    [ForeignKey("PersonApplicationGuid")]
    [InverseProperty("TPersonApplicationEvaluations")]
    public virtual TPersonApplication PersonApplication { get; set; } = null!;

    [ForeignKey("PersonApplicationStatusGuid")]
    [InverseProperty("TPersonApplicationEvaluations")]
    public virtual TPersonApplicationStatusHist? PersonApplicationStatus { get; set; }

    [ForeignKey("ScheduledEvaluatorPersonGuid")]
    [InverseProperty("TPersonApplicationEvaluationScheduledEvaluatorPeople")]
    public virtual TPerson? ScheduledEvaluatorPerson { get; set; }
}
