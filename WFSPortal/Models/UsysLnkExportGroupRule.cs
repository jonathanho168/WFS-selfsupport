using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportGroupRule")]
public partial class UsysLnkExportGroupRule
{
    [Key]
    public Guid LnkExportGroupRuleGuid { get; set; }

    public Guid LnkExportGroupGuid { get; set; }

    [StringLength(80)]
    public string RowSecurityRuleName { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("LnkExportGroupGuid")]
    [InverseProperty("UsysLnkExportGroupRules")]
    public virtual UsysLnkExportGroup LnkExportGroup { get; set; } = null!;

    [ForeignKey("RowSecurityRuleName")]
    [InverseProperty("UsysLnkExportGroupRules")]
    public virtual UsysRowSecurityRule RowSecurityRuleNameNavigation { get; set; } = null!;
}
