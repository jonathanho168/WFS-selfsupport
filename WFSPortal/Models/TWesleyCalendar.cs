using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tWesleyCalendar")]
[Index("WesleyCalendarGuid", Name = "RG_tWesleyCalendar", IsUnique = true)]
public partial class TWesleyCalendar
{
    [Key]
    [StringLength(15)]
    public string WesleyCalendarCode { get; set; } = null!;

    [Column("WesleyCalendarGUID")]
    public Guid WesleyCalendarGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? WesleyCalendarDescription { get; set; }

    [InverseProperty("WesleyCalendarCodeNavigation")]
    public virtual ICollection<TPersonStatusHist> TPersonStatusHists { get; set; } = new List<TPersonStatusHist>();
}
