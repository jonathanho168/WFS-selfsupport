using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRecipientType")]
[Index("RecipientTypeGuid", Name = "RG_USysRecipientType", IsUnique = true)]
public partial class UsysRecipientType
{
    [Key]
    [StringLength(15)]
    public string RecipientTypeCode { get; set; } = null!;

    [Column("RecipientTypeGUID")]
    public Guid RecipientTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? RecipientTypeDescription { get; set; }

    [InverseProperty("RecipientTypeCodeNavigation")]
    public virtual ICollection<UsysRoutingStep> UsysRoutingSteps { get; set; } = new List<UsysRoutingStep>();
}
