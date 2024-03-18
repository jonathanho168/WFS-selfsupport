using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonNominationQuestionSection")]
public partial class TPersonNominationQuestionSection
{
    [Key]
    [Column("PersonNominationQuestionSectionGUID")]
    public Guid PersonNominationQuestionSectionGuid { get; set; }

    [Column("PersonNominationGUID")]
    public Guid PersonNominationGuid { get; set; }

    [StringLength(15)]
    public string NominationQuestionSectionCode { get; set; } = null!;

    [StringLength(80)]
    public string SectionTitle { get; set; } = null!;

    public int SectionSortOrder { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("PersonNominationGuid")]
    [InverseProperty("TPersonNominationQuestionSections")]
    public virtual TPersonNomination PersonNomination { get; set; } = null!;
}
