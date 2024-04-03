using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTerminationType")]
[Index("TerminationTypeGuid", Name = "RG_tTerminationType", IsUnique = true)]
public partial class TTerminationType
{
    [Key]
    [StringLength(15)]
    public string TerminationTypeCode { get; set; } = null!;

    [Column("TerminationTypeGUID")]
    public Guid TerminationTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool VoluntaryFlag { get; set; }

    public bool LayoffFlag { get; set; }

    public string? TerminationTypeDescription { get; set; }

    [InverseProperty("TerminationTypeCodeNavigation")]
    public virtual ICollection<TPersonTermination> TPersonTerminations { get; set; } = new List<TPersonTermination>();
}
