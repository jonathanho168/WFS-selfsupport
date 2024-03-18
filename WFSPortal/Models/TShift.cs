using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tShift")]
[Index("ShiftGuid", Name = "RG_tShift", IsUnique = true)]
public partial class TShift
{
    [Key]
    [StringLength(15)]
    public string ShiftCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("ShiftGUID")]
    public Guid ShiftGuid { get; set; }

    public int RowVersion { get; set; }

    public string? ShiftDescription { get; set; }

    [InverseProperty("ShiftCodeNavigation")]
    public virtual ICollection<TPersonIncident> TPersonIncidents { get; set; } = new List<TPersonIncident>();

    [InverseProperty("ShiftCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("ShiftCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("ShiftCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
