using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VWesleyActiveSuperviewFix
{
    [Column(TypeName = "datetime")]
    public DateTime? AdjustedHireDate { get; set; }

    public int? Age { get; set; }

    [Column(TypeName = "money")]
    public decimal? AnnualSalary { get; set; }

    [Column("Birth Country Code")]
    [StringLength(15)]
    public string BirthCountryCode { get; set; } = null!;

    [Column("Birth Date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("Birth Place")]
    [StringLength(40)]
    public string? BirthPlace { get; set; }

    [StringLength(80)]
    public string? BusinessCardTitle { get; set; }

    [Column("Citizen Country Code")]
    [StringLength(15)]
    public string CitizenCountryCode { get; set; } = null!;

    [StringLength(15)]
    public string CompanyCode { get; set; } = null!;

    [Column("Company Email")]
    [StringLength(255)]
    public string? CompanyEmail { get; set; }

    [StringLength(15)]
    public string CostCenterCode { get; set; } = null!;

    [Column("Cost Center")]
    public string? CostCenter { get; set; }

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    public string? Department { get; set; }

    [Column("Disability Code")]
    [StringLength(15)]
    public string DisabilityCode { get; set; } = null!;

    [StringLength(15)]
    public string DivisionCode { get; set; } = null!;

    public string? Division { get; set; }

    [Column("Drv Lic Exp Date", TypeName = "datetime")]
    public DateTime? DrvLicExpDate { get; set; }

    [Column("Drv Lic #")]
    [StringLength(30)]
    public string? DrvLic { get; set; }

    [Column("Drv Lic St/Prov Code")]
    [StringLength(15)]
    public string DrvLicStProvCode { get; set; } = null!;

    [Column("Employee ID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [Column("Ethnic Group Code")]
    [StringLength(15)]
    public string EthnicGroupCode { get; set; } = null!;

    [Column("Family Status Code")]
    [StringLength(15)]
    public string FamilyStatusCode { get; set; } = null!;

    [Column("Family Status")]
    public string? FamilyStatus { get; set; }

    [Column("Former Last Name")]
    [StringLength(30)]
    public string? FormerLastName { get; set; }

    [Column("Full Name")]
    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string FunctionalAreaCode { get; set; } = null!;

    [Column("Functional Area")]
    public string? FunctionalArea { get; set; }

    [Column("Gender Code")]
    [StringLength(15)]
    public string GenderCode { get; set; } = null!;

    public string? Gender { get; set; }

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string JobReasonCode { get; set; } = null!;

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
    public string LocationCode { get; set; } = null!;

    public string? Location { get; set; }

    [Column("Middle Name")]
    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(30)]
    public string? Nickname { get; set; }

    [StringLength(15)]
    public string OrganizationUnitCode { get; set; } = null!;

    [Column("Organization Unit")]
    public string? OrganizationUnit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayStartDate { get; set; }

    [Column("Personal Email")]
    [StringLength(255)]
    public string? PersonalEmail { get; set; }

    [Column(TypeName = "money")]
    public decimal? PersonBasePayAmount { get; set; }

    [StringLength(15)]
    public string? PersonBasePayFrequencyCode { get; set; }

    public string? PersonBasePayFrequency { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("Person ID")]
    [StringLength(24)]
    public string? PersonId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonJobStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonJobEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonLocationEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonLocationStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusStartDate { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column("Position Title")]
    public string? PositionTitle { get; set; }

    public bool PrimaryPositionFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? FullTimeEquivalent { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PriorServiceCredits { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PriorServiceUnits { get; set; }

    [StringLength(15)]
    public string RegionCode { get; set; } = null!;

    public string? Region { get; set; }

    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    public string? Requisition { get; set; }

    [StringLength(5)]
    public string? Salutation { get; set; }

    [StringLength(15)]
    public string? ScheduleCode { get; set; }

    public string? Schedule { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledBasePayReviewDate { get; set; }

    [StringLength(15)]
    public string SectionCode { get; set; } = null!;

    public string? Section { get; set; }

    [StringLength(15)]
    public string ShiftCode { get; set; } = null!;

    [StringLength(15)]
    public string? StatusCode { get; set; }

    public string? Status { get; set; }

    [StringLength(15)]
    public string? StatusCategoryCode { get; set; }

    [Column("Status Category")]
    public string? StatusCategory { get; set; }

    [StringLength(15)]
    public string? StatusReasonCode { get; set; }

    [Column("Status Reason")]
    public string? StatusReason { get; set; }

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    [StringLength(125)]
    public string? SupervisorFullName { get; set; }

    [Column("Work Elig. Proof")]
    [StringLength(50)]
    public string? WorkEligProof { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }
}
