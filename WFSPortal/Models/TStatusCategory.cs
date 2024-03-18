using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tStatusCategory")]
[Index("StatusCategoryGuid", Name = "RG_tStatusCategory", IsUnique = true)]
public partial class TStatusCategory
{
    [Key]
    [StringLength(15)]
    public string StatusCategoryCode { get; set; } = null!;

    [Column("StatusCategoryGUID")]
    public Guid StatusCategoryGuid { get; set; }

    public bool FullTimeFlag { get; set; }

    public bool PermanentFlag { get; set; }

    public bool TerminationFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? StatusCategoryDescription { get; set; }

    [InverseProperty("StatusCategoryCodeNavigation")]
    public virtual ICollection<TPersonStatusHist> TPersonStatusHists { get; set; } = new List<TPersonStatusHist>();

    [InverseProperty("StatusCategoryCodeNavigation")]
    public virtual ICollection<TRequisition> TRequisitions { get; set; } = new List<TRequisition>();
}
