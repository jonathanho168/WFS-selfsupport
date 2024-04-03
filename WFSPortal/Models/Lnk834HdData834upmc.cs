using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("Lnk_834_HdData_834UPMC")]
public partial class Lnk834HdData834upmc
{
    [StringLength(50)]
    [Unicode(false)]
    public string? RelationShipCode { get; set; }

    public bool? SpousalEquivalencyFlag { get; set; }

    public bool? FullTimeStudentFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisabilityCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusCategoryCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusStartDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BenefitTypeCode { get; set; }

    [Column("PersonBenefitHistGUID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PersonBenefitHistGuid { get; set; }

    [Column("PersonGUID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PersonGuid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BenefitPlanCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BenefitPlanOptionCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EligibilityDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StartBenefitStatusCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EndBenefitStatusCode { get; set; }

    public bool? CalculateContributionFlag { get; set; }

    [Column("COBRAFlag")]
    public bool? Cobraflag { get; set; }

    [Column("COBRAEndOfMonthFlag")]
    public bool? CobraendOfMonthFlag { get; set; }

    [Column("COBRAPeriodFirstPayment", TypeName = "money")]
    public decimal? CobraperiodFirstPayment { get; set; }

    public bool? ConsideredTobaccoUserFlag { get; set; }

    public bool? FixedAge { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? NumericValue1 { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? NumericValue2 { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? NumericValue3 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TextValue1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TextValue2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TextValue3 { get; set; }

    [Column("ResponsiblePersonGUID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePersonGuid { get; set; }

    public bool? PersonBenefitCurrentFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrimaryPhysicianCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RollupCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Account { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AccountStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AccountEndDate { get; set; }
}
