using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEvaluator")]
[Index("EvaluatorGuid", Name = "RG_tEvaluator", IsUnique = true)]
public partial class TEvaluator
{
    [Key]
    [StringLength(15)]
    public string EvaluatorCode { get; set; } = null!;

    [Column("EvaluatorGUID")]
    public Guid EvaluatorGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? EvaluatorDescription { get; set; }

    [InverseProperty("EvaluatorCodeNavigation")]
    public virtual ICollection<TPersonApplicationEvaluation> TPersonApplicationEvaluations { get; set; } = new List<TPersonApplicationEvaluation>();
}
