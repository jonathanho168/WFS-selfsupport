using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tVendorUserField")]
[Index("VendorUserFieldCode", "VendorCode", Name = "AK_tVendorUserField", IsUnique = true)]
public partial class TVendorUserField
{
    [StringLength(15)]
    public string VendorCode { get; set; } = null!;

    [StringLength(15)]
    public string VendorUserFieldCode { get; set; } = null!;

    public string? VendorUserFieldDescription { get; set; }

    [StringLength(255)]
    public string? VendorUserFieldValue { get; set; }

    [Key]
    [Column("VendorUserFieldGUID")]
    public Guid VendorUserFieldGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("VendorCode")]
    [InverseProperty("TVendorUserFields")]
    public virtual TVendor VendorCodeNavigation { get; set; } = null!;
}
