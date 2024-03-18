using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tHolidayOccurrence")]
public partial class THolidayOccurrence
{
    [Key]
    [Column("HolidayOccurrenceGUID")]
    public Guid HolidayOccurrenceGuid { get; set; }

    [StringLength(15)]
    public string HolidayCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HolidayDate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? DefaultHours { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("HolidayCode")]
    [InverseProperty("THolidayOccurrences")]
    public virtual THoliday HolidayCodeNavigation { get; set; } = null!;

    [InverseProperty("HolidayOccurrence")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();
}
