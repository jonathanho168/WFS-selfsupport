using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDependent834Type")]
[Index("Dependent834TypeGuid", Name = "RG_tDependent834Type", IsUnique = true)]
public partial class TDependent834Type
{
    [Key]
    [StringLength(15)]
    public string Dependent834TypeCode { get; set; } = null!;

    public string? Dependent834TypeDescription { get; set; }

    [Column("Dependent834TypeGUID")]
    public Guid Dependent834TypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("Dependent834TypeCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHists { get; set; } = new List<TBenefitHist>();
}
