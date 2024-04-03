using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tVeteran")]
[Index("VeteranGuid", Name = "RG_tVeteran", IsUnique = true)]
public partial class TVeteran
{
    [Key]
    [StringLength(15)]
    public string VeteranCode { get; set; } = null!;

    [Column("VeteranGUID")]
    public Guid VeteranGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? VeteranDescription { get; set; }

    [InverseProperty("VeteranCodeNavigation")]
    public virtual ICollection<TPersonVeteran> TPersonVeterans { get; set; } = new List<TPersonVeteran>();
}
