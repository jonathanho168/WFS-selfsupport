using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDependentTypeRelationship")]
public partial class TDependentTypeRelationship
{
    [Key]
    [Column("DependentTypeRelationshipGUID")]
    public Guid DependentTypeRelationshipGuid { get; set; }

    [StringLength(15)]
    public string DependentTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string RelationshipCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("DependentTypeCode")]
    [InverseProperty("TDependentTypeRelationships")]
    public virtual TDependentType DependentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("RelationshipCode")]
    [InverseProperty("TDependentTypeRelationships")]
    public virtual TRelationship RelationshipCodeNavigation { get; set; } = null!;
}
