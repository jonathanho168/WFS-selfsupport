using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tHealthAndSafetyChecklistQuestion")]
[Index("HealthAndSafetyChecklistQuestionGuid", Name = "RG_tHealthAndSafetyChecklistQuestion", IsUnique = true)]
public partial class THealthAndSafetyChecklistQuestion
{
    [Key]
    [StringLength(15)]
    public string HealthAndSafetyChecklistQuestionCode { get; set; } = null!;

    public string? HealthAndSafetyChecklistQuestionDescription { get; set; }

    [StringLength(15)]
    public string HealthAndSafetyChecklistQuestionCategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string HealthAndSafetyChecklistQuestionSubCategoryCode { get; set; } = null!;

    public int? SortOrder { get; set; }

    public bool IsProcedureFlag { get; set; }

    [Column("IsOHSDocumentationFlag")]
    public bool IsOhsdocumentationFlag { get; set; }

    [Column("HealthAndSafetyChecklistQuestionGUID")]
    public Guid HealthAndSafetyChecklistQuestionGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("HealthAndSafetyChecklistQuestionCategoryCode")]
    [InverseProperty("THealthAndSafetyChecklistQuestionHealthAndSafetyChecklistQuestionCategoryCodeNavigations")]
    public virtual THealthAndSafetyChecklistQuestionCategory HealthAndSafetyChecklistQuestionCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("HealthAndSafetyChecklistQuestionSubCategoryCode")]
    [InverseProperty("THealthAndSafetyChecklistQuestionHealthAndSafetyChecklistQuestionSubCategoryCodeNavigations")]
    public virtual THealthAndSafetyChecklistQuestionCategory HealthAndSafetyChecklistQuestionSubCategoryCodeNavigation { get; set; } = null!;

    [InverseProperty("HealthAndSafetyChecklistQuestionCodeNavigation")]
    public virtual ICollection<THealthAndSafetyChecklistDetail> THealthAndSafetyChecklistDetails { get; set; } = new List<THealthAndSafetyChecklistDetail>();
}
