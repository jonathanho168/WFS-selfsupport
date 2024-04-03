using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonLocationHist")]
[Index("SupervisorPersonGuid", Name = "IX_tPersonLocationHist_SupervisorPersonGUID")]
[Index("PersonLocationCurrentFlag", Name = "WFS_tPersonLocationHist_PersonLocationCurrentFlag")]
public partial class TPersonLocationHist
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

    [Key]
    [Column("PersonLocationGUID")]
    public Guid PersonLocationGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("CompanyCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TCompany CompanyCodeNavigation { get; set; } = null!;

    [ForeignKey("CostCenterCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TCostCenter CostCenterCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TDepartment DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("DivisionCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TDivision DivisionCodeNavigation { get; set; } = null!;

    [ForeignKey("FunctionalAreaCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TFunctionalArea FunctionalAreaCodeNavigation { get; set; } = null!;

    [ForeignKey("LocationCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TLocation LocationCodeNavigation { get; set; } = null!;

    [ForeignKey("LocationReasonCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TLocationReason LocationReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("OrganizationUnitCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TOrganizationUnit OrganizationUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonLocationHistPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ProjectCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TProject ProjectCodeNavigation { get; set; } = null!;

    [ForeignKey("RegionCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TRegion RegionCodeNavigation { get; set; } = null!;

    [ForeignKey("SectionCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TSection SectionCodeNavigation { get; set; } = null!;

    [ForeignKey("ShiftCode")]
    [InverseProperty("TPersonLocationHists")]
    public virtual TShift ShiftCodeNavigation { get; set; } = null!;

    [ForeignKey("SupervisorPersonGuid")]
    [InverseProperty("TPersonLocationHistSupervisorPeople")]
    public virtual TPerson? SupervisorPerson { get; set; }
}
