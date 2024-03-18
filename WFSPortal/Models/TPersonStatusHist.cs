using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonStatusHist")]
[Index("StatusCode", Name = "IX_tPersonStatusHist_StatusCode")]
public partial class TPersonStatusHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonStatusStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdjustedHireDate { get; set; }

    [StringLength(15)]
    public string InternationalTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? NormalHoursPerWeek { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PriorServiceCredits { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PriorServiceUnits { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SeniorityDate { get; set; }

    [StringLength(15)]
    public string HireSourceCode { get; set; } = null!;

    [StringLength(15)]
    public string StatusReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string StatusCategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string StatusCode { get; set; } = null!;

    public bool PersonStatusCurrentFlag { get; set; }

    [Key]
    [Column("PersonStatusGUID")]
    public Guid PersonStatusGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string? WesleyCalendarCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProbationaryStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProbationaryEndDate { get; set; }

    public bool CsfUkOptOutWorkingTimeDirectiveFlag { get; set; }

    public byte[]? CsfUkOptOutWorkingTimeDirectiveDocument { get; set; }

    [ForeignKey("HireSourceCode")]
    [InverseProperty("TPersonStatusHists")]
    public virtual THireSource HireSourceCodeNavigation { get; set; } = null!;

    [ForeignKey("InternationalTypeCode")]
    [InverseProperty("TPersonStatusHists")]
    public virtual TInternationalType InternationalTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonStatusHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("StatusCategoryCode")]
    [InverseProperty("TPersonStatusHists")]
    public virtual TStatusCategory StatusCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("StatusCode")]
    [InverseProperty("TPersonStatusHists")]
    public virtual TStatus StatusCodeNavigation { get; set; } = null!;

    [ForeignKey("StatusReasonCode")]
    [InverseProperty("TPersonStatusHists")]
    public virtual TStatusReason StatusReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("WesleyCalendarCode")]
    [InverseProperty("TPersonStatusHists")]
    public virtual TWesleyCalendar? WesleyCalendarCodeNavigation { get; set; }
}
