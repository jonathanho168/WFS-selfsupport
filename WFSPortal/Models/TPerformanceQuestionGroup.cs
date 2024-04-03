using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceQuestionGroup")]
[Index("PerformanceQuestionGroupGuid", Name = "RG_tPerformanceQuestionGroup", IsUnique = true)]
public partial class TPerformanceQuestionGroup
{
    [Key]
    [StringLength(15)]
    public string PerformanceQuestionGroupCode { get; set; } = null!;

    public int SortOrder { get; set; }

    [Column("PerformanceQuestionGroupGUID")]
    public Guid PerformanceQuestionGroupGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PerformanceQuestionGroupDescription { get; set; }

    [InverseProperty("PerformanceQuestionGroupCodeNavigation")]
    public virtual ICollection<TPerformanceQuestion> TPerformanceQuestions { get; set; } = new List<TPerformanceQuestion>();

    [InverseProperty("PerformanceQuestionGroupCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();
}
