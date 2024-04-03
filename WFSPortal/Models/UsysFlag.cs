using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysFlag")]
public partial class UsysFlag
{
    [Key]
    [Column("FlagGUID")]
    public Guid FlagGuid { get; set; }

    [StringLength(80)]
    public string FlagName { get; set; } = null!;

    [StringLength(80)]
    public string FlagDescription { get; set; } = null!;

    public int LicenseFlags { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("Flag")]
    public virtual ICollection<UsysRoleFlag> UsysRoleFlags { get; set; } = new List<UsysRoleFlag>();
}
