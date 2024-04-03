using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkDataGroupingField")]
public partial class UsysLnkDataGroupingField
{
    [Key]
    [Column("LnkDataGroupingFieldGUID")]
    public Guid LnkDataGroupingFieldGuid { get; set; }

    [Column("LnkDataGroupingGUID")]
    public Guid LnkDataGroupingGuid { get; set; }

    [Column("LnkFieldDefGUID")]
    public Guid LnkFieldDefGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkDataGroupingGuid")]
    [InverseProperty("UsysLnkDataGroupingFields")]
    public virtual UsysLnkDataGrouping LnkDataGrouping { get; set; } = null!;

    [ForeignKey("LnkFieldDefGuid")]
    [InverseProperty("UsysLnkDataGroupingFields")]
    public virtual UsysLnkFieldDef LnkFieldDef { get; set; } = null!;
}
