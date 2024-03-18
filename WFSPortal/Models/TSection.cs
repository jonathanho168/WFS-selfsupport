using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSection")]
[Index("SectionGuid", Name = "RG_tSection", IsUnique = true)]
public partial class TSection
{
    [Key]
    [StringLength(15)]
    public string SectionCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("SectionGUID")]
    public Guid SectionGuid { get; set; }

    public int RowVersion { get; set; }

    public string? SectionDescription { get; set; }

    [InverseProperty("SectionCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("SectionCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("SectionCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
