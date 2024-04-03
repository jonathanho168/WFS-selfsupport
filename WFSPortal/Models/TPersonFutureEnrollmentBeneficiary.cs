using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonFutureEnrollmentBeneficiary")]
public partial class TPersonFutureEnrollmentBeneficiary
{
    [Key]
    [Column("PersonFutureEnrollmentBeneficiaryGUID")]
    public Guid PersonFutureEnrollmentBeneficiaryGuid { get; set; }

    [Column("PersonFutureEnrollmentGUID")]
    public Guid PersonFutureEnrollmentGuid { get; set; }

    [StringLength(80)]
    public string Beneficiary { get; set; } = null!;

    [StringLength(15)]
    public string RelationshipCode { get; set; } = null!;

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    public bool PrimaryBeneficiary { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? BeneficiaryBenefitPercentage { get; set; }

    public bool ContingentBeneficiaryFlag { get; set; }

    [ForeignKey("PersonFutureEnrollmentGuid")]
    [InverseProperty("TPersonFutureEnrollmentBeneficiaries")]
    public virtual TPersonFutureEnrollment PersonFutureEnrollment { get; set; } = null!;

    [ForeignKey("RelationshipCode")]
    [InverseProperty("TPersonFutureEnrollmentBeneficiaries")]
    public virtual TRelationship RelationshipCodeNavigation { get; set; } = null!;
}
