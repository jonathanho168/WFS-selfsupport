using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAlternateCompetency")]
[Index("CompetencyCode", "AlternateCompetencyCode", Name = "AK_tAlternateCompetency", IsUnique = true)]
public partial class TAlternateCompetency
{
    [StringLength(15)]
    public string CompetencyCode { get; set; } = null!;

    [StringLength(15)]
    public string AlternateCompetencyCode { get; set; } = null!;

    [Key]
    [Column("AlternateCompetencyGUID")]
    public Guid AlternateCompetencyGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("AlternateCompetencyCode")]
    [InverseProperty("TAlternateCompetencyAlternateCompetencyCodeNavigations")]
    public virtual TCompetency AlternateCompetencyCodeNavigation { get; set; } = null!;

    [ForeignKey("CompetencyCode")]
    [InverseProperty("TAlternateCompetencyCompetencyCodeNavigations")]
    public virtual TCompetency CompetencyCodeNavigation { get; set; } = null!;
}
