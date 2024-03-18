using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPrimaryPolicy")]
public partial class TPrimaryPolicy
{
    [StringLength(15)]
    public string PrimaryPolicyCode { get; set; } = null!;

    [Key]
    [Column("PrimaryPolicyGUID")]
    public Guid PrimaryPolicyGuid { get; set; }

    [StringLength(80)]
    public string PrimaryPolicyDescription { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }
}
