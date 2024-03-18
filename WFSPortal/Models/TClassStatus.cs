using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tClassStatus")]
[Index("ClassStatusGuid", Name = "RG_tClassStatus", IsUnique = true)]
public partial class TClassStatus
{
    [Key]
    [StringLength(15)]
    public string ClassStatusCode { get; set; } = null!;

    [StringLength(50)]
    public string? CalendarColor { get; set; }

    [Column("ClassStatusGUID")]
    public Guid ClassStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool? OpenFlag { get; set; }

    public bool? CanceledFlag { get; set; }

    public bool? AcceptingEnrollmentsFlag { get; set; }

    [Column("ShowInESSFlag")]
    public bool ShowInEssflag { get; set; }

    public string? ClassStatusDescription { get; set; }

    [InverseProperty("ClassStatusCodeNavigation")]
    public virtual ICollection<TClass> TClasses { get; set; } = new List<TClass>();
}
