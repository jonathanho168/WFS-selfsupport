using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBenefitEnrollmentEligibility")]
public partial class UsysBenefitEnrollmentEligibility
{
    [StringLength(128)]
    public string UserName { get; set; } = null!;

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitEnrollmentEligibilityStartDate { get; set; }

    public bool CalculateContributionFlag { get; set; }

    [Column("COBRAFlag")]
    public bool Cobraflag { get; set; }

    [StringLength(15)]
    public string? StartBenefitStatusCode { get; set; }

    [StringLength(15)]
    public string? EndBenefitStatusCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitEnrollmentEligibilityEndDate { get; set; }

    public string? Eligibility { get; set; }

    [Column("ResponsiblePersonGUID")]
    public Guid ResponsiblePersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [Key]
    [Column("BenefitEnrollmentEligibilityGUID")]
    public Guid BenefitEnrollmentEligibilityGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysBenefitEnrollmentEligibilities")]
    public virtual TPerson Person { get; set; } = null!;
}
