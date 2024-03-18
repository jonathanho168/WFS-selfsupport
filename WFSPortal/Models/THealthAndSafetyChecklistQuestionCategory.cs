using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tHealthAndSafetyChecklistQuestionCategory")]
[Index("HealthAndSafetyChecklistQuestionCategoryGuid", Name = "RG_tHealthAndSafetyChecklistQuestionCategory", IsUnique = true)]
public partial class THealthAndSafetyChecklistQuestionCategory
{
    [Key]
    [StringLength(15)]
    public string HealthAndSafetyChecklistQuestionCategoryCode { get; set; } = null!;

    public string? HealthAndSafetyChecklistQuestionCategoryDescription { get; set; }

    [Column("HealthAndSafetyChecklistQuestionCategoryGUID")]
    public Guid HealthAndSafetyChecklistQuestionCategoryGuid { get; set; }

    public int? SortOrder { get; set; }

    public bool? InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("HealthAndSafetyChecklistQuestionCategoryCodeNavigation")]
    public virtual ICollection<THealthAndSafetyChecklistQuestion> THealthAndSafetyChecklistQuestionHealthAndSafetyChecklistQuestionCategoryCodeNavigations { get; set; } = new List<THealthAndSafetyChecklistQuestion>();

    [InverseProperty("HealthAndSafetyChecklistQuestionSubCategoryCodeNavigation")]
    public virtual ICollection<THealthAndSafetyChecklistQuestion> THealthAndSafetyChecklistQuestionHealthAndSafetyChecklistQuestionSubCategoryCodeNavigations { get; set; } = new List<THealthAndSafetyChecklistQuestion>();
}
