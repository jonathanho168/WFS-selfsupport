using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tFunctionalArea")]
[Index("FunctionalAreaGuid", Name = "RG_tFunctionalArea", IsUnique = true)]
public partial class TFunctionalArea
{
    [Key]
    [StringLength(15)]
    public string FunctionalAreaCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("FunctionalAreaGUID")]
    public Guid FunctionalAreaGuid { get; set; }

    public int RowVersion { get; set; }

    public string? FunctionalAreaDescription { get; set; }

    [InverseProperty("FunctionalAreaCodeNavigation")]
    public virtual ICollection<TCompetency> TCompetencies { get; set; } = new List<TCompetency>();

    [InverseProperty("FunctionalAreaCodeNavigation")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHists { get; set; } = new List<TPersonEmploymentHist>();

    [InverseProperty("FunctionalAreaCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("FunctionalAreaCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("FunctionalAreaCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
