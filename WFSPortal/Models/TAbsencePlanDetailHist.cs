using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePlanDetailHist")]
public partial class TAbsencePlanDetailHist
{
    [Key]
    [Column("AbsencePlanDetailGUID")]
    public Guid AbsencePlanDetailGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AbsencePlanStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AbsencePlanEndDate { get; set; }

    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    [StringLength(15)]
    public string AbsencePlanTypeCode { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string AbsenceUnits { get; set; } = null!;

    public bool AccrualResetFlag { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string AccrualPeriod { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string BeginEndAccrual { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string EligibilityChangeRule { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FiscalBeginDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PeriodBeginDate { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string PlanYearType { get; set; } = null!;

    [StringLength(128)]
    public string TimeInServiceField { get; set; } = null!;

    public bool AutoEnrollFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? NegativeBalanceLimit { get; set; }

    public bool AbsencePlanCurrentFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("FTEAccrualFlag")]
    public bool FteaccrualFlag { get; set; }

    [Column("FTEMaximumFlag")]
    public bool FtemaximumFlag { get; set; }

    [Column("FTECarryOverFlag")]
    public bool FtecarryOverFlag { get; set; }

    public string? AbsencePlanDescription { get; set; }

    [Column("ShowInESSFlag")]
    public bool ShowInEssflag { get; set; }

    [Column("ShowInESSAfterAmountOfYears")]
    public int? ShowInEssafterAmountOfYears { get; set; }

    public int? StartRequestingTimeAmount { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? StartRequestingTimeFrequency { get; set; }

    [ForeignKey("AbsencePlanCode")]
    [InverseProperty("TAbsencePlanDetailHists")]
    public virtual TAbsencePlan AbsencePlanCodeNavigation { get; set; } = null!;

    [ForeignKey("AbsencePlanTypeCode")]
    [InverseProperty("TAbsencePlanDetailHists")]
    public virtual TAbsencePlanType AbsencePlanTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("AbsencePlanDetail")]
    public virtual ICollection<TAbsencePlanRule> TAbsencePlanRules { get; set; } = new List<TAbsencePlanRule>();
}
