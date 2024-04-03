using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysMassChangeError")]
[Index("InsertedDateTime", Name = "IX_USysMassChangeError_InsertedDateTime")]
public partial class UsysMassChangeError
{
    [Column("MassChangeInstanceGUID")]
    public Guid MassChangeInstanceGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("RecordGUID")]
    public Guid RecordGuid { get; set; }

    [Column("HistoryRecordGUID")]
    public Guid? HistoryRecordGuid { get; set; }

    [StringLength(1000)]
    public string? ErrorDescription { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime InsertedDateTime { get; set; }

    [Key]
    [Column("MassChangeErrorGUID")]
    public Guid MassChangeErrorGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("MassChangeInstanceGuid")]
    [InverseProperty("UsysMassChangeErrors")]
    public virtual TMassChange MassChangeInstance { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysMassChangeErrors")]
    public virtual TPerson Person { get; set; } = null!;
}
