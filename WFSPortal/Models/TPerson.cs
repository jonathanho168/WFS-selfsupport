using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerson")]
[Index("ApplicantId", Name = "IX_tPerson_ApplicantID")]
[Index("BadgeId", Name = "IX_tPerson_BadgeID")]
[Index("CompanyEmailAddress", Name = "IX_tPerson_CompanyEmailAddress")]
[Index("EmployeeId", Name = "IX_tPerson_EmployeeID")]
[Index("FirstName", Name = "IX_tPerson_FirstName")]
[Index("LastName", Name = "IX_tPerson_LastName")]
[Index("PayrollId", Name = "IX_tPerson_PayrollID")]
[Index("PersonId", Name = "IX_tPerson_PersonID")]
[Index("PersonalEmailAddress", Name = "IX_tPerson_PersonalEmailAddress")]
[Index("TimeClockId", Name = "IX_tPerson_TimeClockID")]
public partial class TPerson
{
    [Key]
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("PersonID")]
    [StringLength(24)]
    public string? PersonId { get; set; }

    [StringLength(5)]
    public string? Salutation { get; set; }

    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(10)]
    public string? Suffix { get; set; }

    [StringLength(30)]
    public string? Nickname { get; set; }

    [StringLength(30)]
    public string? FormerLastName { get; set; }

    [Column("ApplicantID")]
    [StringLength(24)]
    public string? ApplicantId { get; set; }

    [Column("EmployeeID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [Column("BadgeID")]
    [StringLength(24)]
    public string? BadgeId { get; set; }

    [Column("PayrollID")]
    [StringLength(24)]
    public string? PayrollId { get; set; }

    [Column("TimeClockID")]
    [StringLength(24)]
    public string? TimeClockId { get; set; }

    [StringLength(255)]
    public string? CompanyEmailAddress { get; set; }

    [StringLength(255)]
    public string? PersonalEmailAddress { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(30)]
    public string? Pronunciation { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public bool EmployeeFlag { get; set; }

    public bool ApplicantFlag { get; set; }

    public bool DependentFlag { get; set; }

    [StringLength(50)]
    public string? TypeString { get; set; }

    public bool AllowAccessToSystem { get; set; }

    public bool SynchronizationFlag { get; set; }

    [StringLength(15)]
    public string PrimaryLanguageCode { get; set; } = null!;

    [Column("bcSubmitDate", TypeName = "datetime")]
    public DateTime? BcSubmitDate { get; set; }

    [Column("bcViewDate", TypeName = "datetime")]
    public DateTime? BcViewDate { get; set; }

    [Column("bcSubmittedBy")]
    [StringLength(80)]
    public string? BcSubmittedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChildAbuseClearance { get; set; }

    [Column("FBIClearance", TypeName = "datetime")]
    public DateTime? Fbiclearance { get; set; }

    [Column("PAStateClearance", TypeName = "datetime")]
    public DateTime? PastateClearance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractExpiration { get; set; }

    [Column("DEANumberExpiration", TypeName = "datetime")]
    public DateTime? DeanumberExpiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LiabilityInsuranceExpiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LicensureExpiration { get; set; }

    [StringLength(255)]
    public string? SchoolEmailAddress { get; set; }

    [StringLength(80)]
    public string? ContractType { get; set; }

    [StringLength(80)]
    public string? ContractAgency { get; set; }

    [Column("FBIClearanceType")]
    [StringLength(80)]
    public string? FbiclearanceType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChildAbuseClearancePrevious { get; set; }

    [Column("PAStatePoliceClearancePrevious", TypeName = "datetime")]
    public DateTime? PastatePoliceClearancePrevious { get; set; }

    [Column("FBIClearancePrevious", TypeName = "datetime")]
    public DateTime? FbiclearancePrevious { get; set; }

    [Column("FBIClearanceTypePrevious")]
    [StringLength(80)]
    public string? FbiclearanceTypePrevious { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChildAbuseClearanceExpiration { get; set; }

    [Column("FBIClearanceExpiration", TypeName = "datetime")]
    public DateTime? FbiclearanceExpiration { get; set; }

    [Column("PAStateClearanceExpiration", TypeName = "datetime")]
    public DateTime? PastateClearanceExpiration { get; set; }

    [ForeignKey("PrimaryLanguageCode")]
    [InverseProperty("TPeople")]
    public virtual TLanguage PrimaryLanguageCodeNavigation { get; set; } = null!;

    [InverseProperty("OwnerPerson")]
    public virtual ICollection<TAbsenceRuleSetOwner> TAbsenceRuleSetOwners { get; set; } = new List<TAbsenceRuleSetOwner>();

    [InverseProperty("CreatedByPerson")]
    public virtual ICollection<TAbsenceRuleSet> TAbsenceRuleSets { get; set; } = new List<TAbsenceRuleSet>();

    [InverseProperty("CreatedByPerson")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("EmployeePerson")]
    public virtual ICollection<THealthAndSafetyChecklist> THealthAndSafetyChecklistEmployeePeople { get; set; } = new List<THealthAndSafetyChecklist>();

    [InverseProperty("PersonWhoCompletedChecklistPerson")]
    public virtual ICollection<THealthAndSafetyChecklist> THealthAndSafetyChecklistPersonWhoCompletedChecklistPeople { get; set; } = new List<THealthAndSafetyChecklist>();

    [InverseProperty("SupervisorOnLocationPerson")]
    public virtual ICollection<TIncident> TIncidents { get; set; } = new List<TIncident>();

    [InverseProperty("Person")]
    public virtual ICollection<TMassChangeOperation> TMassChangeOperations { get; set; } = new List<TMassChangeOperation>();

    [InverseProperty("Person")]
    public virtual ICollection<TPerson9BoxHist> TPerson9BoxHists { get; set; } = new List<TPerson9BoxHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonAbsenceEligibility> TPersonAbsenceEligibilities { get; set; } = new List<TPersonAbsenceEligibility>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonAbsencePlan> TPersonAbsencePlans { get; set; } = new List<TPersonAbsencePlan>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonAbsencePoint> TPersonAbsencePoints { get; set; } = new List<TPersonAbsencePoint>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonAchievement> TPersonAchievements { get; set; } = new List<TPersonAchievement>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonAddress> TPersonAddresses { get; set; } = new List<TPersonAddress>();

    [InverseProperty("SentByPerson")]
    public virtual ICollection<TPersonApplicationCommunication> TPersonApplicationCommunications { get; set; } = new List<TPersonApplicationCommunication>();

    [InverseProperty("EvaluatorPerson")]
    public virtual ICollection<TPersonApplicationEvaluation> TPersonApplicationEvaluationEvaluatorPeople { get; set; } = new List<TPersonApplicationEvaluation>();

    [InverseProperty("ScheduledEvaluatorPerson")]
    public virtual ICollection<TPersonApplicationEvaluation> TPersonApplicationEvaluationScheduledEvaluatorPeople { get; set; } = new List<TPersonApplicationEvaluation>();

    [InverseProperty("ApprovedByPerson")]
    public virtual ICollection<TPersonApplicationOffer> TPersonApplicationOfferApprovedByPeople { get; set; } = new List<TPersonApplicationOffer>();

    [InverseProperty("OfferedByPerson")]
    public virtual ICollection<TPersonApplicationOffer> TPersonApplicationOfferOfferedByPeople { get; set; } = new List<TPersonApplicationOffer>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonApplication> TPersonApplicationPeople { get; set; } = new List<TPersonApplication>();

    [InverseProperty("ReferralSourcePerson")]
    public virtual ICollection<TPersonApplication> TPersonApplicationReferralSourcePeople { get; set; } = new List<TPersonApplication>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonAward> TPersonAwards { get; set; } = new List<TPersonAward>();

    [InverseProperty("ApprovedByPerson")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHistApprovedByPeople { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHistPeople { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonBenefitGroupHist> TPersonBenefitGroupHists { get; set; } = new List<TPersonBenefitGroupHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonBenefitHist> TPersonBenefitHistPeople { get; set; } = new List<TPersonBenefitHist>();

    [InverseProperty("ResponsiblePerson")]
    public virtual ICollection<TPersonBenefitHist> TPersonBenefitHistResponsiblePeople { get; set; } = new List<TPersonBenefitHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonBenefitOffer> TPersonBenefitOffers { get; set; } = new List<TPersonBenefitOffer>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonBenefitOptOut> TPersonBenefitOptOuts { get; set; } = new List<TPersonBenefitOptOut>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonCertification> TPersonCertifications { get; set; } = new List<TPersonCertification>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonCobra> TPersonCobras { get; set; } = new List<TPersonCobra>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonCommunityActivity> TPersonCommunityActivities { get; set; } = new List<TPersonCommunityActivity>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHistPeople { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("SupervisorProficiencyAssessedByPerson")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHistSupervisorProficiencyAssessedByPeople { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("Person")]
    public virtual TPersonCustomBase? TPersonCustomBase { get; set; }

    [InverseProperty("Person")]
    public virtual ICollection<TPersonCustomHist> TPersonCustomHists { get; set; } = new List<TPersonCustomHist>();

    [InverseProperty("DependentPerson")]
    public virtual ICollection<TPersonDependent> TPersonDependentDependentPeople { get; set; } = new List<TPersonDependent>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonDependent> TPersonDependentPeople { get; set; } = new List<TPersonDependent>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonDirectDeposit> TPersonDirectDepositPeople { get; set; } = new List<TPersonDirectDeposit>();

    [InverseProperty("SignedByPerson")]
    public virtual ICollection<TPersonDirectDeposit> TPersonDirectDepositSignedByPeople { get; set; } = new List<TPersonDirectDeposit>();

    [InverseProperty("HandledByPerson")]
    public virtual ICollection<TPersonDiscipline> TPersonDisciplineHandledByPeople { get; set; } = new List<TPersonDiscipline>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonDiscipline> TPersonDisciplinePeople { get; set; } = new List<TPersonDiscipline>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonDrugTest> TPersonDrugTestPeople { get; set; } = new List<TPersonDrugTest>();

    [InverseProperty("RequestedByPerson")]
    public virtual ICollection<TPersonDrugTest> TPersonDrugTestRequestedByPeople { get; set; } = new List<TPersonDrugTest>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonEducationHist> TPersonEducationHists { get; set; } = new List<TPersonEducationHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonEmergency> TPersonEmergencies { get; set; } = new List<TPersonEmergency>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonEmploymentDocument> TPersonEmploymentDocumentPeople { get; set; } = new List<TPersonEmploymentDocument>();

    [InverseProperty("SignedByPerson")]
    public virtual ICollection<TPersonEmploymentDocument> TPersonEmploymentDocumentSignedByPeople { get; set; } = new List<TPersonEmploymentDocument>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHists { get; set; } = new List<TPersonEmploymentHist>();

    [InverseProperty("Person")]
    public virtual TPersonErp? TPersonErp { get; set; }

    [InverseProperty("Person")]
    public virtual ICollection<TPersonFile> TPersonFiles { get; set; } = new List<TPersonFile>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonFmlaadjustment> TPersonFmlaadjustments { get; set; } = new List<TPersonFmlaadjustment>();

    [InverseProperty("ForwardedByPerson")]
    public virtual ICollection<TPersonForwardedApplication> TPersonForwardedApplicationForwardedByPeople { get; set; } = new List<TPersonForwardedApplication>();

    [InverseProperty("ForwardedToPerson")]
    public virtual ICollection<TPersonForwardedApplication> TPersonForwardedApplicationForwardedToPeople { get; set; } = new List<TPersonForwardedApplication>();

    [InverseProperty("EnrolledPerson")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollmentEnrolledPeople { get; set; } = new List<TPersonFutureEnrollment>();

    [InverseProperty("ResponsiblePerson")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollmentResponsiblePeople { get; set; } = new List<TPersonFutureEnrollment>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonFutureEnrollmentStatus> TPersonFutureEnrollmentStatuses { get; set; } = new List<TPersonFutureEnrollmentStatus>();

    [InverseProperty("CreatedByPerson")]
    public virtual ICollection<TPersonGoal> TPersonGoalCreatedByPeople { get; set; } = new List<TPersonGoal>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonGoal> TPersonGoalPeople { get; set; } = new List<TPersonGoal>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonGovFormHist> TPersonGovFormHists { get; set; } = new List<TPersonGovFormHist>();

    [InverseProperty("EmployerSignedByPerson")]
    public virtual ICollection<TPersonI9> TPersonI9EmployerSignedByPeople { get; set; } = new List<TPersonI9>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonI9> TPersonI9People { get; set; } = new List<TPersonI9>();

    [InverseProperty("RehireOrReverificationEmployerSignedByPerson")]
    public virtual ICollection<TPersonI9> TPersonI9RehireOrReverificationEmployerSignedByPeople { get; set; } = new List<TPersonI9>();

    [InverseProperty("FirstReportCompletedByPerson")]
    public virtual ICollection<TPersonIncident> TPersonIncidentFirstReportCompletedByPeople { get; set; } = new List<TPersonIncident>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonIncident> TPersonIncidentPeople { get; set; } = new List<TPersonIncident>();

    [InverseProperty("SupervisorPerson")]
    public virtual ICollection<TPersonIncident> TPersonIncidentSupervisorPeople { get; set; } = new List<TPersonIncident>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonJobHist> TPersonJobHists { get; set; } = new List<TPersonJobHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonLanguage> TPersonLanguagePeople { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("SupervisorProficiencyAssessedByPerson")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageSupervisorProficiencyAssessedByPeople { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonLeaveRequest> TPersonLeaveRequests { get; set; } = new List<TPersonLeaveRequest>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonLifeEvent> TPersonLifeEventPeople { get; set; } = new List<TPersonLifeEvent>();

    [InverseProperty("ResponseByPerson")]
    public virtual ICollection<TPersonLifeEvent> TPersonLifeEventResponseByPeople { get; set; } = new List<TPersonLifeEvent>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHistPeople { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("SupervisorPerson")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHistSupervisorPeople { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("Person")]
    public virtual TPersonMedical? TPersonMedical { get; set; }

    [InverseProperty("Person")]
    public virtual ICollection<TPersonMilitaryHist> TPersonMilitaryHists { get; set; } = new List<TPersonMilitaryHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonNationalId> TPersonNationalIds { get; set; } = new List<TPersonNationalId>();

    [InverseProperty("LastUpdatedByPerson")]
    public virtual ICollection<TPersonNomination> TPersonNominationLastUpdatedByPeople { get; set; } = new List<TPersonNomination>();

    [InverseProperty("NominatedByPerson")]
    public virtual ICollection<TPersonNomination> TPersonNominationNominatedByPeople { get; set; } = new List<TPersonNomination>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonNomination> TPersonNominationPeople { get; set; } = new List<TPersonNomination>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonNote> TPersonNotes { get; set; } = new List<TPersonNote>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonOtherName> TPersonOtherNames { get; set; } = new List<TPersonOtherName>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHistPeople { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("ReferringEmployeeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHistReferringEmployeeNavigations { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonOvertimeHist> TPersonOvertimeHists { get; set; } = new List<TPersonOvertimeHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonPassport> TPersonPassports { get; set; } = new List<TPersonPassport>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonPayStubArchive> TPersonPayStubArchives { get; set; } = new List<TPersonPayStubArchive>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonPerformanceHist> TPersonPerformanceHistPeople { get; set; } = new List<TPersonPerformanceHist>();

    [InverseProperty("RatedByPerson")]
    public virtual ICollection<TPersonPerformanceHist> TPersonPerformanceHistRatedByPeople { get; set; } = new List<TPersonPerformanceHist>();

    [InverseProperty("SupervisorPerson")]
    public virtual ICollection<TPersonPerformanceHist> TPersonPerformanceHistSupervisorPeople { get; set; } = new List<TPersonPerformanceHist>();

    [InverseProperty("ParticipantPerson")]
    public virtual ICollection<TPersonPerformanceParticipant> TPersonPerformanceParticipants { get; set; } = new List<TPersonPerformanceParticipant>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonPhone> TPersonPhones { get; set; } = new List<TPersonPhone>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonProfessionalAffiliation> TPersonProfessionalAffiliations { get; set; } = new List<TPersonProfessionalAffiliation>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonProjectHist> TPersonProjectHists { get; set; } = new List<TPersonProjectHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonPropertyCardHist> TPersonPropertyCardHists { get; set; } = new List<TPersonPropertyCardHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonPropertyHist> TPersonPropertyHists { get; set; } = new List<TPersonPropertyHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonPublishedWork> TPersonPublishedWorks { get; set; } = new List<TPersonPublishedWork>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonReference> TPersonReferences { get; set; } = new List<TPersonReference>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonScheduleDate> TPersonScheduleDates { get; set; } = new List<TPersonScheduleDate>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonSocialNetwork> TPersonSocialNetworks { get; set; } = new List<TPersonSocialNetwork>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonSpeakingEngagement> TPersonSpeakingEngagements { get; set; } = new List<TPersonSpeakingEngagement>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonSpecialAccommodation> TPersonSpecialAccommodations { get; set; } = new List<TPersonSpecialAccommodation>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonStatusHist> TPersonStatusHists { get; set; } = new List<TPersonStatusHist>();

    [InverseProperty("Person")]
    public virtual TPersonTax? TPersonTaxPerson { get; set; }

    [InverseProperty("SignedByPerson")]
    public virtual ICollection<TPersonTax> TPersonTaxSignedByPeople { get; set; } = new List<TPersonTax>();

    [InverseProperty("CheckListVerifiedByPerson")]
    public virtual ICollection<TPersonTermination> TPersonTerminationCheckListVerifiedByPeople { get; set; } = new List<TPersonTermination>();

    [InverseProperty("ExitInterviewerPerson")]
    public virtual ICollection<TPersonTermination> TPersonTerminationExitInterviewerPeople { get; set; } = new List<TPersonTermination>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonTermination> TPersonTerminationPeople { get; set; } = new List<TPersonTermination>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetailPeople { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("RevisedByPerson")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetailRevisedByPeople { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonTimeGroupHist> TPersonTimeGroupHists { get; set; } = new List<TPersonTimeGroupHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonTimeGroupPeriod> TPersonTimeGroupPeriods { get; set; } = new List<TPersonTimeGroupPeriod>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonTrainingProgram> TPersonTrainingPrograms { get; set; } = new List<TPersonTrainingProgram>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonTraining> TPersonTrainings { get; set; } = new List<TPersonTraining>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonUnionHist> TPersonUnionHists { get; set; } = new List<TPersonUnionHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonVeteran> TPersonVeterans { get; set; } = new List<TPersonVeteran>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonVisa> TPersonVisas { get; set; } = new List<TPersonVisa>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonW2> TPersonW2s { get; set; } = new List<TPersonW2>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonWaitList> TPersonWaitLists { get; set; } = new List<TPersonWaitList>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonWorkEligibility> TPersonWorkEligibilityPeople { get; set; } = new List<TPersonWorkEligibility>();

    [InverseProperty("VerifiedByPerson")]
    public virtual ICollection<TPersonWorkEligibility> TPersonWorkEligibilityVerifiedByPeople { get; set; } = new List<TPersonWorkEligibility>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonWorksCouncilHist> TPersonWorksCouncilHists { get; set; } = new List<TPersonWorksCouncilHist>();

    [InverseProperty("Person")]
    public virtual ICollection<TPersonYearToDateEarning> TPersonYearToDateEarnings { get; set; } = new List<TPersonYearToDateEarning>();

    [InverseProperty("Person")]
    public virtual TPersonal? TPersonal { get; set; }

    [InverseProperty("CreatedByPerson")]
    public virtual ICollection<TProject> TProjects { get; set; } = new List<TProject>();

    [InverseProperty("AllocationPerson")]
    public virtual ICollection<TRecruitingExpenseAllocation> TRecruitingExpenseAllocations { get; set; } = new List<TRecruitingExpenseAllocation>();

    [InverseProperty("ApprovedByPerson")]
    public virtual ICollection<TRecruitingExpense> TRecruitingExpenses { get; set; } = new List<TRecruitingExpense>();

    [InverseProperty("ApprovedByPerson")]
    public virtual ICollection<TRequisition> TRequisitionApprovedByPeople { get; set; } = new List<TRequisition>();

    [InverseProperty("CreatedByPerson")]
    public virtual ICollection<TRequisition> TRequisitionCreatedByPeople { get; set; } = new List<TRequisition>();

    [InverseProperty("HiredPerson")]
    public virtual ICollection<TRequisitionEmployeesHired> TRequisitionEmployeesHireds { get; set; } = new List<TRequisitionEmployeesHired>();

    [InverseProperty("ReplacedPerson")]
    public virtual ICollection<TRequisitionEmployeesReplaced> TRequisitionEmployeesReplaceds { get; set; } = new List<TRequisitionEmployeesReplaced>();

    [InverseProperty("InternalRecruiterPerson")]
    public virtual ICollection<TRequisition> TRequisitionInternalRecruiterPeople { get; set; } = new List<TRequisition>();

    [InverseProperty("LastModifiedByPerson")]
    public virtual ICollection<TRequisition> TRequisitionLastModifiedByPeople { get; set; } = new List<TRequisition>();

    [InverseProperty("ReportsToPerson")]
    public virtual ICollection<TRequisition> TRequisitionReportsToPeople { get; set; } = new List<TRequisition>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysBenefitEnrollmentContribution> UsysBenefitEnrollmentContributions { get; set; } = new List<UsysBenefitEnrollmentContribution>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysBenefitEnrollmentDependent> UsysBenefitEnrollmentDependents { get; set; } = new List<UsysBenefitEnrollmentDependent>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysBenefitEnrollmentEligibility> UsysBenefitEnrollmentEligibilities { get; set; } = new List<UsysBenefitEnrollmentEligibility>();

    [InverseProperty("ClosedByPerson")]
    public virtual ICollection<UsysChecklistInstance> UsysChecklistInstanceClosedByPeople { get; set; } = new List<UsysChecklistInstance>();

    [InverseProperty("OwnerPerson")]
    public virtual ICollection<UsysChecklistInstance> UsysChecklistInstanceOwnerPeople { get; set; } = new List<UsysChecklistInstance>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysChecklistInstanceStep> UsysChecklistInstanceSteps { get; set; } = new List<UsysChecklistInstanceStep>();

    [InverseProperty("SubjectPerson")]
    public virtual ICollection<UsysChecklistInstance> UsysChecklistInstanceSubjectPeople { get; set; } = new List<UsysChecklistInstance>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysLnkExportPersonHist> UsysLnkExportPersonHists { get; set; } = new List<UsysLnkExportPersonHist>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysLnkImportDataError> UsysLnkImportDataErrors { get; set; } = new List<UsysLnkImportDataError>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysMassChangeError> UsysMassChangeErrors { get; set; } = new List<UsysMassChangeError>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysMassChangeSql> UsysMassChangeSqls { get; set; } = new List<UsysMassChangeSql>();

    [InverseProperty("OriginalApprover")]
    public virtual ICollection<UsysRecipientOverride> UsysRecipientOverrideOriginalApprovers { get; set; } = new List<UsysRecipientOverride>();

    [InverseProperty("OverrideApprover")]
    public virtual ICollection<UsysRecipientOverride> UsysRecipientOverrideOverrideApprovers { get; set; } = new List<UsysRecipientOverride>();

    [InverseProperty("RecipientPerson")]
    public virtual ICollection<UsysRecipient> UsysRecipients { get; set; } = new List<UsysRecipient>();

    [InverseProperty("OriginatorPerson")]
    public virtual ICollection<UsysRoutingInstance> UsysRoutingInstanceOriginatorPeople { get; set; } = new List<UsysRoutingInstance>();

    [InverseProperty("RecipientPerson")]
    public virtual ICollection<UsysRoutingInstanceStep> UsysRoutingInstanceStepRecipientPeople { get; set; } = new List<UsysRoutingInstanceStep>();

    [InverseProperty("SignedByPerson")]
    public virtual ICollection<UsysRoutingInstanceStep> UsysRoutingInstanceStepSignedByPeople { get; set; } = new List<UsysRoutingInstanceStep>();

    [InverseProperty("SubjectPerson")]
    public virtual ICollection<UsysRoutingInstance> UsysRoutingInstanceSubjectPeople { get; set; } = new List<UsysRoutingInstance>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysRowSecurity> UsysRowSecurities { get; set; } = new List<UsysRowSecurity>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysSalaryPlanPerson> UsysSalaryPlanPeople { get; set; } = new List<UsysSalaryPlanPerson>();

    [InverseProperty("ModelApprovedBy")]
    public virtual ICollection<UsysSalaryPlan> UsysSalaryPlans { get; set; } = new List<UsysSalaryPlan>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysTimeCostModelPerson> UsysTimeCostModelPeople { get; set; } = new List<UsysTimeCostModelPerson>();

    [InverseProperty("Person")]
    public virtual ICollection<UsysUser> UsysUsers { get; set; } = new List<UsysUser>();
}
