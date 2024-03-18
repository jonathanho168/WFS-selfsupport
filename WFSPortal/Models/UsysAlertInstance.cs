using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAlertInstance")]
public partial class UsysAlertInstance
{
    [Key]
    [Column("AlertInstanceGUID")]
    public Guid AlertInstanceGuid { get; set; }

    [Column("AlertScheduleGUID")]
    public Guid? AlertScheduleGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SentDateTime { get; set; }

    public int RowVersion { get; set; }

    public Guid RecordGuid { get; set; }

    [Column("AlertGUID")]
    public Guid? AlertGuid { get; set; }

    [ForeignKey("AlertGuid")]
    [InverseProperty("UsysAlertInstances")]
    public virtual UsysAlert? Alert { get; set; }

    [ForeignKey("AlertScheduleGuid")]
    [InverseProperty("UsysAlertInstances")]
    public virtual UsysAlertSchedule? AlertSchedule { get; set; }
}
