using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysResourceType")]
public partial class UsysResourceType
{
    [Column("ResourceTypeGUID")]
    public Guid ResourceTypeGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string ResourceTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string ResourceTypeDescription { get; set; } = null!;

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    [InverseProperty("ResourceTypeCodeNavigation")]
    public virtual ICollection<UsysResource> UsysResources { get; set; } = new List<UsysResource>();
}
