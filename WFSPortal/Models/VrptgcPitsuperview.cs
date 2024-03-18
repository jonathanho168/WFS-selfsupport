using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptgcPitsuperview
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

    [Column(TypeName = "datetime")]
    public DateTime? AdjustedHireDate { get; set; }

    public int? Age { get; set; }

    [Column(TypeName = "money")]
    public decimal? AnnualSalary { get; set; }

    [StringLength(15)]
    public string? BirthCountryCode { get; set; }

    [Column("Birth Country")]
    public string? BirthCountry { get; set; }

    [Column("Birth Date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("Birth Place")]
    [StringLength(40)]
    public string? BirthPlace { get; set; }

    [StringLength(80)]
    public string? BusinessCardTitle { get; set; }

    [Column("Citizen Country Code")]
    [StringLength(15)]
    public string? CitizenCountryCode { get; set; }

    [Column("Citizen Country")]
    public string? CitizenCountry { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string? CompanyCode { get; set; }

    public string? CompanyDescription { get; set; }

    [Column("Company Email")]
    [StringLength(255)]
    public string? CompanyEmail { get; set; }

    [StringLength(15)]
    public string? CostCenterCode { get; set; }

    public string? CostCenterDescription { get; set; }

    [Column("Country Code")]
    [StringLength(15)]
    public string? CountryCode { get; set; }

    public string? CountryDescription { get; set; }

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

    [StringLength(15)]
    public string? DepartmentCode { get; set; }

    public string? DepartmentDescription { get; set; }

    [Column("Disability Code")]
    [StringLength(15)]
    public string? DisabilityCode { get; set; }

    public string? DisabilityDescription { get; set; }

    [StringLength(15)]
    public string? DivisionCode { get; set; }

    public string? DivisionDescription { get; set; }

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

    [StringLength(20)]
    public string? FaxInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? FaxNationalPrefix { get; set; }

    [Column("Fax Area Code")]
    [StringLength(6)]
    [Unicode(false)]
    public string? FaxAreaCode { get; set; }

    [Column("Fax Phone")]
    [StringLength(20)]
    public string? FaxPhone { get; set; }

    [Column("First Name")]
    [StringLength(30)]
    public string? FirstName { get; set; }

    [Column("Former Last Name")]
    [StringLength(30)]
    public string? FormerLastName { get; set; }

    [Column("Full Name")]
    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string? FunctionalAreaCode { get; set; }

    [Column("Functional Area")]
    public string? FunctionalArea { get; set; }

    [Column("Gender Code")]
    [StringLength(15)]
    public string? GenderCode { get; set; }

    public string? Gender { get; set; }

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

    [StringLength(15)]
    public string? JobCode { get; set; }

    [StringLength(15)]
    public string? JobReasonCode { get; set; }

    [Column("Job Reason")]
    public string? JobReason { get; set; }

    [Column("Job Title")]
    public string? JobTitle { get; set; }

    [Column("Last Name")]
    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [StringLength(15)]
    public string? LocationCode { get; set; }

    public string? Location { get; set; }

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

    [StringLength(15)]
    public string? OrganizationUnitCode { get; set; }

    [Column("Organization Unit")]
    public string? OrganizationUnit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? PayEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayStartDate { get; set; }

    [StringLength(255)]
    public string? PersonalEmailAddress { get; set; }

    [Column(TypeName = "money")]
    public decimal? PersonBasePayAmount { get; set; }

    [StringLength(15)]
    public string? PersonBasePayFrequencyCode { get; set; }

    public string? FrequencyDescription { get; set; }

    [Column("Person ID")]
    [StringLength(24)]
    public string? PersonId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonJobStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonJobEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonLocationEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonLocationStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusStartDate { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public string? PositionTitle { get; set; }

    [Column("Postal Code")]
    [StringLength(12)]
    public string? PostalCode { get; set; }

    public bool? PrimaryPositionFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? FullTimeEquivalent { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PriorServiceCredits { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PriorServiceUnits { get; set; }

    [StringLength(15)]
    public string? RegionCode { get; set; }

    public string? RegionDescription { get; set; }

    [StringLength(15)]
    public string? RequisitionCode { get; set; }

    public string? RequisitionDescription { get; set; }

    [StringLength(5)]
    public string? Salutation { get; set; }

    [StringLength(15)]
    public string? ScheduleCode { get; set; }

    public string? ScheduleDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledBasePayReviewDate { get; set; }

    [StringLength(15)]
    public string? SectionCode { get; set; }

    public string? SectionDescription { get; set; }

    [StringLength(15)]
    public string? ShiftCode { get; set; }

    public string? ShiftDescription { get; set; }

    [Column("SSN/SIN")]
    [StringLength(50)]
    public string? SsnSin { get; set; }

    [StringLength(15)]
    public string? StatusCode { get; set; }

    public string? Status { get; set; }

    [StringLength(15)]
    public string? StatusCategoryCode { get; set; }

    public string? StatusCategoryDescription { get; set; }

    [StringLength(15)]
    public string? StatusReasonCode { get; set; }

    public string? StatusReasonDescription { get; set; }

    [Column("St/Prov Code")]
    [StringLength(15)]
    public string? StProvCode { get; set; }

    [Column("St/Mailing Code")]
    [StringLength(15)]
    public string? StMailingCode { get; set; }

    [Column("St/Prov")]
    public string? StProv { get; set; }

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    [StringLength(125)]
    public string? SupervisorFullName { get; set; }

    [StringLength(15)]
    public string? VeteranCode { get; set; }

    public string? VeteranDescription { get; set; }

    [Column("Visa Exp Date", TypeName = "datetime")]
    public DateTime? VisaExpDate { get; set; }

    [Column("Visa Issue Date", TypeName = "datetime")]
    public DateTime? VisaIssueDate { get; set; }

    [Column("Visa Type Code")]
    [StringLength(15)]
    public string? VisaTypeCode { get; set; }

    public string? VisaTypeDescription { get; set; }

    [Column("Work Elig. Proof")]
    [StringLength(50)]
    public string? WorkEligProof { get; set; }
}
