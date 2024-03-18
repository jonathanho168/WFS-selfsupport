using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTerminationReason")]
[Index("TerminationReasonGuid", Name = "RG_tTerminationReason", IsUnique = true)]
public partial class TTerminationReason
{
    [Key]
    [StringLength(15)]
    public string TerminationReasonCode { get; set; } = null!;

    [Column("TerminationReasonGUID")]
    public Guid TerminationReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? TerminationReasonDescription { get; set; }

    [InverseProperty("TerminationReasonCodeNavigation")]
    public virtual ICollection<TPersonTermination> TPersonTerminations { get; set; } = new List<TPersonTermination>();
}
