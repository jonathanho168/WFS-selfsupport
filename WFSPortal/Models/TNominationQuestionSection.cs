using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tNominationQuestionSection")]
[Index("NominationQuestionSectionGuid", Name = "RG_tNominationQuestionSection", IsUnique = true)]
public partial class TNominationQuestionSection
{
    [Key]
    [StringLength(15)]
    public string NominationQuestionSectionCode { get; set; } = null!;

    [StringLength(80)]
    public string? SectionTitle { get; set; }

    public int SectionSortOrder { get; set; }

    public int ConnectSectionSortOrder { get; set; }

    [Column("NominationQuestionSectionGUID")]
    public Guid NominationQuestionSectionGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? NominationQuestionSectionDescription { get; set; }

    [InverseProperty("NominationQuestionSectionCodeNavigation")]
    public virtual ICollection<TNominationQuestion> TNominationQuestions { get; set; } = new List<TNominationQuestion>();

    [InverseProperty("NominationQuestionSectionCodeNavigation")]
    public virtual ICollection<TPersonNominationQuestion> TPersonNominationQuestions { get; set; } = new List<TPersonNominationQuestion>();
}
