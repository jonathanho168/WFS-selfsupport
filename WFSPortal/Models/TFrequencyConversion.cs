using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tFrequencyConversion")]
public partial class TFrequencyConversion
{
    [StringLength(15)]
    public string ScheduleCode { get; set; } = null!;

    [StringLength(15)]
    public string FromFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string ToFrequencyCode { get; set; } = null!;

    [Column(TypeName = "numeric(28, 18)")]
    public decimal? ConversionFactor { get; set; }

    [Key]
    [Column("FrequencyConversionGUID")]
    public Guid FrequencyConversionGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("FromFrequencyCode")]
    [InverseProperty("TFrequencyConversionFromFrequencyCodeNavigations")]
    public virtual TFrequency FromFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("ScheduleCode")]
    [InverseProperty("TFrequencyConversions")]
    public virtual TSchedule ScheduleCodeNavigation { get; set; } = null!;

    [ForeignKey("ToFrequencyCode")]
    [InverseProperty("TFrequencyConversionToFrequencyCodeNavigations")]
    public virtual TFrequency ToFrequencyCodeNavigation { get; set; } = null!;
}
