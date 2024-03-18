using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEvaluationResult")]
[Index("EvaluationResultGuid", Name = "RG_tEvaluationResult", IsUnique = true)]
public partial class TEvaluationResult
{
    [Key]
    [StringLength(15)]
    public string EvaluationResultCode { get; set; } = null!;

    [Column("EvaluationResultGUID")]
    public Guid? EvaluationResultGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? EvaluationResultDescription { get; set; }

    [InverseProperty("EvaluationResultCodeNavigation")]
    public virtual ICollection<TPersonApplicationEvaluation> TPersonApplicationEvaluations { get; set; } = new List<TPersonApplicationEvaluation>();
}
