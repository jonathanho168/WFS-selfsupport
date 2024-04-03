using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VPersonGoalParameter
{
    [Column("PersonGoalParametersGUID")]
    public Guid PersonGoalParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? ShowCompetencies { get; set; }

    public string? ShowLanguages { get; set; }

    public string? ShowCertifications { get; set; }

    public string? ShowCourses { get; set; }
}
