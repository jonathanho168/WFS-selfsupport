using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyFilterSetSurveySource")]
public partial class TSurveyFilterSetSurveySource
{
    [StringLength(30)]
    public string SurveyFilterSetName { get; set; } = null!;

    [StringLength(15)]
    public string SurveySourceCode { get; set; } = null!;

    [Key]
    [Column("SurveyFilterSetSurveySourceGUID")]
    public Guid SurveyFilterSetSurveySourceGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("SurveyFilterSetName")]
    [InverseProperty("TSurveyFilterSetSurveySources")]
    public virtual TSurveyFilterSet SurveyFilterSetNameNavigation { get; set; } = null!;

    [ForeignKey("SurveySourceCode")]
    [InverseProperty("TSurveyFilterSetSurveySources")]
    public virtual TSurveySource SurveySourceCodeNavigation { get; set; } = null!;
}
