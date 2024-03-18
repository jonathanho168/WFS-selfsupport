using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysResource")]
public partial class UsysResource
{
    [Key]
    [Column("ResourceGUID")]
    public Guid ResourceGuid { get; set; }

    [StringLength(200)]
    public string ResourceName { get; set; } = null!;

    [StringLength(15)]
    public string ResourceTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string LanguageCode { get; set; } = null!;

    [Column("PortalGUID")]
    public Guid? PortalGuid { get; set; }

    public string? Value { get; set; }

    public string? CustomValue { get; set; }

    public int RowVersion { get; set; }

    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    [ForeignKey("Csfcode")]
    [InverseProperty("UsysResources")]
    public virtual UsysCsf CsfcodeNavigation { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("UsysResources")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysResources")]
    public virtual UsysPortal? Portal { get; set; }

    [ForeignKey("ResourceTypeCode")]
    [InverseProperty("UsysResources")]
    public virtual UsysResourceType ResourceTypeCodeNavigation { get; set; } = null!;
}
