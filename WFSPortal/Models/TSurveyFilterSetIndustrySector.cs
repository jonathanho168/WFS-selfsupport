using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyFilterSetIndustrySector")]
public partial class TSurveyFilterSetIndustrySector
{
    [StringLength(30)]
    public string SurveyFilterSetName { get; set; } = null!;

    [StringLength(15)]
    public string IndustrySectorCode { get; set; } = null!;

    [Key]
    [Column("SurveyFilterSetIndustrySectorGUID")]
    public Guid SurveyFilterSetIndustrySectorGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("IndustrySectorCode")]
    [InverseProperty("TSurveyFilterSetIndustrySectors")]
    public virtual TIndustrySector IndustrySectorCodeNavigation { get; set; } = null!;

    [ForeignKey("SurveyFilterSetName")]
    [InverseProperty("TSurveyFilterSetIndustrySectors")]
    public virtual TSurveyFilterSet SurveyFilterSetNameNavigation { get; set; } = null!;
}
