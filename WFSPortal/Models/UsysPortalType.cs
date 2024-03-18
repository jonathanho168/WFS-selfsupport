using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysPortalType")]
public partial class UsysPortalType
{
    [Column("PortalTypeGUID")]
    public Guid PortalTypeGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string PortalTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string PortalTypeDescription { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("PortalTypeCodeNavigation")]
    public virtual ICollection<UsysPortal> UsysPortals { get; set; } = new List<UsysPortal>();
}
