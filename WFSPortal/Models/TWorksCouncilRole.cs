using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tWorksCouncilRole")]
public partial class TWorksCouncilRole
{
    [Key]
    [StringLength(15)]
    public string WorksCouncilRoleCode { get; set; } = null!;

    public string? WorksCouncilRoleDescription { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("WorksCouncilRoleGUID")]
    public Guid WorksCouncilRoleGuid { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("WorksCouncilRoleCodeNavigation")]
    public virtual ICollection<TPersonWorksCouncilHist> TPersonWorksCouncilHists { get; set; } = new List<TPersonWorksCouncilHist>();
}
