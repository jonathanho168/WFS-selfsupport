using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPhysicianType")]
[Index("PhysicianTypeGuid", Name = "RG_tPhysicianType", IsUnique = true)]
public partial class TPhysicianType
{
    [Key]
    [StringLength(15)]
    public string PhysicianTypeCode { get; set; } = null!;

    [Column("PhysicianTypeGUID")]
    public Guid PhysicianTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PhysicianTypeDescription { get; set; }

    [InverseProperty("PhysicianTypeCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHists { get; set; } = new List<TBenefitHist>();

    [InverseProperty("PhysicianTypeCodeNavigation")]
    public virtual ICollection<TPhysician> TPhysicians { get; set; } = new List<TPhysician>();
}
