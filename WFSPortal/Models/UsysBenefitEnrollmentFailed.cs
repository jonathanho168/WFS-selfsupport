using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBenefitEnrollmentFailed")]
public partial class UsysBenefitEnrollmentFailed
{
    [StringLength(128)]
    public string UserName { get; set; } = null!;

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitEnrollmentFailedStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitEnrollmentFailedEndDate { get; set; }

    [Column("COBRAFlag")]
    public bool Cobraflag { get; set; }

    [StringLength(15)]
    public string? StartBenefitStatusCode { get; set; }

    [StringLength(15)]
    public string? EndBenefitStatusCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    public bool CalculateContributionFlag { get; set; }

    [StringLength(1024)]
    [Unicode(false)]
    public string? Eligibility { get; set; }

    [Column("ResponsiblePersonGUID")]
    public Guid ResponsiblePersonGuid { get; set; }

    [Key]
    [Column("BenefitEnrollmentFailedGUID")]
    public Guid BenefitEnrollmentFailedGuid { get; set; }

    public int RowVersion { get; set; }
}
