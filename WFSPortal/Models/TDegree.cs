using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDegree")]
[Index("DegreeGuid", Name = "RG_tDegree", IsUnique = true)]
public partial class TDegree
{
    [Key]
    [StringLength(15)]
    public string DegreeCode { get; set; } = null!;

    [Column("DegreeGUID")]
    public Guid DegreeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DegreeDescription { get; set; }

    [InverseProperty("DegreeCodeNavigation")]
    public virtual ICollection<TPersonEducationHist> TPersonEducationHists { get; set; } = new List<TPersonEducationHist>();
}
