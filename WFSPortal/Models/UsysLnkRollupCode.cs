using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkRollupCode")]
[Index("LnkRollupCodeGuid", Name = "RG_USysLnkRollupCode", IsUnique = true)]
public partial class UsysLnkRollupCode
{
    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [StringLength(15)]
    public string RollupCode { get; set; } = null!;

    [StringLength(80)]
    public string? RollupDescription { get; set; }

    [Key]
    [Column("LnkRollupCodeGUID")]
    public Guid LnkRollupCodeGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ExportId")]
    [InverseProperty("UsysLnkRollupCodes")]
    public virtual UsysLnkExportMaster Export { get; set; } = null!;

    [InverseProperty("LnkRollupCode")]
    public virtual ICollection<UsysLnkRollupBenefit> UsysLnkRollupBenefits { get; set; } = new List<UsysLnkRollupBenefit>();
}
