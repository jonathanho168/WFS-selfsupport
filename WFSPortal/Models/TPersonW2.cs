using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonW2")]
public partial class TPersonW2
{
    [Key]
    [Column("PersonW2GUID")]
    public Guid PersonW2guid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReportingPeriodStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReportingPeriodEndDate { get; set; }

    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? EarningsAmount { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? TotalHoursWorked { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LocationCode")]
    [InverseProperty("TPersonW2s")]
    public virtual TLocation LocationCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonW2s")]
    public virtual TPerson Person { get; set; } = null!;
}
