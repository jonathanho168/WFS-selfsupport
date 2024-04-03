using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tGoalType")]
[Index("GoalTypeGuid", Name = "RG_tGoalType", IsUnique = true)]
public partial class TGoalType
{
    [Key]
    [StringLength(15)]
    public string GoalTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("GoalTypeGUID")]
    public Guid GoalTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public string? GoalTypeDescription { get; set; }

    [InverseProperty("GoalTypeCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("GoalTypeCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();
}
