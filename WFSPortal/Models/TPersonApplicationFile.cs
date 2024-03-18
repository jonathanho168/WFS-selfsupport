using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonApplicationFile")]
public partial class TPersonApplicationFile
{
    [Key]
    [Column("PersonApplicationFileGUID")]
    public Guid PersonApplicationFileGuid { get; set; }

    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    [StringLength(15)]
    public string FileAttachmentTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string? PersonApplicationFileDescription { get; set; }

    public byte[]? PersonApplicationFile { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Column(TypeName = "ntext")]
    public string? PersonApplicationFileText { get; set; }

    [Column("PersonFileGUID")]
    public Guid? PersonFileGuid { get; set; }

    [ForeignKey("FileAttachmentTypeCode")]
    [InverseProperty("TPersonApplicationFiles")]
    public virtual TFileAttachmentType FileAttachmentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonApplicationGuid")]
    [InverseProperty("TPersonApplicationFiles")]
    public virtual TPersonApplication PersonApplication { get; set; } = null!;

    [ForeignKey("PersonFileGuid")]
    [InverseProperty("TPersonApplicationFiles")]
    public virtual TPersonFile? PersonFile { get; set; }
}
