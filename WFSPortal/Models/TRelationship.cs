using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRelationship")]
[Index("RelationshipGuid", Name = "RG_tRelationship", IsUnique = true)]
public partial class TRelationship
{
    [Key]
    [StringLength(15)]
    public string RelationshipCode { get; set; } = null!;

    [Column("RelationshipGUID")]
    public Guid RelationshipGuid { get; set; }

    public bool SpousalEquivalencyFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? RelationshipDescription { get; set; }

    [InverseProperty("RelationshipCodeNavigation")]
    public virtual ICollection<TDependentTypeRelationship> TDependentTypeRelationships { get; set; } = new List<TDependentTypeRelationship>();

    [InverseProperty("RelationshipCodeNavigation")]
    public virtual ICollection<TPersonBenefitBeneficiaryHist> TPersonBenefitBeneficiaryHists { get; set; } = new List<TPersonBenefitBeneficiaryHist>();

    [InverseProperty("RelationshipCodeNavigation")]
    public virtual ICollection<TPersonDependent> TPersonDependents { get; set; } = new List<TPersonDependent>();

    [InverseProperty("RelationshipCodeNavigation")]
    public virtual ICollection<TPersonEmergency> TPersonEmergencies { get; set; } = new List<TPersonEmergency>();

    [InverseProperty("RelationshipCodeNavigation")]
    public virtual ICollection<TPersonFutureEnrollmentBeneficiary> TPersonFutureEnrollmentBeneficiaries { get; set; } = new List<TPersonFutureEnrollmentBeneficiary>();
}
