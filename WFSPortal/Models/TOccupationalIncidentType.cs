using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOccupationalIncidentType")]
[Index("OccupationalIncidentTypeGuid", Name = "RG_tOccupationalIncidentType", IsUnique = true)]
public partial class TOccupationalIncidentType
{
    [Key]
    [StringLength(15)]
    public string OccupationalIncidentTypeCode { get; set; } = null!;

    [Column("OccupationalIncidentTypeGUID")]
    public Guid OccupationalIncidentTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? OccupationalIncidentTypeDescription { get; set; }

    [InverseProperty("OccupationalIncidentTypeCodeNavigation")]
    public virtual ICollection<TIncident> TIncidents { get; set; } = new List<TIncident>();
}
