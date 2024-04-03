using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCarrier")]
[Index("CarrierGuid", Name = "RG_tCarrier", IsUnique = true)]
public partial class TCarrier
{
    [Key]
    [StringLength(15)]
    public string CarrierCode { get; set; } = null!;

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [Column("CarrierGUID")]
    public Guid CarrierGuid { get; set; }

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CarrierDescription { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TCarriers")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TCarriers")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("CarrierCodeNavigation")]
    public virtual ICollection<TBenefitCarrierHist> TBenefitCarrierHists { get; set; } = new List<TBenefitCarrierHist>();
}
