using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSocialNetworkType")]
public partial class TSocialNetworkType
{
    [Key]
    [StringLength(15)]
    public string SocialNetworkTypeCode { get; set; } = null!;

    [Column("BaseURL")]
    [StringLength(50)]
    public string? BaseUrl { get; set; }

    [StringLength(10)]
    public string? Collect { get; set; }

    public bool CollectDescriptionFlag { get; set; }

    [Column("SocialNetworkTypeGUID")]
    public Guid SocialNetworkTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    public string? SocialNetworkTypeDescription { get; set; }

    [InverseProperty("SocialNetworkTypeCodeNavigation")]
    public virtual ICollection<TPersonSocialNetwork> TPersonSocialNetworks { get; set; } = new List<TPersonSocialNetwork>();
}
