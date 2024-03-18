using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOfferType")]
[Index("OfferTypeGuid", Name = "RG_tOfferType", IsUnique = true)]
public partial class TOfferType
{
    [Key]
    [StringLength(15)]
    public string OfferTypeCode { get; set; } = null!;

    [Column("OfferTypeGUID")]
    public Guid OfferTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? OfferTypeDescription { get; set; }

    [InverseProperty("OfferTypeCodeNavigation")]
    public virtual ICollection<TPersonApplicationOffer> TPersonApplicationOffers { get; set; } = new List<TPersonApplicationOffer>();
}
