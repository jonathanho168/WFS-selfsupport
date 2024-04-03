using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tIncidentType")]
[Index("IncidentTypeGuid", Name = "RG_tIncidentType", IsUnique = true)]
public partial class TIncidentType
{
    [Key]
    [StringLength(15)]
    public string IncidentTypeCode { get; set; } = null!;

    [Column("IncidentTypeGUID")]
    public Guid IncidentTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? IncidentTypeDescription { get; set; }

    [InverseProperty("IncidentTypeCodeNavigation")]
    public virtual ICollection<TIncident> TIncidents { get; set; } = new List<TIncident>();
}
