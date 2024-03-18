using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonFactTable
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    public int? Age { get; set; }

    public bool? EmployeeFlag { get; set; }

    public bool? ApplicantFlag { get; set; }

    public bool? DependentFlag { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string? StateProvinceCode { get; set; }

    [StringLength(15)]
    public string? CountryCode { get; set; }

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [StringLength(15)]
    public string PrimaryPhysicianCode { get; set; } = null!;

    [StringLength(15)]
    public string PrimaryMedicalFacilityCode { get; set; } = null!;

    [StringLength(15)]
    public string BloodTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? LastPhysicalDate { get; set; }

    public int? LastPhysicalYear { get; set; }

    public int? LastPhysicalQuarter { get; set; }

    public int? LastPhysicalMonth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NextPhysicalDate { get; set; }

    public int? NextPhysicalYear { get; set; }

    public int? NextPhysicalQuarter { get; set; }

    public int? NextPhysicalMonth { get; set; }

    public bool? TobaccoUserFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    public int? BirthYear { get; set; }

    public int? BirthQuarter { get; set; }

    public int? BirthMonth { get; set; }

    [StringLength(15)]
    public string? DisabilityCode { get; set; }

    [StringLength(15)]
    public string? FamilyStatusCode { get; set; }

    [StringLength(15)]
    public string? GenderCode { get; set; }

    [StringLength(15)]
    public string? PassportCountryCode { get; set; }

    [StringLength(15)]
    public string? VeteranCode { get; set; }

    [StringLength(15)]
    public string? VisaTypeCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VisaExpireDate { get; set; }

    public int? VisaExpirationYear { get; set; }

    public int? VisaExpirationQuarter { get; set; }

    public int? VisaExpirationMonth { get; set; }

    [StringLength(15)]
    public string? EthnicGroupCode { get; set; }

    public bool? ActiveFlag { get; set; }

    [StringLength(15)]
    public string? StatusCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    public int? HireDateYear { get; set; }

    public int? HireDateQuarter { get; set; }

    public int? HireDateMonth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SeniorityDate { get; set; }

    public int? SeniorityDateYear { get; set; }

    public int? SeniorityDateQuarter { get; set; }

    public int? SeniorityDateMonth { get; set; }

    [StringLength(15)]
    public string? CompanyCode { get; set; }

    [StringLength(15)]
    public string? DepartmentCode { get; set; }

    [StringLength(15)]
    public string? LocationCode { get; set; }

    [StringLength(15)]
    public string? OrganizationUnitCode { get; set; }

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    [StringLength(125)]
    public string? Supervisor { get; set; }

    [StringLength(15)]
    public string? JobCode { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? FullTimeEquivalent { get; set; }

    public bool? PrimaryPositionFlag { get; set; }

    [Column("EEOCategoryCode")]
    [StringLength(15)]
    public string? EeocategoryCode { get; set; }

    [StringLength(15)]
    public string? CostCenterCode { get; set; }

    [StringLength(15)]
    public string? DivisionCode { get; set; }

    [StringLength(15)]
    public string? FunctionalAreaCode { get; set; }

    [StringLength(15)]
    public string? LocationReasonCode { get; set; }

    [StringLength(15)]
    public string? ProjectCode { get; set; }

    [StringLength(15)]
    public string? RegionCode { get; set; }

    [StringLength(15)]
    public string? SectionCode { get; set; }

    [StringLength(15)]
    public string? ShiftCode { get; set; }

    [StringLength(15)]
    public string? JobCategoryCode { get; set; }

    [StringLength(15)]
    public string? JobReasonCode { get; set; }

    [StringLength(15)]
    public string? OvertimeStatusCode { get; set; }

    [StringLength(15)]
    public string? StatusReasonCode { get; set; }

    [StringLength(15)]
    public string? GradeCode { get; set; }

    [StringLength(15)]
    public string? WorkersCompensationCode { get; set; }

    [StringLength(15)]
    public string? BasePayReasonCode { get; set; }

    public int? NumberOfServiceYears { get; set; }

    public int? NumberOfServiceMonths { get; set; }

    public int? NumberOfServiceDays { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HourlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? WeeklyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MonthlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualRate { get; set; }
}
