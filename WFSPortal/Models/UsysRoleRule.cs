using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoleRules")]
public partial class UsysRoleRule
{
    [Key]
    [Column("SysRoleRulesGUID")]
    public Guid SysRoleRulesGuid { get; set; }

    [StringLength(80)]
    public string RowSecurityRuleName { get; set; } = null!;

    [Column("RoleGUID")]
    public Guid RoleGuid { get; set; }

    public int RowVersion { get; set; }

    public bool ViewPayFlag { get; set; }

    public bool CandidateDataFlag { get; set; }

    [ForeignKey("RoleGuid")]
    [InverseProperty("UsysRoleRules")]
    public virtual UsysRole Role { get; set; } = null!;

    [ForeignKey("RowSecurityRuleName")]
    [InverseProperty("UsysRoleRules")]
    public virtual UsysRowSecurityRule RowSecurityRuleNameNavigation { get; set; } = null!;
}
