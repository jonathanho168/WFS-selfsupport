using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEducationStatus")]
[Index("EducationStatusGuid", Name = "RG_tEducationStatus", IsUnique = true)]
public partial class TEducationStatus
{
    [Key]
    [StringLength(15)]
    public string EducationStatusCode { get; set; } = null!;

    [Column("EducationStatusGUID")]
    public Guid EducationStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? EducationStatusDescription { get; set; }

    [InverseProperty("EducationStatusCodeNavigation")]
    public virtual ICollection<TPersonEducationHist> TPersonEducationHists { get; set; } = new List<TPersonEducationHist>();
}
