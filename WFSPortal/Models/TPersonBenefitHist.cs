using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBenefitHist")]
public partial class TPersonBenefitHist
{
    [Key]
    [Column("PersonBenefitHistGUID")]
    public Guid PersonBenefitHistGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EligibilityDate { get; set; }

    [StringLength(15)]
    public string StartBenefitStatusCode { get; set; } = null!;

    [StringLength(15)]
    public string EndBenefitStatusCode { get; set; } = null!;

    public bool CalculateContributionFlag { get; set; }

    [Column("COBRAFlag")]
    public bool Cobraflag { get; set; }

    [Column("COBRAEndOfMonthFlag")]
    public bool? CobraendOfMonthFlag { get; set; }

    [Column("COBRAPeriodFirstPayment", TypeName = "money")]
    public decimal? CobraperiodFirstPayment { get; set; }

    public bool ConsideredTobaccoUserFlag { get; set; }

    public byte? FixedAge { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? NumericValue1 { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? NumericValue2 { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? NumericValue3 { get; set; }

    [StringLength(255)]
    public string? TextValue1 { get; set; }

    [StringLength(255)]
    public string? TextValue2 { get; set; }

    [StringLength(255)]
    public string? TextValue3 { get; set; }

    [Column("ResponsiblePersonGUID")]
    public Guid ResponsiblePersonGuid { get; set; }

    public bool PersonBenefitCurrentFlag { get; set; }

    [StringLength(15)]
    public string PrimaryPhysicianCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [StringLength(15)]
    public string BenefitWaiveReasonCode { get; set; } = null!;

    public bool AutoEnrolledFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OptOutDate { get; set; }

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TPersonBenefitHists")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [ForeignKey("BenefitWaiveReasonCode")]
    [InverseProperty("TPersonBenefitHists")]
    public virtual TBenefitWaiveReason BenefitWaiveReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("EndBenefitStatusCode")]
    [InverseProperty("TPersonBenefitHistEndBenefitStatusCodeNavigations")]
    public virtual TBenefitStatus EndBenefitStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonBenefitHistPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PrimaryPhysicianCode")]
    [InverseProperty("TPersonBenefitHists")]
    public virtual TPhysician PrimaryPhysicianCodeNavigation { get; set; } = null!;

    [ForeignKey("ResponsiblePersonGuid")]
    [InverseProperty("TPersonBenefitHistResponsiblePeople")]
    public virtual TPerson ResponsiblePerson { get; set; } = null!;

    [ForeignKey("StartBenefitStatusCode")]
    [InverseProperty("TPersonBenefitHistStartBenefitStatusCodeNavigations")]
    public virtual TBenefitStatus StartBenefitStatusCodeNavigation { get; set; } = null!;

    [InverseProperty("PersonBenefit")]
    public virtual ICollection<TPersonBenefitBeneficiaryHist> TPersonBenefitBeneficiaryHists { get; set; } = new List<TPersonBenefitBeneficiaryHist>();

    [InverseProperty("PersonBenefit")]
    public virtual ICollection<TPersonBenefitClaim> TPersonBenefitClaims { get; set; } = new List<TPersonBenefitClaim>();

    [InverseProperty("PersonBenefit")]
    public virtual ICollection<TPersonBenefitCobrapayment> TPersonBenefitCobrapayments { get; set; } = new List<TPersonBenefitCobrapayment>();

    [InverseProperty("PersonBenefit")]
    public virtual ICollection<TPersonBenefitContributionHist> TPersonBenefitContributionHists { get; set; } = new List<TPersonBenefitContributionHist>();
}
