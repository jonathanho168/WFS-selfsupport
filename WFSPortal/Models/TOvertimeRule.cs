using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOvertimeRule")]
[Index("OvertimeRuleGuid", Name = "RG_tOvertimeRule", IsUnique = true)]
public partial class TOvertimeRule
{
    [Key]
    [StringLength(15)]
    public string OvertimeRuleCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("OvertimeRuleGUID")]
    public Guid OvertimeRuleGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(128)]
    public string? CalculatorFunction { get; set; }

    public string? OvertimeRuleDescription { get; set; }

    [InverseProperty("OvertimeRuleCodeNavigation")]
    public virtual ICollection<TOvertimeRuleDetail> TOvertimeRuleDetails { get; set; } = new List<TOvertimeRuleDetail>();

    [InverseProperty("OvertimeRuleCodeNavigation")]
    public virtual ICollection<TTimeGroupPeriod> TTimeGroupPeriods { get; set; } = new List<TTimeGroupPeriod>();

    [InverseProperty("DefaultOvertimeRuleCodeNavigation")]
    public virtual ICollection<TTimeGroup> TTimeGroups { get; set; } = new List<TTimeGroup>();
}
