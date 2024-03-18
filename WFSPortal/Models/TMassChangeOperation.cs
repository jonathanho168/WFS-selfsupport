using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMassChangeOperation")]
[Index("MassChangeGuid", "TableName", "RecordGuid", Name = "AK_tMassChangeOperation", IsUnique = true)]
public partial class TMassChangeOperation
{
    [Key]
    [Column("MassChangeOperationGUID")]
    public Guid MassChangeOperationGuid { get; set; }

    [Column("MassChangeGUID")]
    public Guid MassChangeGuid { get; set; }

    [Column("RecordGUID")]
    public Guid? RecordGuid { get; set; }

    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [StringLength(128)]
    public string TableName { get; set; } = null!;

    public bool SucceededFlag { get; set; }

    [StringLength(1000)]
    public string? ErrorMessage { get; set; }

    public int RowsAffected { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("MassChangeGuid")]
    [InverseProperty("TMassChangeOperations")]
    public virtual TMassChange MassChange { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TMassChangeOperations")]
    public virtual TPerson? Person { get; set; }

    [InverseProperty("MassChangeOperation")]
    public virtual ICollection<TMassChangeField> TMassChangeFields { get; set; } = new List<TMassChangeField>();
}
