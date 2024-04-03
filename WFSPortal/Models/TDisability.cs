using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDisability")]
[Index("DisabilityGuid", Name = "RG_tDisability", IsUnique = true)]
public partial class TDisability
{
    [Key]
    [StringLength(15)]
    public string DisabilityCode { get; set; } = null!;

    [StringLength(15)]
    public string? ReportValue { get; set; }

    [Column("DisabilityGUID")]
    public Guid DisabilityGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DisabilityDescription { get; set; }

    [InverseProperty("DisabilityCodeNavigation")]
    public virtual ICollection<TPersonal> TPersonals { get; set; } = new List<TPersonal>();
}
