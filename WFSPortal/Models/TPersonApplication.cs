using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonApplication")]
[Index("ApplicationId", Name = "IX_tPersonApplication_ApplicationID")]
[Index("RequisitionCode", Name = "WFS_tPersonApplication_RequisitionCode")]
public partial class TPersonApplication
{
    [Key]
    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ApplicationDate { get; set; }

    [StringLength(15)]
    public string? ApplicationStatusCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApplicationStatusDate { get; set; }

    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    [StringLength(15)]
    public string ReferralSourceCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? RequestedPayAmount { get; set; }

    [StringLength(15)]
    public string RequestedPayFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string RequestedPayCurrencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AvailableStartDate { get; set; }

    public bool RequestedFullTimeFlag { get; set; }

    public bool RequestedPartTimeFlag { get; set; }

    public bool RequestedTemporaryFlag { get; set; }

    public bool RequestedContractFlag { get; set; }

    [Column("ApplicationID")]
    public int? ApplicationId { get; set; }

    [Column("ReferralSourcePersonGUID")]
    public Guid? ReferralSourcePersonGuid { get; set; }

    [StringLength(15)]
    public string? RecruitingFirmCode { get; set; }

    [Column("PersonNominationGUID")]
    public Guid? PersonNominationGuid { get; set; }

    [Column(TypeName = "ntext")]
    public string? Resume { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public Guid? LastModifiedByUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CandidateDeleteDate { get; set; }

    public bool? InternalApplicantFlag { get; set; }

    public bool? PreviousEmployeee { get; set; }

    [Column("OutsidePA")]
    public bool? OutsidePa { get; set; }

    [StringLength(80)]
    public string? ReferredBy { get; set; }

    public bool? PreviousEmployeeFlag { get; set; }

    public bool? GraduateFlag { get; set; }

    public bool? UndergraduateFlag { get; set; }

    public bool? PopPreferredChildFlag { get; set; }

    public bool? PopPreferredAdultFlag { get; set; }

    public string? InternshipLocationPreferred { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? DirectCareHours { get; set; }

    public string? ProgramofInterset { get; set; }

    [StringLength(80)]
    public string? SchoolAttending { get; set; }

    [StringLength(15)]
    public string? Major { get; set; }

    public string? Availability { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InternshipStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InternshipEndDate { get; set; }

    [StringLength(80)]
    public string? SchoolContactName { get; set; }

    [ForeignKey("ApplicationStatusCode")]
    [InverseProperty("TPersonApplications")]
    public virtual TApplicationStatus? ApplicationStatusCodeNavigation { get; set; }

    [ForeignKey("LastModifiedByUser")]
    [InverseProperty("TPersonApplications")]
    public virtual UsysUser? LastModifiedByUserNavigation { get; set; }

    [ForeignKey("Major")]
    [InverseProperty("TPersonApplications")]
    public virtual TMajor? MajorNavigation { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonApplicationPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonNominationGuid")]
    [InverseProperty("TPersonApplications")]
    public virtual TPersonNomination? PersonNomination { get; set; }

    [ForeignKey("RecruitingFirmCode")]
    [InverseProperty("TPersonApplications")]
    public virtual TRecruitingFirm? RecruitingFirmCodeNavigation { get; set; }

    [ForeignKey("ReferralSourceCode")]
    [InverseProperty("TPersonApplications")]
    public virtual TReferralSource ReferralSourceCodeNavigation { get; set; } = null!;

    [ForeignKey("ReferralSourcePersonGuid")]
    [InverseProperty("TPersonApplicationReferralSourcePeople")]
    public virtual TPerson? ReferralSourcePerson { get; set; }

    [ForeignKey("RequestedPayCurrencyCode")]
    [InverseProperty("TPersonApplications")]
    public virtual TCurrency RequestedPayCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("RequestedPayFrequencyCode")]
    [InverseProperty("TPersonApplications")]
    public virtual TFrequency RequestedPayFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("RequisitionCode")]
    [InverseProperty("TPersonApplications")]
    public virtual TRequisition RequisitionCodeNavigation { get; set; } = null!;

    [InverseProperty("PersonApplication")]
    public virtual ICollection<TPersonApplicationAnswer> TPersonApplicationAnswers { get; set; } = new List<TPersonApplicationAnswer>();

    [InverseProperty("PersonApplication")]
    public virtual ICollection<TPersonApplicationCommunication> TPersonApplicationCommunications { get; set; } = new List<TPersonApplicationCommunication>();

    [InverseProperty("PersonApplication")]
    public virtual ICollection<TPersonApplicationEvaluation> TPersonApplicationEvaluations { get; set; } = new List<TPersonApplicationEvaluation>();

    [InverseProperty("PersonApplication")]
    public virtual ICollection<TPersonApplicationFile> TPersonApplicationFiles { get; set; } = new List<TPersonApplicationFile>();

    [InverseProperty("PersonApplication")]
    public virtual ICollection<TPersonApplicationOffer> TPersonApplicationOffers { get; set; } = new List<TPersonApplicationOffer>();

    [InverseProperty("PersonApplication")]
    public virtual ICollection<TPersonApplicationStatusHist> TPersonApplicationStatusHists { get; set; } = new List<TPersonApplicationStatusHist>();

    [InverseProperty("PersonApplication")]
    public virtual ICollection<TPersonForwardedApplication> TPersonForwardedApplications { get; set; } = new List<TPersonForwardedApplication>();

    [InverseProperty("PersonApplication")]
    public virtual ICollection<TRecruitingExpense> TRecruitingExpenses { get; set; } = new List<TRecruitingExpense>();
}
