using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPositionHist")]
public partial class TPositionHist
{
    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PositionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PositionEndDate { get; set; }

    public bool PositionCurrentFlag { get; set; }

    [StringLength(15)]
    public string? AlternatePositionCode { get; set; }

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(80)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    public bool OnHoldFlag { get; set; }

    public bool CanceledFlag { get; set; }

    [StringLength(15)]
    public string ReportsToPositionCode { get; set; } = null!;

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

    [Key]
    [Column("PositionGUID")]
    public Guid PositionGuid { get; set; }

    [StringLength(15)]
    public string OrgPublisherPositionTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string CurrentPositionStatusCode { get; set; } = null!;

    [Column("PITPositionStatusCode")]
    [StringLength(15)]
    public string PitpositionStatusCode { get; set; } = null!;

    public string? PositionTitle { get; set; }

    public string? PositionComments { get; set; }

    [ForeignKey("CompanyCode")]
    [InverseProperty("TPositionHists")]
    public virtual TCompany CompanyCodeNavigation { get; set; } = null!;

    [ForeignKey("CostCenterCode")]
    [InverseProperty("TPositionHists")]
    public virtual TCostCenter CostCenterCodeNavigation { get; set; } = null!;

    [ForeignKey("CurrentPositionStatusCode")]
    [InverseProperty("TPositionHistCurrentPositionStatusCodeNavigations")]
    public virtual TPositionStatus CurrentPositionStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("TPositionHists")]
    public virtual TDepartment DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("DivisionCode")]
    [InverseProperty("TPositionHists")]
    public virtual TDivision DivisionCodeNavigation { get; set; } = null!;

    [ForeignKey("FunctionalAreaCode")]
    [InverseProperty("TPositionHists")]
    public virtual TFunctionalArea FunctionalAreaCodeNavigation { get; set; } = null!;

    [ForeignKey("JobCode")]
    [InverseProperty("TPositionHists")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("LocationCode")]
    [InverseProperty("TPositionHists")]
    public virtual TLocation LocationCodeNavigation { get; set; } = null!;

    [ForeignKey("OrgPublisherPositionTypeCode")]
    [InverseProperty("TPositionHists")]
    public virtual TOrgPublisherPositionType OrgPublisherPositionTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("OrganizationUnitCode")]
    [InverseProperty("TPositionHists")]
    public virtual TOrganizationUnit OrganizationUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("PitpositionStatusCode")]
    [InverseProperty("TPositionHistPitpositionStatusCodeNavigations")]
    public virtual TPositionStatus PitpositionStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPositionHistPositionCodeNavigations")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ProjectCode")]
    [InverseProperty("TPositionHists")]
    public virtual TProject ProjectCodeNavigation { get; set; } = null!;

    [ForeignKey("RegionCode")]
    [InverseProperty("TPositionHists")]
    public virtual TRegion RegionCodeNavigation { get; set; } = null!;

    [ForeignKey("ReportsToPositionCode")]
    [InverseProperty("TPositionHistReportsToPositionCodeNavigations")]
    public virtual TPosition ReportsToPositionCodeNavigation { get; set; } = null!;

    [ForeignKey("SectionCode")]
    [InverseProperty("TPositionHists")]
    public virtual TSection SectionCodeNavigation { get; set; } = null!;

    [ForeignKey("ShiftCode")]
    [InverseProperty("TPositionHists")]
    public virtual TShift ShiftCodeNavigation { get; set; } = null!;
}
