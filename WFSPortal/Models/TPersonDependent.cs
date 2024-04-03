using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonDependent")]
[Index("PersonDependentGuid", Name = "RG_tPersonDependent", IsUnique = true)]
public partial class TPersonDependent
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("DependentPersonGUID")]
    public Guid DependentPersonGuid { get; set; }

    [StringLength(15)]
    public string RelationshipCode { get; set; } = null!;

    public bool FullTimeStudentFlag { get; set; }

    public bool TaxClaimableFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastVerifiedDate { get; set; }

    [Key]
    [Column("PersonDependentGUID")]
    public Guid PersonDependentGuid { get; set; }

    public bool ExcludeFromBenefitsFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public bool ConsideredPostTaxFlag { get; set; }

    public bool HideInSelfServiceFlag { get; set; }

    [ForeignKey("DependentPersonGuid")]
    [InverseProperty("TPersonDependentDependentPeople")]
    public virtual TPerson DependentPerson { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonDependentPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("RelationshipCode")]
    [InverseProperty("TPersonDependents")]
    public virtual TRelationship RelationshipCodeNavigation { get; set; } = null!;
}
