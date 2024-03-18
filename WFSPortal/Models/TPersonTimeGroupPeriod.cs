using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTimeGroupPeriod")]
[Index("TimeGroupPeriodGuid", "PersonGuid", "PositionCode", Name = "AK_tPersonTimeGroupPeriod", IsUnique = true)]
public partial class TPersonTimeGroupPeriod
{
    [Key]
    [Column("PersonTimeGroupPeriodGUID")]
    public Guid PersonTimeGroupPeriodGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column("TimeGroupPeriodGUID")]
    public Guid TimeGroupPeriodGuid { get; set; }

    public bool SubmittedFlag { get; set; }

    [Column("RoutingInstanceGUID")]
    public Guid? RoutingInstanceGuid { get; set; }

    public bool ApprovedFlag { get; set; }

    public string? ApprovedComments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SentToPayrollDate { get; set; }

    public int RowVersion { get; set; }

    public int? ExportJobId { get; set; }

    public string? EmployeeComments { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonTimeGroupPeriods")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonTimeGroupPeriods")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [InverseProperty("PersonTimeGroupPeriod")]
    public virtual ICollection<TPersonTimeGroupPeriodOvertime> TPersonTimeGroupPeriodOvertimes { get; set; } = new List<TPersonTimeGroupPeriodOvertime>();

    [ForeignKey("TimeGroupPeriodGuid")]
    [InverseProperty("TPersonTimeGroupPeriods")]
    public virtual TTimeGroupPeriod TimeGroupPeriod { get; set; } = null!;
}
