using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBenefitBeneficiaryHist")]
public partial class TPersonBenefitBeneficiaryHist
{
    [Column("PersonBenefitGUID")]
    public Guid PersonBenefitGuid { get; set; }

    [StringLength(80)]
    public string Beneficiary { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitBeneficiaryStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitBeneficiaryEndDate { get; set; }

    [StringLength(15)]
    public string RelationshipCode { get; set; } = null!;

    public string? Comments { get; set; }

    public bool PersonBenefitBeneficiaryCurrentFlag { get; set; }

    [Key]
    [Column("PersonBenefitBeneficiaryGUID")]
    public Guid PersonBenefitBeneficiaryGuid { get; set; }

    public int RowVersion { get; set; }

    public bool PrimaryBeneficiary { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? BeneficiaryBenefitPercentage { get; set; }

    public bool ContingentBeneficiaryFlag { get; set; }

    [ForeignKey("PersonBenefitGuid")]
    [InverseProperty("TPersonBenefitBeneficiaryHists")]
    public virtual TPersonBenefitHist PersonBenefit { get; set; } = null!;

    [ForeignKey("RelationshipCode")]
    [InverseProperty("TPersonBenefitBeneficiaryHists")]
    public virtual TRelationship RelationshipCodeNavigation { get; set; } = null!;
}
