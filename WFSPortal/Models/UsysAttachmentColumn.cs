using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAttachmentColumn")]
[Index("TableName", "ColumnName", Name = "AK_USysAttachmentColumn", IsUnique = true)]
public partial class UsysAttachmentColumn
{
    [Key]
    [Column("AttachmentColumnGUID")]
    public Guid AttachmentColumnGuid { get; set; }

    public string? AttachmentColumnDescription { get; set; }

    [StringLength(128)]
    public string TableName { get; set; } = null!;

    [StringLength(128)]
    public string ColumnName { get; set; } = null!;

    [StringLength(128)]
    public string? PrimaryTableName { get; set; }

    [StringLength(128)]
    public string? PrimaryTableStartDateField { get; set; }

    [StringLength(128)]
    public string? PrimaryTableEndDateField { get; set; }

    [StringLength(50)]
    public string? EntityName { get; set; }

    public string? EntityDescription { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("EntityName")]
    [InverseProperty("UsysAttachmentColumns")]
    public virtual UsysEntity? EntityNameNavigation { get; set; }
}
