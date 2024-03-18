using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tNameType")]
[Index("NameTypeGuid", Name = "RG_tNameType", IsUnique = true)]
public partial class TNameType
{
    [Key]
    [StringLength(15)]
    public string NameTypeCode { get; set; } = null!;

    [Column("NameTypeGUID")]
    public Guid NameTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? NameTypeDescription { get; set; }

    [InverseProperty("NameTypeCodeNavigation")]
    public virtual ICollection<TPersonOtherName> TPersonOtherNames { get; set; } = new List<TPersonOtherName>();
}
