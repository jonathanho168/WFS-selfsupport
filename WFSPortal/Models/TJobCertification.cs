using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobCertification")]
[Index("JobCode", "CertificationCode", "PositionCode", Name = "AK_tJobCertification", IsUnique = true)]
[Index("CertificationCode", Name = "IX_tJobCertification_CertificationCode")]
public partial class TJobCertification
{
    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string CertificationCode { get; set; } = null!;

    public string? Comments { get; set; }

    public bool InactiveFlag { get; set; }

    [Key]
    [Column("JobCertificationGUID")]
    public Guid JobCertificationGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public int? MonthsToComplete { get; set; }

    [ForeignKey("CertificationCode")]
    [InverseProperty("TJobCertifications")]
    public virtual TCertification CertificationCodeNavigation { get; set; } = null!;

    [ForeignKey("JobCode")]
    [InverseProperty("TJobCertifications")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TJobCertifications")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;
}
