using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyFilterSetJobFamily")]
public partial class TSurveyFilterSetJobFamily
{
    [StringLength(30)]
    public string SurveyFilterSetName { get; set; } = null!;

    [StringLength(15)]
    public string JobFamilyCode { get; set; } = null!;

    [Key]
    [Column("SurveyFilterSetJobFamilyGUID")]
    public Guid SurveyFilterSetJobFamilyGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("JobFamilyCode")]
    [InverseProperty("TSurveyFilterSetJobFamilies")]
    public virtual TJobFamily JobFamilyCodeNavigation { get; set; } = null!;

    [ForeignKey("SurveyFilterSetName")]
    [InverseProperty("TSurveyFilterSetJobFamilies")]
    public virtual TSurveyFilterSet SurveyFilterSetNameNavigation { get; set; } = null!;
}
