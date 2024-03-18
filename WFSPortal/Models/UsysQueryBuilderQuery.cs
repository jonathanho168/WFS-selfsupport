using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysQueryBuilderQuery")]
public partial class UsysQueryBuilderQuery
{
    [Key]
    [Column("SysQueryBuilderQueryGUID")]
    public Guid SysQueryBuilderQueryGuid { get; set; }

    [StringLength(80)]
    public string QueryName { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string? QueryMetadata { get; set; }

    public int RowVersion { get; set; }

    [StringLength(80)]
    public string? QueryDescription { get; set; }

    [Column("CreatedByUserGUID")]
    public Guid? CreatedByUserGuid { get; set; }

    [StringLength(30)]
    public string? ViewName { get; set; }

    public bool SharedFlag { get; set; }

    [StringLength(80)]
    public string? RowSecurityRuleName { get; set; }

    public bool ContainsPayDataFlag { get; set; }

    [ForeignKey("RowSecurityRuleName")]
    [InverseProperty("UsysQueryBuilderQueries")]
    public virtual UsysRowSecurityRule? RowSecurityRuleNameNavigation { get; set; }
}
