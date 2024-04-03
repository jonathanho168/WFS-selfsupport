using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonWorkEligibilityFile")]
public partial class TPersonWorkEligibilityFile
{
    [Key]
    [Column("PersonWorkEligibilityFileGUID")]
    public Guid PersonWorkEligibilityFileGuid { get; set; }

    [Column("PersonWorkEligibilityGUID")]
    public Guid PersonWorkEligibilityGuid { get; set; }

    [StringLength(15)]
    public string WorkEligibilityDocumentTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string? IssuingAuthority { get; set; }

    [StringLength(50)]
    public string? DocumentNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    public byte[]? PersonWorkEligibilityFile { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonWorkEligibilityGuid")]
    [InverseProperty("TPersonWorkEligibilityFiles")]
    public virtual TPersonWorkEligibility PersonWorkEligibility { get; set; } = null!;

    [ForeignKey("WorkEligibilityDocumentTypeCode")]
    [InverseProperty("TPersonWorkEligibilityFiles")]
    public virtual TWorkEligibilityDocumentType WorkEligibilityDocumentTypeCodeNavigation { get; set; } = null!;
}
