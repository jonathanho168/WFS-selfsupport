using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonLeaveRequestEligibilityFile")]
public partial class TPersonLeaveRequestEligibilityFile
{
    [Key]
    [Column("PersonLeaveRequestEligibilityFileGUID")]
    public Guid PersonLeaveRequestEligibilityFileGuid { get; set; }

    [Column("PersonLeaveRequestEligibilityGUID")]
    public Guid PersonLeaveRequestEligibilityGuid { get; set; }

    [StringLength(15)]
    public string FileAttachmentTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string? PersonLeaveRequestEligibilityFileDescription { get; set; }

    public byte[]? PersonLeaveRequestEligibilityFile { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PersonLeaveRequestEligibilityFileExtension { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("FileAttachmentTypeCode")]
    [InverseProperty("TPersonLeaveRequestEligibilityFiles")]
    public virtual TFileAttachmentType FileAttachmentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonLeaveRequestEligibilityGuid")]
    [InverseProperty("TPersonLeaveRequestEligibilityFiles")]
    public virtual TPersonLeaveRequestEligibility PersonLeaveRequestEligibility { get; set; } = null!;
}
