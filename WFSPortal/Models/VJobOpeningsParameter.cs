using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VJobOpeningsParameter
{
    [Column("JobOpeningsParametersGUID")]
    public Guid JobOpeningsParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? ShowParamCityState { get; set; }

    public string? ShowLocation { get; set; }

    public string? ShowCloseDate { get; set; }

    public string? ShowParamLocation { get; set; }

    public string? ShowJobCategory { get; set; }

    public string? ShowReqCode { get; set; }

    public string? ShowParamKeyWords { get; set; }

    public string? ShowGrade { get; set; }

    public string? ShowPosition { get; set; }

    public string? ShowParamDepartment { get; set; }

    public string? ShowParamPostedSince { get; set; }

    public string? ShowParamShift { get; set; }

    public string? ShowParamJobCategory { get; set; }

    public string? DefaultSortDirection { get; set; }

    public string? ShowPostingDate { get; set; }

    public string? ShowFullTime { get; set; }

    public string? ShowParamRequisition { get; set; }

    public string? ShowParamFullTime { get; set; }

    public string? ShowPayRange { get; set; }

    public string? ShowDepartment { get; set; }

    public string? DoAutomaticSearch { get; set; }

    public string? DefaultSortBy { get; set; }
}
