using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonFutureEnrollment")]
[Index("PersonFutureEnrollmentStatusGuid", "EnrollFlag", Name = "WFS_tPersonFutureEnrollment_Open_Enrollment")]
public partial class TPersonFutureEnrollment
{
    [Key]
    [Column("PersonFutureEnrollmentGUID")]
    public Guid PersonFutureEnrollmentGuid { get; set; }

    [Column("PersonFutureEnrollmentStatusGUID")]
    public Guid PersonFutureEnrollmentStatusGuid { get; set; }

    [Column("EnrolledPersonGUID")]
    public Guid EnrolledPersonGuid { get; set; }

    [StringLength(15)]
    public string StartBenefitStatusCode { get; set; } = null!;

    [StringLength(15)]
    public string EndBenefitStatusCode { get; set; } = null!;

    public bool TobaccoUserOriginalFlag { get; set; }

    public bool ConsideredTobaccoUserOriginalFlag { get; set; }

    public bool ConsideredTobaccoUserFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? NumericValue1Original { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? NumericValue1 { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? NumericValue2Original { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? NumericValue2 { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? NumericValue3Original { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? NumericValue3 { get; set; }

    [StringLength(255)]
    public string? TextValue1Original { get; set; }

    [StringLength(255)]
    public string? TextValue1 { get; set; }

    [StringLength(255)]
    public string? TextValue2Original { get; set; }

    [StringLength(255)]
    public string? TextValue2 { get; set; }

    [StringLength(255)]
    public string? TextValue3Original { get; set; }

    [StringLength(255)]
    public string? TextValue3 { get; set; }

    public bool EnrollOriginalFlag { get; set; }

    public bool EnrollFlag { get; set; }

    public bool SelectionApprovedFlag { get; set; }

    [StringLength(15)]
    public string BenefitFutureEnrollmentStatusCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? CoverageAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeeContributionAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployerContributionAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? FlexCreditAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ImputedAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? PremiumAmount { get; set; }

    public string? ProcessedResult { get; set; }

    [Column("ResponsiblePersonGUID")]
    public Guid ResponsiblePersonGuid { get; set; }

    [StringLength(15)]
    public string PrimaryPhysicianCodeOriginal { get; set; } = null!;

    [StringLength(15)]
    public string PrimaryPhysicianCode { get; set; } = null!;

    public byte? FixedAge { get; set; }

    public byte? FixedAgeOriginal { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeePreTaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeePostTaxAmount { get; set; }

    [StringLength(15)]
    public string BenefitWaiveReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitWaiveReasonCodeOriginal { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? CoverageAmountOriginal { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeeContributionAmountOriginal { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployerContributionAmountOriginal { get; set; }

    [ForeignKey("BenefitFutureEnrollmentStatusCode")]
    [InverseProperty("TPersonFutureEnrollments")]
    public virtual TBenefitFutureEnrollmentStatus BenefitFutureEnrollmentStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TPersonFutureEnrollments")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [ForeignKey("BenefitWaiveReasonCode")]
    [InverseProperty("TPersonFutureEnrollmentBenefitWaiveReasonCodeNavigations")]
    public virtual TBenefitWaiveReason BenefitWaiveReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("BenefitWaiveReasonCodeOriginal")]
    [InverseProperty("TPersonFutureEnrollmentBenefitWaiveReasonCodeOriginalNavigations")]
    public virtual TBenefitWaiveReason BenefitWaiveReasonCodeOriginalNavigation { get; set; } = null!;

    [ForeignKey("EndBenefitStatusCode")]
    [InverseProperty("TPersonFutureEnrollmentEndBenefitStatusCodeNavigations")]
    public virtual TBenefitStatus EndBenefitStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("EnrolledPersonGuid")]
    [InverseProperty("TPersonFutureEnrollmentEnrolledPeople")]
    public virtual TPerson EnrolledPerson { get; set; } = null!;

    [ForeignKey("PersonFutureEnrollmentStatusGuid")]
    [InverseProperty("TPersonFutureEnrollments")]
    public virtual TPersonFutureEnrollmentStatus PersonFutureEnrollmentStatus { get; set; } = null!;

    [ForeignKey("PrimaryPhysicianCode")]
    [InverseProperty("TPersonFutureEnrollmentPrimaryPhysicianCodeNavigations")]
    public virtual TPhysician PrimaryPhysicianCodeNavigation { get; set; } = null!;

    [ForeignKey("PrimaryPhysicianCodeOriginal")]
    [InverseProperty("TPersonFutureEnrollmentPrimaryPhysicianCodeOriginalNavigations")]
    public virtual TPhysician PrimaryPhysicianCodeOriginalNavigation { get; set; } = null!;

    [ForeignKey("ResponsiblePersonGuid")]
    [InverseProperty("TPersonFutureEnrollmentResponsiblePeople")]
    public virtual TPerson ResponsiblePerson { get; set; } = null!;

    [ForeignKey("StartBenefitStatusCode")]
    [InverseProperty("TPersonFutureEnrollmentStartBenefitStatusCodeNavigations")]
    public virtual TBenefitStatus StartBenefitStatusCodeNavigation { get; set; } = null!;

    [InverseProperty("PersonFutureEnrollment")]
    public virtual ICollection<TPersonFutureEnrollmentBeneficiary> TPersonFutureEnrollmentBeneficiaries { get; set; } = new List<TPersonFutureEnrollmentBeneficiary>();
}
