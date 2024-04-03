using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTimeGroup")]
[Index("TimeGroupGuid", Name = "RG_tTimeGroup", IsUnique = true)]
public partial class TTimeGroup
{
    [Key]
    [StringLength(15)]
    public string TimeGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string TimesheetEntryMethod { get; set; } = null!;

    public bool LocationCodeFlag { get; set; }

    public bool DepartmentCodeFlag { get; set; }

    public bool CompanyCodeFlag { get; set; }

    public bool DivisionCodeFlag { get; set; }

    public bool FunctionalAreaCodeFlag { get; set; }

    public bool CostCenterCodeFlag { get; set; }

    public bool RegionCodeFlag { get; set; }

    public bool SectionCodeFlag { get; set; }

    public bool ProjectCodeFlag { get; set; }

    public bool OrganizationUnitCodeFlag { get; set; }

    public bool ShiftCodeFlag { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("TimeGroupGUID")]
    public Guid TimeGroupGuid { get; set; }

    public int RowVersion { get; set; }

    public bool AllowClockInOutOverrideFlag { get; set; }

    [StringLength(15)]
    public string HolidayTimeTypeCode { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? AutoGenFrequencyCode { get; set; }

    public short? AutoGenDaysInAdvance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AutoGenStartDate { get; set; }

    [StringLength(15)]
    public string DefaultOvertimeRuleCode { get; set; } = null!;

    public string? TimeGroupDescription { get; set; }

    public bool AllowEmployeeNewRecordEntryFlag { get; set; }

    [Column("OTSchedule")]
    [StringLength(15)]
    public string? Otschedule { get; set; }

    [ForeignKey("DefaultOvertimeRuleCode")]
    [InverseProperty("TTimeGroups")]
    public virtual TOvertimeRule DefaultOvertimeRuleCodeNavigation { get; set; } = null!;

    [ForeignKey("HolidayTimeTypeCode")]
    [InverseProperty("TTimeGroups")]
    public virtual TTimeType HolidayTimeTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("Otschedule")]
    [InverseProperty("TTimeGroups")]
    public virtual TSchedule? OtscheduleNavigation { get; set; }

    [InverseProperty("JobTimeGroupCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();

    [InverseProperty("TimeGroupCodeNavigation")]
    public virtual ICollection<TPersonOvertimeHist> TPersonOvertimeHists { get; set; } = new List<TPersonOvertimeHist>();

    [InverseProperty("TimeGroupCodeNavigation")]
    public virtual ICollection<TPersonTimeGroupHist> TPersonTimeGroupHists { get; set; } = new List<TPersonTimeGroupHist>();

    [InverseProperty("TimeGroupCodeNavigation")]
    public virtual ICollection<TTimeGroupHoliday> TTimeGroupHolidays { get; set; } = new List<TTimeGroupHoliday>();

    [InverseProperty("TimeGroupCodeNavigation")]
    public virtual ICollection<TTimeGroupPeriod> TTimeGroupPeriods { get; set; } = new List<TTimeGroupPeriod>();

    [InverseProperty("TimeGroupCodeNavigation")]
    public virtual ICollection<TTimeGroupTimeType> TTimeGroupTimeTypes { get; set; } = new List<TTimeGroupTimeType>();

    [InverseProperty("TimeGroupCodeNavigation")]
    public virtual ICollection<UsysTimeCostModelPerson> UsysTimeCostModelPeople { get; set; } = new List<UsysTimeCostModelPerson>();
}
