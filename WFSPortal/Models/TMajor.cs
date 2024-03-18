using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMajor")]
[Index("MajorGuid", Name = "RG_tMajor", IsUnique = true)]
public partial class TMajor
{
    [Key]
    [StringLength(15)]
    public string MajorCode { get; set; } = null!;

    [Column("MajorGUID")]
    public Guid MajorGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? MajorDescription { get; set; }

    [InverseProperty("MajorNavigation")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();

    [InverseProperty("MajorCodeNavigation")]
    public virtual ICollection<TPersonEducationHist> TPersonEducationHists { get; set; } = new List<TPersonEducationHist>();
}
