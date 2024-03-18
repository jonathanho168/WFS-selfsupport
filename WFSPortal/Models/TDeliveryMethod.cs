using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDeliveryMethod")]
[Index("DeliveryMethodGuid", Name = "RG_tDeliveryMethod", IsUnique = true)]
public partial class TDeliveryMethod
{
    [Key]
    [StringLength(15)]
    public string DeliveryMethodCode { get; set; } = null!;

    [Column("DeliveryMethodGUID")]
    public Guid DeliveryMethodGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DeliveryMethodDescription { get; set; }

    [InverseProperty("DeliveryMethodCodeNavigation")]
    public virtual ICollection<TPersonApplicationOffer> TPersonApplicationOffers { get; set; } = new List<TPersonApplicationOffer>();
}
