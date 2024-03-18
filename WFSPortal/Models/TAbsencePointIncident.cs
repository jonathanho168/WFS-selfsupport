using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePointIncident")]
public partial class TAbsencePointIncident
{
    [Column("AbsencePointIncidentGUID")]
    public Guid AbsencePointIncidentGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string AbsencePointIncidentCode { get; set; } = null!;

    public string? AbsencePointIncidentDescription { get; set; }

    public bool InactiveFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? IncidentPoints { get; set; }

    public bool? IncreasesPointsFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("AbsencePointIncidentCodeNavigation")]
    public virtual ICollection<TPersonAbsencePoint> TPersonAbsencePoints { get; set; } = new List<TPersonAbsencePoint>();
}
