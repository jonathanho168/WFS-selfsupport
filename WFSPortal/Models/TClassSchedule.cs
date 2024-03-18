using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tClassSchedule")]
public partial class TClassSchedule
{
    [Key]
    public Guid ClassScheduleGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EventDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndTime { get; set; }

    [StringLength(15)]
    public string EventTypeCode { get; set; } = null!;

    [StringLength(30)]
    public string? MeetingOrganizer { get; set; }

    public string? EventComments { get; set; }

    public int RowVersion { get; set; }

    public Guid ClassGuid { get; set; }

    [StringLength(15)]
    public string FacilityCode { get; set; } = null!;

    [ForeignKey("ClassGuid")]
    [InverseProperty("TClassSchedules")]
    public virtual TClass Class { get; set; } = null!;

    [ForeignKey("EventTypeCode")]
    [InverseProperty("TClassSchedules")]
    public virtual TEventType EventTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("FacilityCode")]
    [InverseProperty("TClassSchedules")]
    public virtual TFacility FacilityCodeNavigation { get; set; } = null!;
}
