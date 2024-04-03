using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOrganizationUnit")]
[Index("OrganizationUnitGuid", Name = "RG_tOrganizationUnit", IsUnique = true)]
public partial class TOrganizationUnit
{
    [Key]
    [StringLength(15)]
    public string OrganizationUnitCode { get; set; } = null!;

    [StringLength(15)]
    public string OrganizationUnitLevelCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("OrganizationUnitGUID")]
    public Guid OrganizationUnitGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string ParentOrganizationUnitCode { get; set; } = null!;

    public string? OrganizationUnitDescription { get; set; }

    [InverseProperty("ParentOrganizationUnitCodeNavigation")]
    public virtual ICollection<TOrganizationUnit> InverseParentOrganizationUnitCodeNavigation { get; set; } = new List<TOrganizationUnit>();

    [ForeignKey("OrganizationUnitLevelCode")]
    [InverseProperty("TOrganizationUnits")]
    public virtual TOrganizationUnitLevel OrganizationUnitLevelCodeNavigation { get; set; } = null!;

    [ForeignKey("ParentOrganizationUnitCode")]
    [InverseProperty("InverseParentOrganizationUnitCodeNavigation")]
    public virtual TOrganizationUnit ParentOrganizationUnitCodeNavigation { get; set; } = null!;

    [InverseProperty("OrganizationUnitCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("OrganizationUnitCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("OrganizationUnitCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
