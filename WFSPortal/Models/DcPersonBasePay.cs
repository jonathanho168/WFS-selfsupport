using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonBasePay")]
public partial class DcPersonBasePay
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBasePayStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBasePayEndDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PersonBasePayCurrencyCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? PersonBasePayAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PersonBasePayFrequencyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PersonBasePayPayrollFrequencyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BasePayReasonCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ScheduleCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledBasePayReviewDate { get; set; }
}
