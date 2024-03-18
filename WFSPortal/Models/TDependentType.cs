using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDependentType")]
[Index("DependentTypeGuid", Name = "RG_tDependentType", IsUnique = true)]
public partial class TDependentType
{
    [Key]
    [StringLength(15)]
    public string DependentTypeCode { get; set; } = null!;

    [Column("DependentTypeGUID")]
    public Guid DependentTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DependentTypeDescription { get; set; }

    [InverseProperty("DependentTypeCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHists { get; set; } = new List<TBenefitHist>();

    [InverseProperty("DependentTypeCodeNavigation")]
    public virtual ICollection<TDependentTypeRelationship> TDependentTypeRelationships { get; set; } = new List<TDependentTypeRelationship>();
}
