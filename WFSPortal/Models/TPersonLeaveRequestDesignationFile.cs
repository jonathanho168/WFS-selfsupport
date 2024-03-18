using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonLeaveRequestDesignationFile")]
public partial class TPersonLeaveRequestDesignationFile
{
    [Key]
    [Column("PersonLeaveRequestDesignationFileGUID")]
    public Guid PersonLeaveRequestDesignationFileGuid { get; set; }

    [Column("PersonLeaveRequestDesignationGUID")]
    public Guid PersonLeaveRequestDesignationGuid { get; set; }

    [StringLength(15)]
    public string FileAttachmentTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string? PersonLeaveRequestDesignationFileDescription { get; set; }

    public byte[]? PersonLeaveRequestDesignationFile { get; set; }

    [StringLength(10)]
    public string? PersonLeaveRequestDesignationFileExtension { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("FileAttachmentTypeCode")]
    [InverseProperty("TPersonLeaveRequestDesignationFiles")]
    public virtual TFileAttachmentType FileAttachmentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonLeaveRequestDesignationGuid")]
    [InverseProperty("TPersonLeaveRequestDesignationFiles")]
    public virtual TPersonLeaveRequestDesignation PersonLeaveRequestDesignation { get; set; } = null!;
}
