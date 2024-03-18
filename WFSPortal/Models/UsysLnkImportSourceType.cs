using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportSourceType")]
public partial class UsysLnkImportSourceType
{
    [Key]
    [StringLength(15)]
    public string ImportSourceTypeCode { get; set; } = null!;

    public string? ImportSourceTypeDescription { get; set; }

    [Column("LnkImportSourceTypeGUID")]
    public Guid LnkImportSourceTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("ImportSourceTypeCodeNavigation")]
    public virtual ICollection<UsysLnkImportSource> UsysLnkImportSources { get; set; } = new List<UsysLnkImportSource>();
}
