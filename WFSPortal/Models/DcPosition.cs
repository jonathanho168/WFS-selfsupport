using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPosition")]
public partial class DcPosition
{
    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PositionTitle { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PositionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PositionEndDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReportsToPositionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CompanyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CostCenterCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DepartmentCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DivisionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FunctionalAreaCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LocationCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrganizationUnitCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SectionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShiftCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrgPublisherPositionTypeCode { get; set; }
}
