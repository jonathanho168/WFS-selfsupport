using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCSF")]
[Index("Csfguid", Name = "RG_USysCSF", IsUnique = true)]
public partial class UsysCsf
{
    [Key]
    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    [Column("CSFDescription")]
    [StringLength(80)]
    public string Csfdescription { get; set; } = null!;

    [Column("CSFGUID")]
    public Guid Csfguid { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("DefaultCSFFlag")]
    public bool DefaultCsfflag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<TLeaveType> TLeaveTypes { get; set; } = new List<TLeaveType>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<TWorkEligibilityDocumentType> TWorkEligibilityDocumentTypes { get; set; } = new List<TWorkEligibilityDocumentType>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<UsysCsfcountry> UsysCsfcountries { get; set; } = new List<UsysCsfcountry>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<UsysCsfentity> UsysCsfentities { get; set; } = new List<UsysCsfentity>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<UsysCsffield> UsysCsffields { get; set; } = new List<UsysCsffield>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<UsysCsflocation> UsysCsflocations { get; set; } = new List<UsysCsflocation>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<UsysCsfmoduleDefinition> UsysCsfmoduleDefinitions { get; set; } = new List<UsysCsfmoduleDefinition>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<UsysCsfstateProvince> UsysCsfstateProvinces { get; set; } = new List<UsysCsfstateProvince>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<UsysCsfuser> UsysCsfusers { get; set; } = new List<UsysCsfuser>();

    [InverseProperty("CsfcodeNavigation")]
    public virtual ICollection<UsysResource> UsysResources { get; set; } = new List<UsysResource>();
}
