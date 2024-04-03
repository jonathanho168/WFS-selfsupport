using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDivision")]
[Index("DivisionGuid", Name = "RG_tDivision", IsUnique = true)]
public partial class TDivision
{
    [Key]
    [StringLength(15)]
    public string DivisionCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("DivisionGUID")]
    public Guid DivisionGuid { get; set; }

    public int RowVersion { get; set; }

    public string? DivisionDescription { get; set; }

    [InverseProperty("DivisionCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("DivisionCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("DivisionCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
