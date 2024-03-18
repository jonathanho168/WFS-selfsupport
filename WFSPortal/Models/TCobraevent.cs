using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCOBRAEvent")]
[Index("CobraeventGuid", Name = "RG_tCOBRAEvent", IsUnique = true)]
public partial class TCobraevent
{
    [Key]
    [Column("COBRAEventCode")]
    [StringLength(15)]
    public string CobraeventCode { get; set; } = null!;

    public byte? NotificationRightsPeriod { get; set; }

    public byte? ElectionPeriod { get; set; }

    public byte? MaximumCoveragePeriod { get; set; }

    public byte? StandardCoverageDuration { get; set; }

    [Column("COBRAEventGUID")]
    public Guid CobraeventGuid { get; set; }

    [Column("COBRAEventTypeCode")]
    [StringLength(15)]
    public string CobraeventTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("COBRAEventDescription")]
    public string? CobraeventDescription { get; set; }

    [ForeignKey("CobraeventTypeCode")]
    [InverseProperty("TCobraevents")]
    public virtual TCobraeventType CobraeventTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("CobraeventCodeNavigation")]
    public virtual ICollection<TPersonCobra> TPersonCobras { get; set; } = new List<TPersonCobra>();
}
