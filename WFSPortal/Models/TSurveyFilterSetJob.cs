using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyFilterSetJob")]
public partial class TSurveyFilterSetJob
{
    [StringLength(30)]
    public string SurveyFilterSetName { get; set; } = null!;

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [Key]
    [Column("SurveyFilterSetJobGUID")]
    public Guid SurveyFilterSetJobGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("JobCode")]
    [InverseProperty("TSurveyFilterSetJobs")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("SurveyFilterSetName")]
    [InverseProperty("TSurveyFilterSetJobs")]
    public virtual TSurveyFilterSet SurveyFilterSetNameNavigation { get; set; } = null!;
}
