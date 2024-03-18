using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAddressType")]
[Index("AddressTypeGuid", Name = "RG_tAddressType", IsUnique = true)]
public partial class TAddressType
{
    [Key]
    [StringLength(15)]
    public string AddressTypeCode { get; set; } = null!;

    [Column("AddressTypeGUID")]
    public Guid AddressTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? AddressTypeDescription { get; set; }

    [InverseProperty("AddressTypeCodeNavigation")]
    public virtual ICollection<TPersonAddress> TPersonAddresses { get; set; } = new List<TPersonAddress>();
}
