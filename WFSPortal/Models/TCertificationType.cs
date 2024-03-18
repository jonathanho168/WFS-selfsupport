using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCertificationType")]
[Index("CertificationTypeGuid", Name = "RG_tCertificationType", IsUnique = true)]
public partial class TCertificationType
{
    [Column("CertificationTypeGUID")]
    public Guid? CertificationTypeGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string CertificationTypeCode { get; set; } = null!;

    public string? CertificationTypeDescription { get; set; }

    public bool InactiveFlag { get; set; }

    public int? RowVersion { get; set; }

    [InverseProperty("CertificationTypeCodeNavigation")]
    public virtual ICollection<TCertification> TCertifications { get; set; } = new List<TCertification>();
}
