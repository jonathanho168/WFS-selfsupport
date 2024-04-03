using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_UPMC_w_834UPMC2300")]
public partial class LnkUpmcW834upmc2300
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("MaintenanceTypeCode-HD01")]
    [StringLength(3)]
    [Unicode(false)]
    public string? MaintenanceTypeCodeHd01 { get; set; }

    [Column("MaintenanceReasonCode-HD02")]
    [StringLength(3)]
    [Unicode(false)]
    public string? MaintenanceReasonCodeHd02 { get; set; }

    [Column("InsuranceLineCode-HD03")]
    [StringLength(15)]
    [Unicode(false)]
    public string? InsuranceLineCodeHd03 { get; set; }

    [Column("PlanCoverageDescription-HD04")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PlanCoverageDescriptionHd04 { get; set; }

    [Column("CoverageLevelCode-HD05")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CoverageLevelCodeHd05 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? BenefitPlanCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? BenefitOption { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? BenefitTypeCode { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal? EnrollmentCountByType { get; set; }
}
