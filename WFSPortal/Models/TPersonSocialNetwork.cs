using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonSocialNetwork")]
public partial class TPersonSocialNetwork
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string SocialNetworkTypeCode { get; set; } = null!;

    [StringLength(50)]
    public string UserName { get; set; } = null!;

    [Key]
    [Column("PersonSocialNetworkGUID")]
    public Guid PersonSocialNetworkGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(80)]
    public string? Description { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonSocialNetworks")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("SocialNetworkTypeCode")]
    [InverseProperty("TPersonSocialNetworks")]
    public virtual TSocialNetworkType SocialNetworkTypeCodeNavigation { get; set; } = null!;
}
