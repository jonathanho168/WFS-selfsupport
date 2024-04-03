using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTimeGroupPeriod")]
public partial class TTimeGroupPeriod
{
    [Key]
    [Column("TimeGroupPeriodGUID")]
    public Guid TimeGroupPeriodGuid { get; set; }

    [StringLength(15)]
    public string TimeGroupCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TimeGroupPeriodStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeGroupPeriodEndDate { get; set; }

    public int RowVersion { get; set; }

    public bool ClosedFlag { get; set; }

    [StringLength(15)]
    public string OvertimeRuleCode { get; set; } = null!;

    [ForeignKey("OvertimeRuleCode")]
    [InverseProperty("TTimeGroupPeriods")]
    public virtual TOvertimeRule OvertimeRuleCodeNavigation { get; set; } = null!;

    [InverseProperty("TimeGroupPeriod")]
    public virtual ICollection<TPersonTimeGroupPeriod> TPersonTimeGroupPeriods { get; set; } = new List<TPersonTimeGroupPeriod>();

    [ForeignKey("TimeGroupCode")]
    [InverseProperty("TTimeGroupPeriods")]
    public virtual TTimeGroup TimeGroupCodeNavigation { get; set; } = null!;
}
