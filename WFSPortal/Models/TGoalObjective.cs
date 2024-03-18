using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tGoalObjective")]
public partial class TGoalObjective
{
    [Key]
    [StringLength(15)]
    public string GoalObjectiveCode { get; set; } = null!;

    public string? GoalObjectiveDescription { get; set; }

    [Column("GoalObjectiveGUID")]
    public Guid GoalObjectiveGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("GoalObjectiveCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("GoalObjectiveCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();
}
