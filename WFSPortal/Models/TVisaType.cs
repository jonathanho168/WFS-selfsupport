using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tVisaType")]
[Index("VisaTypeGuid", Name = "RG_tVisaType", IsUnique = true)]
public partial class TVisaType
{
    [Key]
    [StringLength(15)]
    public string VisaTypeCode { get; set; } = null!;

    [Column("VisaTypeGUID")]
    public Guid VisaTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? VisaTypeDescription { get; set; }

    [InverseProperty("VisaTypeCodeNavigation")]
    public virtual ICollection<TPersonVisa> TPersonVisas { get; set; } = new List<TPersonVisa>();
}
