using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonScheduleDate")]
[Index("PersonGuid", "PositionCode", Name = "AK_tPersonScheduleDate", IsUnique = true)]
public partial class TPersonScheduleDate
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime NextPerformanceReviewDate { get; set; }

    [Key]
    [Column("PersonScheduleDateGUID")]
    public Guid PersonScheduleDateGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonScheduleDates")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonScheduleDates")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;
}
