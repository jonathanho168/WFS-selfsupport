using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysMobileComponent")]
public partial class UsysMobileComponent
{
    [Key]
    [Column("MobileComponentGUID")]
    public Guid MobileComponentGuid { get; set; }

    [StringLength(128)]
    public string? ComponentName { get; set; }

    [StringLength(128)]
    public string? PageName { get; set; }

    [StringLength(128)]
    public string? FieldName { get; set; }

    public bool HiddenFlag { get; set; }

    public int RowVersion { get; set; }
}
