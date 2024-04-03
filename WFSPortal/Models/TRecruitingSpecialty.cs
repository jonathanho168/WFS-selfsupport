using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRecruitingSpecialty")]
[Index("RecruitingSpecialtyGuid", Name = "RG_tRecruitingSpecialty", IsUnique = true)]
public partial class TRecruitingSpecialty
{
    [Key]
    [StringLength(15)]
    public string RecruitingSpecialtyCode { get; set; } = null!;

    [Column("RecruitingSpecialtyGUID")]
    public Guid RecruitingSpecialtyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? RecruitingSpecialtyDescription { get; set; }

    [InverseProperty("RecruitingSpecialtyCodeNavigation")]
    public virtual ICollection<TRecruitingFirm> TRecruitingFirms { get; set; } = new List<TRecruitingFirm>();
}
