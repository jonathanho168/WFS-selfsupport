using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tWorkEligibilityDocumentType")]
[Index("WorkEligibilityDocumentTypeGuid", Name = "RG_tWorkEligibilityDocumentType", IsUnique = true)]
public partial class TWorkEligibilityDocumentType
{
    [Key]
    [StringLength(15)]
    public string WorkEligibilityDocumentTypeCode { get; set; } = null!;

    [Column("WorkEligibilityDocumentTypeGUID")]
    public Guid WorkEligibilityDocumentTypeGuid { get; set; }

    public string? WorkEligibilityDocumentTypeDescription { get; set; }

    [StringLength(15)]
    public string? WorkEligibilityDocumentColumn { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("CSFCode")]
    [StringLength(15)]
    public string? Csfcode { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("Csfcode")]
    [InverseProperty("TWorkEligibilityDocumentTypes")]
    public virtual UsysCsf? CsfcodeNavigation { get; set; }

    [InverseProperty("WorkEligibilityDocumentTypeCodeNavigation")]
    public virtual ICollection<TPersonWorkEligibilityFile> TPersonWorkEligibilityFiles { get; set; } = new List<TPersonWorkEligibilityFile>();
}
