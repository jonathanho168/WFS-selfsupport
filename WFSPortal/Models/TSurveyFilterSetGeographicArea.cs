using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyFilterSetGeographicArea")]
public partial class TSurveyFilterSetGeographicArea
{
    [StringLength(30)]
    public string SurveyFilterSetName { get; set; } = null!;

    [StringLength(15)]
    public string GeographicAreaCode { get; set; } = null!;

    [Key]
    [Column("SurveyFilterSetGeographicAreaGUID")]
    public Guid SurveyFilterSetGeographicAreaGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("GeographicAreaCode")]
    [InverseProperty("TSurveyFilterSetGeographicAreas")]
    public virtual TGeographicArea GeographicAreaCodeNavigation { get; set; } = null!;

    [ForeignKey("SurveyFilterSetName")]
    [InverseProperty("TSurveyFilterSetGeographicAreas")]
    public virtual TSurveyFilterSet SurveyFilterSetNameNavigation { get; set; } = null!;
}
