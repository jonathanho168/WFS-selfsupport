using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysNavigator")]
[Index("SysTabGuid", "SortOrder", Name = "IX_USysNavigator_SysTabGuidSortOrder")]
public partial class UsysNavigator
{
    [Key]
    public Guid SysNavigatorGuid { get; set; }

    [StringLength(60)]
    public string? DisplayText { get; set; }

    public Guid? ParentGuid { get; set; }

    public int SortOrder { get; set; }

    [StringLength(50)]
    public string? EntityName { get; set; }

    public Guid? SysTabGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(100)]
    public string? PersonSpecificDisplayText { get; set; }

    [StringLength(255)]
    public string? Url { get; set; }

    public bool OpenUrlInNewWindow { get; set; }

    [StringLength(255)]
    public string? UrlWindowFeatures { get; set; }

    [StringLength(50)]
    public string? MenuIconCls { get; set; }

    [StringLength(60)]
    public string? MobileView { get; set; }

    public string? HoverText { get; set; }

    [ForeignKey("EntityName")]
    [InverseProperty("UsysNavigators")]
    public virtual UsysEntity? EntityNameNavigation { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<UsysNavigator> InverseParent { get; set; } = new List<UsysNavigator>();

    [ForeignKey("ParentGuid")]
    [InverseProperty("InverseParent")]
    public virtual UsysNavigator? Parent { get; set; }

    [ForeignKey("SysTabGuid")]
    [InverseProperty("UsysNavigators")]
    public virtual UsysTab? SysTab { get; set; }
}
