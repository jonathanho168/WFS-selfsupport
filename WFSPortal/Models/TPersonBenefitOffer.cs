using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBenefitOffer")]
public partial class TPersonBenefitOffer
{
    [Key]
    [Column("PersonBenefitOfferGUID")]
    public Guid PersonBenefitOfferGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OfferStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OfferEndDate { get; set; }

    public bool EmployeeCoverageFlag { get; set; }

    public bool EmployeeMinimumEssentialCoverageFlag { get; set; }

    public bool EmployeeMinimumValueFlag { get; set; }

    public bool SpousalCoverageFlag { get; set; }

    public bool SpousalMinimumEssentialCoverageFlag { get; set; }

    public bool SpousalMinimumValueFlag { get; set; }

    public bool DependentCoverageFlag { get; set; }

    public bool DependentMinimumEssentialCoverageFlag { get; set; }

    public bool DependentMinimumValueFlag { get; set; }

    [Column(TypeName = "money")]
    public decimal? LowestEmployeeContributionAmount { get; set; }

    public int RowVersion { get; set; }

    [Column("COBRAFlag")]
    public bool Cobraflag { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Jan { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Feb { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Mar { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Apr { get; set; }

    [StringLength(30)]
    public string? OverrideLine14May { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Jun { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Jul { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Aug { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Sep { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Oct { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Nov { get; set; }

    [StringLength(30)]
    public string? OverrideLine14Dec { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Jan { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Feb { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Mar { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Apr { get; set; }

    [StringLength(30)]
    public string? OverrideLine15May { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Jun { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Jul { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Aug { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Sep { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Oct { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Nov { get; set; }

    [StringLength(30)]
    public string? OverrideLine15Dec { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Jan { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Feb { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Mar { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Apr { get; set; }

    [StringLength(30)]
    public string? OverrideLine16May { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Jun { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Jul { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Aug { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Sep { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Oct { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Nov { get; set; }

    [StringLength(30)]
    public string? OverrideLine16Dec { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonBenefitOffers")]
    public virtual TPerson Person { get; set; } = null!;
}
