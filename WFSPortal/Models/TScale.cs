using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tScale")]
[Index("ScaleGuid", Name = "RG_tScale", IsUnique = true)]
public partial class TScale
{
    [Key]
    [StringLength(15)]
    public string ScaleCode { get; set; } = null!;

    [Column("ScaleGUID")]
    public Guid ScaleGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? ScaleDescription { get; set; }

    [InverseProperty("ScaleCodeNavigation")]
    public virtual ICollection<TCompetency> TCompetencies { get; set; } = new List<TCompetency>();

    [InverseProperty("ScaleCodeNavigation")]
    public virtual ICollection<TProficiency> TProficiencies { get; set; } = new List<TProficiency>();
}
