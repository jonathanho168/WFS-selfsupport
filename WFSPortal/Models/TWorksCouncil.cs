using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tWorksCouncil")]
public partial class TWorksCouncil
{
    [Key]
    [StringLength(15)]
    public string WorksCouncilCode { get; set; } = null!;

    public string? WorksCouncilDescription { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("WorksCouncilGUID")]
    public Guid WorksCouncilGuid { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("WorksCouncilCodeNavigation")]
    public virtual ICollection<TPersonWorksCouncilHist> TPersonWorksCouncilHists { get; set; } = new List<TPersonWorksCouncilHist>();
}
