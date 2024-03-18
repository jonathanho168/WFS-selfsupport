using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tApplicationQuestion")]
[Index("ApplicationQuestionGuid", Name = "RG_tApplicationQuestion", IsUnique = true)]
public partial class TApplicationQuestion
{
    [Key]
    [StringLength(15)]
    public string ApplicationQuestionCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string ApplicationAnswerTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public Guid? ApplicationQuestionGuid { get; set; }

    public bool RequiredForCandidatesFlag { get; set; }

    public bool RequiredForEmployeesFlag { get; set; }

    public bool HideFromCandidatesFlag { get; set; }

    public bool HideFromEmployeesFlag { get; set; }

    public bool HideFromManagersFlag { get; set; }

    public string? ApplicationQuestionText { get; set; }

    [ForeignKey("ApplicationAnswerTypeCode")]
    [InverseProperty("TApplicationQuestions")]
    public virtual TApplicationAnswerType ApplicationAnswerTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("ApplicationQuestionCodeNavigation")]
    public virtual ICollection<TPersonApplicationAnswer> TPersonApplicationAnswers { get; set; } = new List<TPersonApplicationAnswer>();
}
