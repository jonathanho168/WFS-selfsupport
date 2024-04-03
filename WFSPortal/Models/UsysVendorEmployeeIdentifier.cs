using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysVendorEmployeeIdentifier")]
public partial class UsysVendorEmployeeIdentifier
{
    [Key]
    [StringLength(15)]
    public string VendorEmployeeIdentifierCode { get; set; } = null!;

    public string? VendorEmployeeIdentifierDescription { get; set; }

    [Column("VendorEmployeeIdentifierGUID")]
    public Guid VendorEmployeeIdentifierGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("VendorEmployeeIdentifierCodeNavigation")]
    public virtual ICollection<TVendor> TVendors { get; set; } = new List<TVendor>();
}
