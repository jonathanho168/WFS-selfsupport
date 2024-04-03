using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMassChangeField")]
[Index("MassChangeOperationGuid", "FieldName", Name = "AK_tMassChangeField", IsUnique = true)]
public partial class TMassChangeField
{
    [Column("MassChangeOperationGUID")]
    public Guid MassChangeOperationGuid { get; set; }

    [StringLength(128)]
    public string FieldName { get; set; } = null!;

    [StringLength(2000)]
    public string? OldValue { get; set; }

    [StringLength(2000)]
    public string? NewValue { get; set; }

    [Key]
    [Column("MassChangeFieldGUID")]
    public Guid MassChangeFieldGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("MassChangeOperationGuid")]
    [InverseProperty("TMassChangeFields")]
    public virtual TMassChangeOperation MassChangeOperation { get; set; } = null!;
}
