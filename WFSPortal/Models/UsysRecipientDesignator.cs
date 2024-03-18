using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRecipientDesignator")]
[Index("RecipientDesignatorGuid", Name = "RG_USysRecipientDesignator", IsUnique = true)]
public partial class UsysRecipientDesignator
{
    [Key]
    [StringLength(15)]
    public string RecipientDesignatorCode { get; set; } = null!;

    [Column("RecipientDesignatorGUID")]
    public Guid RecipientDesignatorGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? RecipientDesignatorDescription { get; set; }

    [InverseProperty("RecipientDesignatorCodeNavigation")]
    public virtual ICollection<UsysRecipient> UsysRecipients { get; set; } = new List<UsysRecipient>();
}
