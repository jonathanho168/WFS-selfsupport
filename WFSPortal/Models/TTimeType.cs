using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTimeType")]
[Index("TimeTypeGuid", Name = "RG_tTimeType", IsUnique = true)]
public partial class TTimeType
{
    [Key]
    [StringLength(15)]
    public string TimeTypeCode { get; set; } = null!;

    public bool PaidFlag { get; set; }

    public bool ExcusedFlag { get; set; }

    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("TimeTypeGUID")]
    public Guid TimeTypeGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(50)]
    public string? TimeTypeColor { get; set; }

    public bool TimeWorkedFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? SalaryMultiplier { get; set; }

    public string? TimeTypeDescription { get; set; }

    public bool HolidayFlag { get; set; }

    [Column("OTZeroRate")]
    public bool? OtzeroRate { get; set; }

    public bool OverTime { get; set; }

    public bool DoubleOverTime { get; set; }

    public bool? BlockEmployeeEditingFlag { get; set; }

    [ForeignKey("AbsencePlanCode")]
    [InverseProperty("TTimeTypes")]
    public virtual TAbsencePlan AbsencePlanCodeNavigation { get; set; } = null!;

    [InverseProperty("ToTimeTypeCodeNavigation")]
    public virtual ICollection<TOvertimeRuleDetail> TOvertimeRuleDetails { get; set; } = new List<TOvertimeRuleDetail>();

    [InverseProperty("TimeTypeCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("TimeTypeCodeNavigation")]
    public virtual ICollection<TPersonTimeGroupPeriodOvertime> TPersonTimeGroupPeriodOvertimes { get; set; } = new List<TPersonTimeGroupPeriodOvertime>();

    [InverseProperty("TimeTypeCodeNavigation")]
    public virtual ICollection<TTimeGroupTimeType> TTimeGroupTimeTypes { get; set; } = new List<TTimeGroupTimeType>();

    [InverseProperty("HolidayTimeTypeCodeNavigation")]
    public virtual ICollection<TTimeGroup> TTimeGroups { get; set; } = new List<TTimeGroup>();
}
