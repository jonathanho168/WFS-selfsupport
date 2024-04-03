using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tFileAttachmentType")]
[Index("FileAttachmentTypeGuid", Name = "RG_tFileAttachmentType", IsUnique = true)]
public partial class TFileAttachmentType
{
    [Key]
    [StringLength(15)]
    public string FileAttachmentTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("FileAttachmentTypeGUID")]
    public Guid FileAttachmentTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public string? FileAttachmentTypeDescription { get; set; }

    public bool ConfidentialFlag { get; set; }

    [InverseProperty("FileAttachmentTypeCodeNavigation")]
    public virtual ICollection<TPersonApplicationFile> TPersonApplicationFiles { get; set; } = new List<TPersonApplicationFile>();

    [InverseProperty("FileAttachmentTypeCodeNavigation")]
    public virtual ICollection<TPersonFile> TPersonFiles { get; set; } = new List<TPersonFile>();

    [InverseProperty("FileAttachmentTypeCodeNavigation")]
    public virtual ICollection<TPersonLeaveRequestDesignationFile> TPersonLeaveRequestDesignationFiles { get; set; } = new List<TPersonLeaveRequestDesignationFile>();

    [InverseProperty("FileAttachmentTypeCodeNavigation")]
    public virtual ICollection<TPersonLeaveRequestEligibilityFile> TPersonLeaveRequestEligibilityFiles { get; set; } = new List<TPersonLeaveRequestEligibilityFile>();
}
