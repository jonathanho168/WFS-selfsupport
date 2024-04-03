using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonApplicationAnswer")]
public partial class TPersonApplicationAnswer
{
    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    [StringLength(255)]
    public string? QuestionText { get; set; }

    public string? TextAnswer { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? NumericAnswer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateAnswer { get; set; }

    [StringLength(255)]
    public string? ExplainPrompt { get; set; }

    public string? Explanation { get; set; }

    public int Validation { get; set; }

    public int RowVersion { get; set; }

    [Key]
    public Guid PersonApplicationAnswerGuid { get; set; }

    [StringLength(15)]
    public string ApplicationQuestionCode { get; set; } = null!;

    public bool KnockoutQuestionFlag { get; set; }

    public bool KnockoutAnswerFlag { get; set; }

    [ForeignKey("ApplicationQuestionCode")]
    [InverseProperty("TPersonApplicationAnswers")]
    public virtual TApplicationQuestion ApplicationQuestionCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonApplicationGuid")]
    [InverseProperty("TPersonApplicationAnswers")]
    public virtual TPersonApplication PersonApplication { get; set; } = null!;
}
