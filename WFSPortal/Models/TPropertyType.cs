using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPropertyType")]
[Index("PropertyTypeGuid", Name = "RG_tPropertyType", IsUnique = true)]
public partial class TPropertyType
{
    [Key]
    [StringLength(15)]
    public string PropertyTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("PropertyTypeGUID")]
    public Guid PropertyTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public string? PropertyTypeDescription { get; set; }

    [InverseProperty("PropertyTypeCodeNavigation")]
    public virtual ICollection<TProperty> TProperties { get; set; } = new List<TProperty>();
}
