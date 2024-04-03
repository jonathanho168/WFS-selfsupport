using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonDiscipline")]
public partial class TPersonDiscipline
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [StringLength(15)]
    public string DisciplineActionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DeletionDate { get; set; }

    [StringLength(15)]
    public string DisciplineTypeCode { get; set; } = null!;

    [Column("HandledByPersonGUID")]
    public Guid? HandledByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PerformedDate { get; set; }

    [StringLength(2000)]
    public string? ProblemDescription { get; set; }

    [StringLength(2000)]
    public string? Resolution { get; set; }

    [Key]
    [Column("PersonDisciplineGUID")]
    public Guid PersonDisciplineGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string DisciplinePrimaryPolicyCode { get; set; } = null!;

    [StringLength(15)]
    public string DisciplineReasonCode { get; set; } = null!;

    [ForeignKey("DisciplineActionCode")]
    [InverseProperty("TPersonDisciplines")]
    public virtual TDisciplineAction DisciplineActionCodeNavigation { get; set; } = null!;

    [ForeignKey("DisciplinePrimaryPolicyCode")]
    [InverseProperty("TPersonDisciplines")]
    public virtual TDisciplinePrimaryPolicy DisciplinePrimaryPolicyCodeNavigation { get; set; } = null!;

    [ForeignKey("DisciplineReasonCode")]
    [InverseProperty("TPersonDisciplines")]
    public virtual TDisciplineReason DisciplineReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("DisciplineTypeCode")]
    [InverseProperty("TPersonDisciplines")]
    public virtual TDisciplineType DisciplineTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("HandledByPersonGuid")]
    [InverseProperty("TPersonDisciplineHandledByPeople")]
    public virtual TPerson? HandledByPerson { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonDisciplinePeople")]
    public virtual TPerson Person { get; set; } = null!;
}
