using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonNominationQuestion")]
public partial class TPersonNominationQuestion
{
    [Key]
    [Column("PersonNominationQuestionGUID")]
    public Guid PersonNominationQuestionGuid { get; set; }

    [Column("PersonNominationGUID")]
    public Guid PersonNominationGuid { get; set; }

    public string? NominationQuestion { get; set; }

    [StringLength(4000)]
    public string? NominationQuestionResponse { get; set; }

    [StringLength(15)]
    public string NominationQuestionSectionCode { get; set; } = null!;

    public int QuestionSortOrder { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("NominationQuestionSectionCode")]
    [InverseProperty("TPersonNominationQuestions")]
    public virtual TNominationQuestionSection NominationQuestionSectionCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonNominationGuid")]
    [InverseProperty("TPersonNominationQuestions")]
    public virtual TPersonNomination PersonNomination { get; set; } = null!;
}
