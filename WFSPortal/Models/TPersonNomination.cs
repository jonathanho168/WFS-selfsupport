using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonNomination")]
public partial class TPersonNomination
{
    [Key]
    [Column("PersonNominationGUID")]
    public Guid PersonNominationGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [Column("NominatedByPersonGUID")]
    public Guid NominatedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime NominatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProjectedReadinessDate { get; set; }

    public bool? CreateApplicationFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedDate { get; set; }

    [Column("LastUpdatedByPersonGUID")]
    public Guid LastUpdatedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    public bool SubmittedFlag { get; set; }

    public bool ApprovedFlag { get; set; }

    public bool WithdrawnFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("JobCode")]
    [InverseProperty("TPersonNominations")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("LastUpdatedByPersonGuid")]
    [InverseProperty("TPersonNominationLastUpdatedByPeople")]
    public virtual TPerson LastUpdatedByPerson { get; set; } = null!;

    [ForeignKey("NominatedByPersonGuid")]
    [InverseProperty("TPersonNominationNominatedByPeople")]
    public virtual TPerson NominatedByPerson { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonNominationPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonNominations")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [InverseProperty("PersonNomination")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();

    [InverseProperty("PersonNomination")]
    public virtual ICollection<TPersonNominationQuestionSection> TPersonNominationQuestionSections { get; set; } = new List<TPersonNominationQuestionSection>();

    [InverseProperty("PersonNomination")]
    public virtual ICollection<TPersonNominationQuestion> TPersonNominationQuestions { get; set; } = new List<TPersonNominationQuestion>();
}
