using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tHoliday")]
[Index("HolidayGuid", Name = "RG_tHoliday", IsUnique = true)]
public partial class THoliday
{
    [Column("HolidayGUID")]
    public Guid HolidayGuid { get; set; }

    public int RowVersion { get; set; }

    public bool FixedDateFlag { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? DefaultHours { get; set; }

    public bool InactiveFlag { get; set; }

    [Key]
    [StringLength(15)]
    public string HolidayCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? HolidayBaseDate { get; set; }

    public string? HolidayDescription { get; set; }

    [InverseProperty("HolidayCodeNavigation")]
    public virtual ICollection<THolidayOccurrence> THolidayOccurrences { get; set; } = new List<THolidayOccurrence>();

    [InverseProperty("HolidayCodeNavigation")]
    public virtual ICollection<TTimeGroupHoliday> TTimeGroupHolidays { get; set; } = new List<TTimeGroupHoliday>();
}
