using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tHireSource")]
[Index("HireSourceGuid", Name = "RG_tHireSource", IsUnique = true)]
public partial class THireSource
{
    [Key]
    [StringLength(15)]
    public string HireSourceCode { get; set; } = null!;

    [Column("HireSourceGUID")]
    public Guid HireSourceGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? HireSourceDescription { get; set; }

    [InverseProperty("HireSourceCodeNavigation")]
    public virtual ICollection<TPersonStatusHist> TPersonStatusHists { get; set; } = new List<TPersonStatusHist>();
}
