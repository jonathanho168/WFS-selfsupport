using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonCertification")]
[Index("PersonGuid", "CertificationCode", "AchievedDate", Name = "AK_tPersonCertification", IsUnique = true)]
[Index("CertificationCode", Name = "IX_tPersonCertification_CertificationCode")]
public partial class TPersonCertification
{
    [Key]
    [Column("PersonCertificationGUID")]
    public Guid PersonCertificationGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string CertificationCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AchievedDate { get; set; }

    public string? CertificationComments { get; set; }

    [StringLength(50)]
    public string? CertificationLevel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [StringLength(50)]
    public string? IssuedBy { get; set; }

    [StringLength(30)]
    public string? CertificationNumber { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Column("PersonGoalGUID")]
    public Guid? PersonGoalGuid { get; set; }

    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [ForeignKey("CertificationCode")]
    [InverseProperty("TPersonCertifications")]
    public virtual TCertification CertificationCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonCertifications")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonGoalGuid")]
    [InverseProperty("TPersonCertifications")]
    public virtual TPersonGoal? PersonGoal { get; set; }

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TPersonCertifications")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;
}
