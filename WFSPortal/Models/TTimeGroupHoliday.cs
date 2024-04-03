using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTimeGroupHoliday")]
public partial class TTimeGroupHoliday
{
    [StringLength(15)]
    public string TimeGroupCode { get; set; } = null!;

    [Key]
    [Column("TimeGroupHolidayGUID")]
    public Guid TimeGroupHolidayGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string HolidayCode { get; set; } = null!;

    [ForeignKey("HolidayCode")]
    [InverseProperty("TTimeGroupHolidays")]
    public virtual THoliday HolidayCodeNavigation { get; set; } = null!;

    [ForeignKey("TimeGroupCode")]
    [InverseProperty("TTimeGroupHolidays")]
    public virtual TTimeGroup TimeGroupCodeNavigation { get; set; } = null!;
}
