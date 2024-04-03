using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOvertimeRuleDetail")]
public partial class TOvertimeRuleDetail
{
    [Key]
    [Column("OvertimeRuleDetailGUID")]
    public Guid OvertimeRuleDetailGuid { get; set; }

    [StringLength(15)]
    public string OvertimeRuleCode { get; set; } = null!;

    [StringLength(15)]
    public string ToTimeTypeCode { get; set; } = null!;

    public bool SundayFlag { get; set; }

    public bool MondayFlag { get; set; }

    public bool TuesdayFlag { get; set; }

    public bool WednesdayFlag { get; set; }

    public bool ThursdayFlag { get; set; }

    public bool FridayFlag { get; set; }

    public bool SaturdayFlag { get; set; }

    public bool HolidayFlag { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal MinimumHours { get; set; }

    public bool PeriodFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CompTimeMultiplier { get; set; }

    [ForeignKey("OvertimeRuleCode")]
    [InverseProperty("TOvertimeRuleDetails")]
    public virtual TOvertimeRule OvertimeRuleCodeNavigation { get; set; } = null!;

    [ForeignKey("ToTimeTypeCode")]
    [InverseProperty("TOvertimeRuleDetails")]
    public virtual TTimeType ToTimeTypeCodeNavigation { get; set; } = null!;
}
