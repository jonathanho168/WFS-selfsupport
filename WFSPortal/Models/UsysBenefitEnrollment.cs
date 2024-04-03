using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBenefitEnrollment")]
public partial class UsysBenefitEnrollment
{
    [StringLength(128)]
    public string UserName { get; set; } = null!;

    public Guid BenefitPlanOptionGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitEnrollmentStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitEnrollmentEndDate { get; set; }

    [Column("COBRAFlag")]
    public bool Cobraflag { get; set; }

    [StringLength(15)]
    public string? StartBenefitStatusCode { get; set; }

    [StringLength(15)]
    public string? EndBenefitStatusCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [Key]
    [Column("BenefitEnrollmentGUID")]
    public Guid BenefitEnrollmentGuid { get; set; }

    public int RowVersion { get; set; }
}
