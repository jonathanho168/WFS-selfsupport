using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitGroup")]
[Index("BenefitGroupGuid", Name = "RG_tBenefitGroup", IsUnique = true)]
public partial class TBenefitGroup
{
    [Key]
    [StringLength(15)]
    public string BenefitGroupCode { get; set; } = null!;

    [Column("BenefitGroupGUID")]
    public Guid BenefitGroupGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? BenefitGroupDescription { get; set; }

    [InverseProperty("BenefitGroupCodeNavigation")]
    public virtual ICollection<TPersonBenefitGroupHist> TPersonBenefitGroupHists { get; set; } = new List<TPersonBenefitGroupHist>();
}
