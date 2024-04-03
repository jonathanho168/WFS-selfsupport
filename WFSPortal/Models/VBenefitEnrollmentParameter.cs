using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VBenefitEnrollmentParameter
{
    [Column("BenefitEnrollmentParametersGUID")]
    public Guid BenefitEnrollmentParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? AdminEmail { get; set; }
}
