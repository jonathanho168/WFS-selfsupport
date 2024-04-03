using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkAbsencePlansErp
{
    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    public string? AbsencePlanDescription { get; set; }

    public bool InactiveFlag { get; set; }
}
