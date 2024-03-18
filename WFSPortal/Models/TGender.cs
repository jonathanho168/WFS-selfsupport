using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tGender")]
[Index("GenderGuid", Name = "RG_tGender", IsUnique = true)]
public partial class TGender
{
    [Key]
    [StringLength(15)]
    public string GenderCode { get; set; } = null!;

    [StringLength(15)]
    public string? ReportValue { get; set; }

    [Column("GenderGUID")]
    public Guid GenderGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? GenderDescription { get; set; }

    [InverseProperty("GenderCodeNavigation")]
    public virtual ICollection<TPersonal> TPersonals { get; set; } = new List<TPersonal>();
}
