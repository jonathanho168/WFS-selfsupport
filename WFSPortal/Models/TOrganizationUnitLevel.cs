using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOrganizationUnitLevel")]
[Index("OrganizationUnitLevelGuid", Name = "RG_tOrganizationUnitLevel", IsUnique = true)]
public partial class TOrganizationUnitLevel
{
    [Key]
    [StringLength(15)]
    public string OrganizationUnitLevelCode { get; set; } = null!;

    [Column("OrganizationUnitLevelGUID")]
    public Guid OrganizationUnitLevelGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? OrganizationUnitLevelDescription { get; set; }

    [InverseProperty("OrganizationUnitLevelCodeNavigation")]
    public virtual ICollection<TOrganizationUnit> TOrganizationUnits { get; set; } = new List<TOrganizationUnit>();
}
