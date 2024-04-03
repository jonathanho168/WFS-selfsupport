using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptArchiveApplication
{
    [Column("Application_Date", TypeName = "datetime")]
    public DateTime ApplicationDate { get; set; }

    [Column("Application_StatusCode")]
    [StringLength(15)]
    public string? ApplicationStatusCode { get; set; }

    [Column("Application_StatusDescription")]
    public string? ApplicationStatusDescription { get; set; }

    [Column("Application_StatusDate", TypeName = "datetime")]
    public DateTime? ApplicationStatusDate { get; set; }

    [Column("Application_RequisitionCode")]
    [StringLength(15)]
    public string ApplicationRequisitionCode { get; set; } = null!;

    [Column("Application_RequisitionDescription")]
    public string? ApplicationRequisitionDescription { get; set; }

    [Column("Application_ReferralSourceCode")]
    [StringLength(15)]
    public string ApplicationReferralSourceCode { get; set; } = null!;

    [Column("Application_RequestedPayAmount", TypeName = "money")]
    public decimal? ApplicationRequestedPayAmount { get; set; }

    [Column("Application_RequestedPayFrequencyCode")]
    [StringLength(15)]
    public string ApplicationRequestedPayFrequencyCode { get; set; } = null!;

    [Column("Application_RequestedPayCurrencyCode")]
    [StringLength(15)]
    public string ApplicationRequestedPayCurrencyCode { get; set; } = null!;

    [Column("Application_AvailableStartDate", TypeName = "datetime")]
    public DateTime? ApplicationAvailableStartDate { get; set; }

    [Column("Application_RequestedFullTimeFlag")]
    public bool ApplicationRequestedFullTimeFlag { get; set; }

    [Column("Application_RequestedPartTimeFlag")]
    public bool ApplicationRequestedPartTimeFlag { get; set; }

    [Column("Application_RequestedTemporaryFlag")]
    public bool ApplicationRequestedTemporaryFlag { get; set; }

    [Column("Application_RequestedContractFlag")]
    public bool ApplicationRequestedContractFlag { get; set; }

    [Column("Application_ID")]
    public int? ApplicationId { get; set; }

    [Column("Application_RecruitingFirmCode")]
    [StringLength(15)]
    public string? ApplicationRecruitingFirmCode { get; set; }

    [Column("Application_Comments")]
    public string? ApplicationComments { get; set; }

    [Column("Application_LastModifiedByUser")]
    public Guid? ApplicationLastModifiedByUser { get; set; }

    [Column("Application_LastModifiedDate", TypeName = "datetime")]
    public DateTime? ApplicationLastModifiedDate { get; set; }

    [Column("Application_CandidateDeleteDate", TypeName = "datetime")]
    public DateTime? ApplicationCandidateDeleteDate { get; set; }

    [Column("Application_InternalApplicantFlag")]
    public bool? ApplicationInternalApplicantFlag { get; set; }

    [Column("Answer_QuestionText")]
    [StringLength(255)]
    public string? AnswerQuestionText { get; set; }

    [Column("Answer_TextAnswer")]
    public string? AnswerTextAnswer { get; set; }

    [Column("Answer_NumericAnswer", TypeName = "decimal(19, 2)")]
    public decimal? AnswerNumericAnswer { get; set; }

    [Column("Answer_DateAnswer", TypeName = "datetime")]
    public DateTime? AnswerDateAnswer { get; set; }

    [Column("Answer_ExplainPrompt")]
    [StringLength(255)]
    public string? AnswerExplainPrompt { get; set; }

    [Column("Answer_Explanation")]
    public string? AnswerExplanation { get; set; }

    [Column("Answer_Validation")]
    public int? AnswerValidation { get; set; }

    [Column("Answer_ApplicationQuestionCode")]
    [StringLength(15)]
    public string? AnswerApplicationQuestionCode { get; set; }

    [Column("Answer_KnockoutQuestionFlag")]
    public bool? AnswerKnockoutQuestionFlag { get; set; }

    [Column("Answer_KnockoutAnswerFlag")]
    public bool? AnswerKnockoutAnswerFlag { get; set; }

    [Column("Communication_EmailSubject")]
    [StringLength(512)]
    public string? CommunicationEmailSubject { get; set; }

    [Column("Communication_SentDate", TypeName = "datetime")]
    public DateTime? CommunicationSentDate { get; set; }

    [Column("Communication_SentText")]
    [StringLength(4000)]
    public string? CommunicationSentText { get; set; }

    [Column("Communication_Comments")]
    public string? CommunicationComments { get; set; }

    [Column("Evaluation_Date", TypeName = "datetime")]
    public DateTime? EvaluationDate { get; set; }

    [Column("Evaluation_ResultCode")]
    [StringLength(15)]
    public string? EvaluationResultCode { get; set; }

    [Column("Evaluation_TypeCode")]
    [StringLength(15)]
    public string? EvaluationTypeCode { get; set; }

    [Column("Evaluation_EvaluatorCode")]
    [StringLength(15)]
    public string? EvaluationEvaluatorCode { get; set; }

    [Column("Evaluation_Comments")]
    public string? EvaluationComments { get; set; }

    [Column("Evaluation_ScheduledDate", TypeName = "datetime")]
    public DateTime? EvaluationScheduledDate { get; set; }

    [Column("Evaluation_ScheduledDuration")]
    public int? EvaluationScheduledDuration { get; set; }

    [Column("Evaluation_ScheduledLocation")]
    [StringLength(40)]
    public string? EvaluationScheduledLocation { get; set; }

    [Column("Offer_TypeCode")]
    [StringLength(15)]
    public string? OfferTypeCode { get; set; }

    [Column("Offer_Date", TypeName = "datetime")]
    public DateTime? OfferDate { get; set; }

    [Column("Offer_ExpirationDate", TypeName = "datetime")]
    public DateTime? OfferExpirationDate { get; set; }

    [Column("Offer_Amount", TypeName = "decimal(19, 2)")]
    public decimal? OfferAmount { get; set; }

    [Column("Offer_MinimumAmount", TypeName = "decimal(19, 2)")]
    public decimal? OfferMinimumAmount { get; set; }

    [Column("Offer_MaximumAmount", TypeName = "decimal(19, 2)")]
    public decimal? OfferMaximumAmount { get; set; }

    [Column("Offer_AmountCurrencyCode")]
    [StringLength(15)]
    public string? OfferAmountCurrencyCode { get; set; }

    [Column("Offer_AmountFrequencyCode")]
    [StringLength(15)]
    public string? OfferAmountFrequencyCode { get; set; }

    [Column("Offer_PayTerms")]
    public string? OfferPayTerms { get; set; }

    [Column("Offer_DeliveryMethodCode")]
    [StringLength(15)]
    public string? OfferDeliveryMethodCode { get; set; }

    [Column("Offer_ProposedEmploymentStartDate", TypeName = "datetime")]
    public DateTime? OfferProposedEmploymentStartDate { get; set; }

    [Column("Offer_AgreedEmploymentStartDate", TypeName = "datetime")]
    public DateTime? OfferAgreedEmploymentStartDate { get; set; }

    [Column("Offer_Results")]
    public string? OfferResults { get; set; }

    [Column("Offer_Comments")]
    public string? OfferComments { get; set; }

    [Column("Offer_AcceptedFlag")]
    public bool? OfferAcceptedFlag { get; set; }

    [Column("Offer_RejectedFlag")]
    public bool? OfferRejectedFlag { get; set; }

    [Column("Offer_PendingFlag")]
    public bool? OfferPendingFlag { get; set; }

    [Column("Status_Code")]
    [StringLength(15)]
    public string? StatusCode { get; set; }

    [Column("Status_StartDate", TypeName = "datetime")]
    public DateTime? StatusStartDate { get; set; }

    [Column("Status_EndDate", TypeName = "datetime")]
    public DateTime? StatusEndDate { get; set; }

    [Column("Status_Comments")]
    public string? StatusComments { get; set; }

    [Column("EmployeeID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(30)]
    public string LastName { get; set; } = null!;
}
