using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptgcPitallPerson
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("PIT Date", TypeName = "datetime")]
    public DateTime? PitDate { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [StringLength(255)]
    public string? Address3 { get; set; }

    [Column("Adjusted Hire Date", TypeName = "datetime")]
    public DateTime? AdjustedHireDate { get; set; }

    public int? Age { get; set; }

    [Column("Annual Salary", TypeName = "money")]
    public decimal? AnnualSalary { get; set; }

    [Column("Birth Country Code")]
    [StringLength(15)]
    public string? BirthCountryCode { get; set; }

    [Column("Birth Country")]
    public string? BirthCountry { get; set; }

    [Column("Birth Date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("Birth Place")]
    [StringLength(40)]
    public string? BirthPlace { get; set; }

    [Column("Business Card Title")]
    [StringLength(80)]
    public string? BusinessCardTitle { get; set; }

    [Column("Citizen Country Code")]
    [StringLength(15)]
    public string? CitizenCountryCode { get; set; }

    [Column("Citizen Country")]
    public string? CitizenCountry { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [Column("Company Code")]
    [StringLength(15)]
    public string? CompanyCode { get; set; }

    public string? Company { get; set; }

    [Column("Company Email")]
    [StringLength(255)]
    public string? CompanyEmail { get; set; }

    [Column("Cost Center Code")]
    [StringLength(15)]
    public string? CostCenterCode { get; set; }

    [Column("Cost Center")]
    public string? CostCenter { get; set; }

    [Column("Country Code")]
    [StringLength(15)]
    public string? CountryCode { get; set; }

    public string? Country { get; set; }

    [Column("Currency Code")]
    [StringLength(15)]
    public string? CurrencyCode { get; set; }

    public string? Currency { get; set; }

    [Column("Day Area Code")]
    [StringLength(6)]
    [Unicode(false)]
    public string? DayAreaCode { get; set; }

    [Column("Day Ext.")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DayExt { get; set; }

    [StringLength(20)]
    public string? DayInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? DayNationalPrefix { get; set; }

    [Column("Day Phone")]
    [StringLength(20)]
    public string? DayPhone { get; set; }

    [Column("Department Code")]
    [StringLength(15)]
    public string? DepartmentCode { get; set; }

    public string? Department { get; set; }

    [Column("Division Code")]
    [StringLength(15)]
    public string? DivisionCode { get; set; }

    public string? Division { get; set; }

    [Column("Disability Code")]
    [StringLength(15)]
    public string? DisabilityCode { get; set; }

    public string? Disability { get; set; }

    [Column("Drv Lic Exp Date", TypeName = "datetime")]
    public DateTime? DrvLicExpDate { get; set; }

    [Column("Drv Lic #")]
    [StringLength(30)]
    public string? DrvLic { get; set; }

    [Column("Drv Lic St/Prov Code")]
    [StringLength(15)]
    public string? DrvLicStProvCode { get; set; }

    [Column("Drv Lic St/Prov")]
    public string? DrvLicStProv { get; set; }

    [Column("EEO Category Code")]
    [StringLength(15)]
    public string? EeoCategoryCode { get; set; }

    [Column("EEO Category")]
    public string? EeoCategory { get; set; }

    [Column("Employee ID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [Column("Ethnic Group Code")]
    [StringLength(15)]
    public string? EthnicGroupCode { get; set; }

    [Column("Ethnic Group")]
    public string? EthnicGroup { get; set; }

    [Column("Family Status Code")]
    [StringLength(15)]
    public string? FamilyStatusCode { get; set; }

    [Column("Family Status")]
    public string? FamilyStatus { get; set; }

    [Column("Fax Area Code")]
    [StringLength(6)]
    [Unicode(false)]
    public string? FaxAreaCode { get; set; }

    [StringLength(20)]
    public string? FaxInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? FaxNationalPrefix { get; set; }

    [Column("Fax Phone")]
    [StringLength(20)]
    public string? FaxPhone { get; set; }

    [Column("First Name")]
    [StringLength(30)]
    public string? FirstName { get; set; }

    [Column("Former Last Name")]
    [StringLength(30)]
    public string? FormerLastName { get; set; }

    [Column("FTE", TypeName = "decimal(19, 4)")]
    public decimal? Fte { get; set; }

    [Column("Full Name")]
    [StringLength(125)]
    public string? FullName { get; set; }

    [Column("Functional Area Code")]
    [StringLength(15)]
    public string? FunctionalAreaCode { get; set; }

    [Column("Functional Area")]
    public string? FunctionalArea { get; set; }

    [Column("Gender Code")]
    [StringLength(15)]
    public string? GenderCode { get; set; }

    public string? Gender { get; set; }

    [StringLength(15)]
    public string? Grade { get; set; }

    [Column("Grade Location Code")]
    [StringLength(15)]
    public string? GradeLocationCode { get; set; }

    [Column("Grade Location")]
    public string? GradeLocation { get; set; }

    [Column("Hire Source Code")]
    [StringLength(15)]
    public string? HireSourceCode { get; set; }

    [Column("Hire Source")]
    public string? HireSource { get; set; }

    [Column("Home Area Code")]
    [StringLength(6)]
    [Unicode(false)]
    public string? HomeAreaCode { get; set; }

    [StringLength(20)]
    public string? HomeInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? HomeNationalPrefix { get; set; }

    [Column("Home Phone")]
    [StringLength(20)]
    public string? HomePhone { get; set; }

    [Column("International Type Code")]
    [StringLength(15)]
    public string? InternationalTypeCode { get; set; }

    [Column("International Type")]
    public string? InternationalType { get; set; }

    [Column("Job Category Code")]
    [StringLength(15)]
    public string? JobCategoryCode { get; set; }

    [Column("Job Category")]
    public string? JobCategory { get; set; }

    [Column("Job Code")]
    [StringLength(15)]
    public string? JobCode { get; set; }

    [Column("Job End Date", TypeName = "datetime")]
    public DateTime? JobEndDate { get; set; }

    [Column("Job Family Code")]
    [StringLength(15)]
    public string? JobFamilyCode { get; set; }

    [Column("Job Family")]
    public string? JobFamily { get; set; }

    [Column("Job Group Code")]
    [StringLength(15)]
    public string? JobGroupCode { get; set; }

    [Column("Job Group")]
    public string? JobGroup { get; set; }

    [Column("Job Reason Code")]
    [StringLength(15)]
    public string? JobReasonCode { get; set; }

    [Column("Job Reason")]
    public string? JobReason { get; set; }

    [Column("Job Start Date", TypeName = "datetime")]
    public DateTime? JobStartDate { get; set; }

    [Column("Job Title")]
    public string? JobTitle { get; set; }

    [Column("Last Name")]
    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [Column("Latest Hire Date", TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [Column("Location Code")]
    [StringLength(15)]
    public string? LocationCode { get; set; }

    public string? Location { get; set; }

    [Column("Location End Date", TypeName = "datetime")]
    public DateTime? LocationEndDate { get; set; }

    [Column("Location Reason Code")]
    [StringLength(15)]
    public string? LocationReasonCode { get; set; }

    [Column("Location Reason")]
    public string? LocationReason { get; set; }

    [Column("Location Start Date", TypeName = "datetime")]
    public DateTime? LocationStartDate { get; set; }

    [Column("Middle Name")]
    [StringLength(30)]
    public string? MiddleName { get; set; }

    [Column("Mobile Area Code")]
    [StringLength(6)]
    [Unicode(false)]
    public string? MobileAreaCode { get; set; }

    [StringLength(20)]
    public string? MobileInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? MobileNationalPrefix { get; set; }

    [Column("Mobile Phone")]
    [StringLength(20)]
    public string? MobilePhone { get; set; }

    [StringLength(30)]
    public string? Nickname { get; set; }

    [Column("Organization Unit Code")]
    [StringLength(15)]
    public string? OrganizationUnitCode { get; set; }

    [Column("Organization Unit")]
    public string? OrganizationUnit { get; set; }

    [Column("Original Hire Date", TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [Column("Overtime Status Code")]
    [StringLength(15)]
    public string? OvertimeStatusCode { get; set; }

    [Column("Overtime Status")]
    public string? OvertimeStatus { get; set; }

    [Column("Pager Area Code")]
    [StringLength(6)]
    [Unicode(false)]
    public string? PagerAreaCode { get; set; }

    [StringLength(20)]
    public string? PagerInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? PagerNationalPrefix { get; set; }

    [Column("Pager Phone")]
    [StringLength(20)]
    public string? PagerPhone { get; set; }

    [Column("Passport Country Code")]
    [StringLength(15)]
    public string? PassportCountryCode { get; set; }

    [Column("Passport Country")]
    public string? PassportCountry { get; set; }

    [Column("Passport Exp Date", TypeName = "datetime")]
    public DateTime? PassportExpDate { get; set; }

    [Column("Passport Issue Date", TypeName = "datetime")]
    public DateTime? PassportIssueDate { get; set; }

    [Column("Passport #")]
    [StringLength(20)]
    public string? Passport { get; set; }

    [Column(TypeName = "money")]
    public decimal? Pay { get; set; }

    [Column("Pay End Date", TypeName = "datetime")]
    public DateTime? PayEndDate { get; set; }

    [Column("Pay Start Date", TypeName = "datetime")]
    public DateTime? PayStartDate { get; set; }

    [Column("Pay Per Code")]
    [StringLength(15)]
    public string? PayPerCode { get; set; }

    [Column("Pay Per")]
    public string? PayPer { get; set; }

    [Column("Pay Reason Code")]
    [StringLength(15)]
    public string? PayReasonCode { get; set; }

    [Column("Pay Reason")]
    public string? PayReason { get; set; }

    [Column("Personal Email")]
    [StringLength(255)]
    public string? PersonalEmail { get; set; }

    [Column("Person ID")]
    [StringLength(24)]
    public string? PersonId { get; set; }

    [Column("Position Code")]
    [StringLength(15)]
    public string? PositionCode { get; set; }

    [Column("Position Title")]
    public string? PositionTitle { get; set; }

    [Column("Postal Code")]
    [StringLength(12)]
    public string? PostalCode { get; set; }

    [Column("Primary Position Flag")]
    public bool? PrimaryPositionFlag { get; set; }

    [Column("Prior Service Credits", TypeName = "decimal(19, 4)")]
    public decimal? PriorServiceCredits { get; set; }

    [Column("Prior Service Units", TypeName = "decimal(19, 4)")]
    public decimal? PriorServiceUnits { get; set; }

    [Column("Project Code")]
    [StringLength(15)]
    public string? ProjectCode { get; set; }

    public string? Project { get; set; }

    [Column("Region Code")]
    [StringLength(15)]
    public string? RegionCode { get; set; }

    public string? Region { get; set; }

    [Column("Requisition Code")]
    [StringLength(15)]
    public string? RequisitionCode { get; set; }

    public string? Requisition { get; set; }

    [StringLength(5)]
    public string? Salutation { get; set; }

    [Column("Schedule Code")]
    [StringLength(15)]
    public string? ScheduleCode { get; set; }

    public string? Schedule { get; set; }

    [Column("Scheduled Review Date", TypeName = "datetime")]
    public DateTime? ScheduledReviewDate { get; set; }

    [Column("Section Code")]
    [StringLength(15)]
    public string? SectionCode { get; set; }

    public string? Section { get; set; }

    [Column("Shift Code")]
    [StringLength(15)]
    public string? ShiftCode { get; set; }

    public string? Shift { get; set; }

    [Column("SSN/SIN")]
    [StringLength(50)]
    public string? SsnSin { get; set; }

    [Column("Status Code")]
    [StringLength(15)]
    public string? StatusCode { get; set; }

    public string? Status { get; set; }

    [Column("Status Category Code")]
    [StringLength(15)]
    public string? StatusCategoryCode { get; set; }

    [Column("Status Category")]
    public string? StatusCategory { get; set; }

    [Column("Status End Date", TypeName = "datetime")]
    public DateTime? StatusEndDate { get; set; }

    [Column("Status Start Date", TypeName = "datetime")]
    public DateTime? StatusStartDate { get; set; }

    [Column("Status Reason Code")]
    [StringLength(15)]
    public string? StatusReasonCode { get; set; }

    [Column("Status Reason")]
    public string? StatusReason { get; set; }

    [StringLength(15)]
    public string? Step { get; set; }

    [Column("St/Prov Code")]
    [StringLength(15)]
    public string? StProvCode { get; set; }

    [Column("St/Prov MailingCode")]
    [StringLength(15)]
    public string? StProvMailingCode { get; set; }

    [Column("St/Prov")]
    public string? StProv { get; set; }

    [StringLength(125)]
    public string? Supervisor { get; set; }

    [Column("Veteran Code")]
    [StringLength(15)]
    public string? VeteranCode { get; set; }

    public string? Veteran { get; set; }

    [Column("Visa Exp Date", TypeName = "datetime")]
    public DateTime? VisaExpDate { get; set; }

    [Column("Visa Issue Date", TypeName = "datetime")]
    public DateTime? VisaIssueDate { get; set; }

    [Column("Visa Type Code")]
    [StringLength(15)]
    public string? VisaTypeCode { get; set; }

    [Column("Visa Type")]
    public string? VisaType { get; set; }

    [Column("Work Elig. Proof")]
    [StringLength(50)]
    public string? WorkEligProof { get; set; }
}
