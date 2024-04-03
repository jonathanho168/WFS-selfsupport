using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tNominationQuestion")]
public partial class TNominationQuestion
{
    [Key]
    [Column("NominationQuestionGUID")]
    public Guid NominationQuestionGuid { get; set; }

    public string? NominationQuestion { get; set; }

    public bool AskEmployeeFlag { get; set; }

    public bool AskManagerFlag { get; set; }

    [StringLength(15)]
    public string NominationQuestionSectionCode { get; set; } = null!;

    public int QuestionSortOrder { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("NominationQuestionSectionCode")]
    [InverseProperty("TNominationQuestions")]
    public virtual TNominationQuestionSection NominationQuestionSectionCodeNavigation { get; set; } = null!;
}
