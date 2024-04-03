using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tNoticePeriodEmployerIndicator")]
public partial class TNoticePeriodEmployerIndicator
{
    [Key]
    [StringLength(15)]
    public string NoticePeriodEmployerIndicatorCode { get; set; } = null!;

    public string? NoticePeriodEmployerIndicatorDescription { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("NoticePeriodEmployerIndicatorGUID")]
    public Guid NoticePeriodEmployerIndicatorGuid { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("NoticePeriodEmployeeIndicatorNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHistNoticePeriodEmployeeIndicatorNavigations { get; set; } = new List<TPersonJobHist>();

    [InverseProperty("NoticePeriodEmployerIndicatorNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHistNoticePeriodEmployerIndicatorNavigations { get; set; } = new List<TPersonJobHist>();
}
