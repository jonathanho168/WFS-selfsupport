using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysVendorType")]
public partial class UsysVendorType
{
    [Key]
    [StringLength(15)]
    public string VendorTypeCode { get; set; } = null!;

    public string? VendorTypeDescription { get; set; }

    [Column("VendorTypeGUID")]
    public Guid VendorTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("VendorTypeCodeNavigation")]
    public virtual ICollection<TVendor> TVendors { get; set; } = new List<TVendor>();
}
