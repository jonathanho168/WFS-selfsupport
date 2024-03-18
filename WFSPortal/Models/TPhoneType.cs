using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPhoneType")]
[Index("PhoneTypeGuid", Name = "RG_tPhoneType", IsUnique = true)]
public partial class TPhoneType
{
    [Key]
    [StringLength(15)]
    public string PhoneTypeCode { get; set; } = null!;

    [Column("PhoneTypeGUID")]
    public Guid PhoneTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    public bool ShowInPhoneDirectoryFlag { get; set; }

    public string? PhoneTypeDescription { get; set; }

    [InverseProperty("PhoneTypeCodeNavigation")]
    public virtual ICollection<TPersonPhone> TPersonPhones { get; set; } = new List<TPersonPhone>();
}
