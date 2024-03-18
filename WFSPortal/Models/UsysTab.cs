using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysTab")]
public partial class UsysTab
{
    [Key]
    public Guid SysTabGuid { get; set; }

    [StringLength(50)]
    public string? DisplayText { get; set; }

    [StringLength(50)]
    public string? TabGroup { get; set; }

    public int SortOrder { get; set; }

    public int? LicenseFlags { get; set; }

    public bool AllowAnonymous { get; set; }

    public int RowVersion { get; set; }

    [Column("PortalGUID")]
    public Guid? PortalGuid { get; set; }

    public bool ChecklistFlag { get; set; }

    [StringLength(50)]
    public string? TabIconCls { get; set; }

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysTabs")]
    public virtual UsysPortal? Portal { get; set; }

    [InverseProperty("ChecklistTab")]
    public virtual ICollection<UsysChecklist> UsysChecklists { get; set; } = new List<UsysChecklist>();

    [InverseProperty("SysTab")]
    public virtual ICollection<UsysModule> UsysModules { get; set; } = new List<UsysModule>();

    [InverseProperty("SysTab")]
    public virtual ICollection<UsysNavigator> UsysNavigators { get; set; } = new List<UsysNavigator>();
}
