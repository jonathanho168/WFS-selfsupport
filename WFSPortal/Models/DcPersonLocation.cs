using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonLocation")]
public partial class DcPersonLocation
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonLocationStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonLocationEndDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LocationReasonCode { get; set; }

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

    [Column("SupervisorSSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SupervisorSsn { get; set; }
}
