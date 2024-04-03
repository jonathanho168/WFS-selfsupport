using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonFile")]
public partial class TPersonFile
{
    [Key]
    [Column("PersonFileGUID")]
    public Guid PersonFileGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string FileAttachmentTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string? PersonFileDescription { get; set; }

    public byte[]? PersonFileAttachment { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "ntext")]
    public string? PersonFileText { get; set; }

    [ForeignKey("FileAttachmentTypeCode")]
    [InverseProperty("TPersonFiles")]
    public virtual TFileAttachmentType FileAttachmentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonFiles")]
    public virtual TPerson Person { get; set; } = null!;

    [InverseProperty("PersonFile")]
    public virtual ICollection<TPersonApplicationFile> TPersonApplicationFiles { get; set; } = new List<TPersonApplicationFile>();
}
