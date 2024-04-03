using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyFilterSetCompanySize")]
public partial class TSurveyFilterSetCompanySize
{
    [StringLength(30)]
    public string SurveyFilterSetName { get; set; } = null!;

    [StringLength(15)]
    public string SurveyCompanySizeCode { get; set; } = null!;

    [Key]
    [Column("SurveyFilterSetCompanySizeGUID")]
    public Guid SurveyFilterSetCompanySizeGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("SurveyCompanySizeCode")]
    [InverseProperty("TSurveyFilterSetCompanySizes")]
    public virtual TSurveyCompanySize SurveyCompanySizeCodeNavigation { get; set; } = null!;

    [ForeignKey("SurveyFilterSetName")]
    [InverseProperty("TSurveyFilterSetCompanySizes")]
    public virtual TSurveyFilterSet SurveyFilterSetNameNavigation { get; set; } = null!;
}
