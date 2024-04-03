using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPublishedWorkType")]
[Index("PublishedWorkTypeGuid", Name = "RG_tPublishedWorkType", IsUnique = true)]
public partial class TPublishedWorkType
{
    [Key]
    [StringLength(15)]
    public string PublishedWorkTypeCode { get; set; } = null!;

    [Column("PublishedWorkTypeGUID")]
    public Guid PublishedWorkTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PublishedWorkTypeDescription { get; set; }

    [InverseProperty("PublishedWorkTypeCodeNavigation")]
    public virtual ICollection<TPersonPublishedWork> TPersonPublishedWorks { get; set; } = new List<TPersonPublishedWork>();
}
