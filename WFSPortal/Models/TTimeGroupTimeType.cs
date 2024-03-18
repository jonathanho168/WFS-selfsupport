using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTimeGroupTimeType")]
public partial class TTimeGroupTimeType
{
    [Key]
    [Column("TimeGroupTimeTypeGUID")]
    public Guid TimeGroupTimeTypeGuid { get; set; }

    [StringLength(15)]
    public string TimeGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string TimeTypeCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MinimumHours { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MaximumHours { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? Increment { get; set; }

    public int? SummaryPageSortOrder { get; set; }

    public bool AccumulateForOvertimeFlag { get; set; }

    public bool ConvertibleToOvertimeFlag { get; set; }

    public bool EmployeeEntryBlockedFlag { get; set; }

    public bool RevisedEntryBlockedFlag { get; set; }

    public int RoundingMethod { get; set; }

    public int RowVersion { get; set; }

    public bool HideAllocationFlag { get; set; }

    [ForeignKey("TimeGroupCode")]
    [InverseProperty("TTimeGroupTimeTypes")]
    public virtual TTimeGroup TimeGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("TimeTypeCode")]
    [InverseProperty("TTimeGroupTimeTypes")]
    public virtual TTimeType TimeTypeCodeNavigation { get; set; } = null!;
}
