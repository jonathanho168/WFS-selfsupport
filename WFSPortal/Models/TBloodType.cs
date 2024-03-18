using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBloodType")]
[Index("BloodTypeGuid", Name = "RG_tBloodType", IsUnique = true)]
public partial class TBloodType
{
    [Key]
    [StringLength(15)]
    public string BloodTypeCode { get; set; } = null!;

    [Column("BloodTypeGUID")]
    public Guid BloodTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? BloodTypeDescription { get; set; }

    [InverseProperty("BloodTypeCodeNavigation")]
    public virtual ICollection<TPersonMedical> TPersonMedicals { get; set; } = new List<TPersonMedical>();
}
