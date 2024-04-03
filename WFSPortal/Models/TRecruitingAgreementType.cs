using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRecruitingAgreementType")]
[Index("RecruitingAgreementTypeGuid", Name = "RG_tRecruitingAgreementType", IsUnique = true)]
public partial class TRecruitingAgreementType
{
    [Key]
    [StringLength(15)]
    public string RecruitingAgreementTypeCode { get; set; } = null!;

    [Column("RecruitingAgreementTypeGUID")]
    public Guid RecruitingAgreementTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? RecruitingAgreementTypeDescription { get; set; }

    [InverseProperty("RecruitingAgreementTypeCodeNavigation")]
    public virtual ICollection<TRecruitingAgreement> TRecruitingAgreements { get; set; } = new List<TRecruitingAgreement>();
}
