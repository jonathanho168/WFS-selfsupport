using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkPersonLocationHistMax
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonLocationStartDate { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PersonLocationEndDate { get; set; }

    [StringLength(15)]
    public string LocationReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string CompanyCode { get; set; } = null!;

    [StringLength(15)]
    public string CostCenterCode { get; set; } = null!;

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(15)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(15)]
    public string FunctionalAreaCode { get; set; } = null!;

    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    [StringLength(15)]
    public string OrganizationUnitCode { get; set; } = null!;

    [StringLength(15)]
    public string ProjectCode { get; set; } = null!;

    [StringLength(15)]
    public string RegionCode { get; set; } = null!;

    [StringLength(15)]
    public string SectionCode { get; set; } = null!;

    [StringLength(15)]
    public string ShiftCode { get; set; } = null!;

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    public bool PersonLocationCurrentFlag { get; set; }

    [Column("PersonLocationGUID")]
    public Guid PersonLocationGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }
}
