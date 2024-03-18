using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTimeGroupHist")]
[Index("PersonGuid", "PositionCode", "PersonTimeGroupStartDate", Name = "AK_tPersonTimeGroupHist", IsUnique = true)]
[Index("TimeGroupCode", "PersonTimeGroupStartDate", Name = "IX_tPersonTimeGroupHist_TimeGroupCode_PersonTimeGroupStartDate", IsDescending = new[] { false, true })]
public partial class TPersonTimeGroupHist
{
    [Key]
    [Column("PersonTimeGroupGUID")]
    public Guid PersonTimeGroupGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonTimeGroupStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonTimeGroupEndDate { get; set; }

    public bool PersonTimeGroupCurrentFlag { get; set; }

    [StringLength(15)]
    public string TimeGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string TimeZoneCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public bool MultiDayEntryFlag { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonTimeGroupHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonTimeGroupHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("TimeGroupCode")]
    [InverseProperty("TPersonTimeGroupHists")]
    public virtual TTimeGroup TimeGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("TimeZoneCode")]
    [InverseProperty("TPersonTimeGroupHists")]
    public virtual TTimeZone TimeZoneCodeNavigation { get; set; } = null!;
}
