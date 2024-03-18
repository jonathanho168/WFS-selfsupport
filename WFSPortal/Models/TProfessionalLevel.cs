using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tProfessionalLevel")]
[Index("ProfessionalLevelGuid", Name = "RG_tProfessionalLevel", IsUnique = true)]
public partial class TProfessionalLevel
{
    [Key]
    [StringLength(15)]
    public string ProfessionalLevelCode { get; set; } = null!;

    [Column("ProfessionalLevelGUID")]
    public Guid ProfessionalLevelGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? ProfessionalLevelDescription { get; set; }

    [InverseProperty("ProfessionalLevelCodeNavigation")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHists { get; set; } = new List<TPersonEmploymentHist>();
}
