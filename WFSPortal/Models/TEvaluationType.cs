using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEvaluationType")]
[Index("EvaluationTypeGuid", Name = "RG_tEvaluationType", IsUnique = true)]
public partial class TEvaluationType
{
    [Key]
    [StringLength(15)]
    public string EvaluationTypeCode { get; set; } = null!;

    [Column("EvaluationTypeGUID")]
    public Guid EvaluationTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool InterviewedFlag { get; set; }

    public bool PhoneInterviewedFlag { get; set; }

    public string? EvaluationTypeDescription { get; set; }

    [InverseProperty("EvaluationTypeCodeNavigation")]
    public virtual ICollection<TPersonApplicationEvaluation> TPersonApplicationEvaluations { get; set; } = new List<TPersonApplicationEvaluation>();
}
