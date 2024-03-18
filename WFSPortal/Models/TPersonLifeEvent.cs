using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonLifeEvent")]
public partial class TPersonLifeEvent
{
    [Key]
    [Column("PersonLifeEventGUID")]
    public Guid PersonLifeEventGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonLifeEventEventDate { get; set; }

    [StringLength(15)]
    public string LifeEventTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string LifeEventStatusCode { get; set; } = null!;

    [Column("ResponseByPersonGUID")]
    public Guid? ResponseByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResponseDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualNotificationDate { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    public byte[]? Attachment { get; set; }

    public bool GeneratedFlag { get; set; }

    [ForeignKey("LifeEventStatusCode")]
    [InverseProperty("TPersonLifeEvents")]
    public virtual TLifeEventStatus LifeEventStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("LifeEventTypeCode")]
    [InverseProperty("TPersonLifeEvents")]
    public virtual TLifeEventType LifeEventTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonLifeEventPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("ResponseByPersonGuid")]
    [InverseProperty("TPersonLifeEventResponseByPeople")]
    public virtual TPerson? ResponseByPerson { get; set; }
}
