using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMilitaryStatus")]
[Index("MilitaryStatusGuid", Name = "RG_tMilitaryStatus", IsUnique = true)]
public partial class TMilitaryStatus
{
    [Key]
    [StringLength(15)]
    public string MilitaryStatusCode { get; set; } = null!;

    public bool EligibleForDutyFlag { get; set; }

    [Column("MilitaryStatusGUID")]
    public Guid MilitaryStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? MilitaryStatusDescription { get; set; }

    [InverseProperty("MilitaryStatusCodeNavigation")]
    public virtual ICollection<TPersonMilitaryHist> TPersonMilitaryHists { get; set; } = new List<TPersonMilitaryHist>();
}
