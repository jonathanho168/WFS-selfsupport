using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysMassChangeSQL")]
[Index("InsertedDateTime", Name = "IX_USysMassChangeSQL_InsertedDateTime")]
[Index("MassChangeInstanceGuid", "RecordGuid", Name = "IX_USysMassChangeSQL_MassChangeInstanceGUID_RecordGUID", IsUnique = true)]
public partial class UsysMassChangeSql
{
    [Column("MassChangeInstanceGUID")]
    public Guid MassChangeInstanceGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("RecordGUID")]
    public Guid RecordGuid { get; set; }

    [Column("HistoryRecordGUID")]
    public Guid? HistoryRecordGuid { get; set; }

    public bool ProcessFlag { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime InsertedDateTime { get; set; }

    [Key]
    [Column("MassChangeSQLGUID")]
    public Guid MassChangeSqlguid { get; set; }

    [Column("SQL", TypeName = "ntext")]
    public string? Sql { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("MassChangeInstanceGuid")]
    [InverseProperty("UsysMassChangeSqls")]
    public virtual TMassChange MassChangeInstance { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysMassChangeSqls")]
    public virtual TPerson Person { get; set; } = null!;
}
