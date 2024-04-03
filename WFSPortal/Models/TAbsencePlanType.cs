using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePlanType")]
[Index("AbsencePlanTypeGuid", Name = "RG_tAbsencePlanType", IsUnique = true)]
public partial class TAbsencePlanType
{
    [Key]
    [StringLength(15)]
    public string AbsencePlanTypeCode { get; set; } = null!;

    [Column("AbsencePlanTypeGUID")]
    public Guid AbsencePlanTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool PaySeveranceFlag { get; set; }

    public string? AbsencePlanTypeDescription { get; set; }

    [InverseProperty("AbsencePlanTypeCodeNavigation")]
    public virtual ICollection<TAbsencePlanDetailHist> TAbsencePlanDetailHists { get; set; } = new List<TAbsencePlanDetailHist>();
}
