using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTimeDetail")]
[Index("PersonAbsenceGuid", Name = "IX_tPersonTimeDetail_PersonAbsenceGUID")]
[Index("PersonGuid", "ProjectCode", "PositionCode", "EntryDate", Name = "IX_tPersonTimeDetail_Project")]
public partial class TPersonTimeDetail
{
    [Key]
    [Column("TimeDetailGUID")]
    public Guid TimeDetailGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string TimeTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EntryDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EnteredHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RevisedHours { get; set; }

    [Column("PersonAbsenceGUID")]
    public Guid? PersonAbsenceGuid { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(15)]
    public string CompanyCode { get; set; } = null!;

    [StringLength(15)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(15)]
    public string CostCenterCode { get; set; } = null!;

    [StringLength(15)]
    public string FunctionalAreaCode { get; set; } = null!;

    [StringLength(15)]
    public string RegionCode { get; set; } = null!;

    [StringLength(15)]
    public string SectionCode { get; set; } = null!;

    [StringLength(15)]
    public string ProjectCode { get; set; } = null!;

    [StringLength(15)]
    public string OrganizationUnitCode { get; set; } = null!;

    [StringLength(15)]
    public string ShiftCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CalculatedHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeeOverrideHours { get; set; }

    [Column("RevisedByPersonGUID")]
    public Guid? RevisedByPersonGuid { get; set; }

    public string? RevisedByComments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployeeOverrideStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployeeOverrideEndTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RevisedStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RevisedEndTime { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column("HolidayOccurrenceGUID")]
    public Guid? HolidayOccurrenceGuid { get; set; }

    [ForeignKey("CompanyCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TCompany CompanyCodeNavigation { get; set; } = null!;

    [ForeignKey("CostCenterCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TCostCenter CostCenterCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TDepartment DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("DivisionCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TDivision DivisionCodeNavigation { get; set; } = null!;

    [ForeignKey("FunctionalAreaCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TFunctionalArea FunctionalAreaCodeNavigation { get; set; } = null!;

    [ForeignKey("HolidayOccurrenceGuid")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual THolidayOccurrence? HolidayOccurrence { get; set; }

    [ForeignKey("LocationCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TLocation LocationCodeNavigation { get; set; } = null!;

    [ForeignKey("OrganizationUnitCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TOrganizationUnit OrganizationUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonTimeDetailPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonAbsenceGuid")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TPersonAbsenceHist? PersonAbsence { get; set; }

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ProjectCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TProject ProjectCodeNavigation { get; set; } = null!;

    [ForeignKey("RegionCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TRegion RegionCodeNavigation { get; set; } = null!;

    [ForeignKey("RevisedByPersonGuid")]
    [InverseProperty("TPersonTimeDetailRevisedByPeople")]
    public virtual TPerson? RevisedByPerson { get; set; }

    [ForeignKey("SectionCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TSection SectionCodeNavigation { get; set; } = null!;

    [ForeignKey("ShiftCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TShift ShiftCodeNavigation { get; set; } = null!;

    [ForeignKey("TimeTypeCode")]
    [InverseProperty("TPersonTimeDetails")]
    public virtual TTimeType TimeTypeCodeNavigation { get; set; } = null!;
}
