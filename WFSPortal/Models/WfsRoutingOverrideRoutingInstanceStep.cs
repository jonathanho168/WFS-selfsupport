using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("WFS_Routing_Override_RoutingInstanceStep")]
public partial class WfsRoutingOverrideRoutingInstanceStep
{
    [Column("RoutingStepGUID")]
    public Guid RoutingStepGuid { get; set; }

    [Column("SubjectPersonGUID")]
    public Guid? SubjectPersonGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column("RecipientPersonGUID")]
    public Guid? RecipientPersonGuid { get; set; }

    [Column("NewRecipientPersonGUID")]
    public Guid? NewRecipientPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OverrideStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OverrideEndDate { get; set; }
}
