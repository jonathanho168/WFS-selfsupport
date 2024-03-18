using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class V834Hm
{
    [StringLength(15)]
    public string? RelationShipCode { get; set; }

    public bool? SpousalEquivalencyFlag { get; set; }

    public bool? FullTimeStudentFlag { get; set; }

    [StringLength(15)]
    public string? DisabilityCode { get; set; }

    [StringLength(15)]
    public string? StatusCode { get; set; }

    [StringLength(15)]
    public string? StatusCategoryCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusStartDate { get; set; }

    [StringLength(15)]
    public string BenefitTypeCode { get; set; } = null!;

    [Column("PersonBenefitHistGUID")]
    public Guid PersonBenefitHistGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitPlanOptionCode { get; set; } = null!;

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
}
