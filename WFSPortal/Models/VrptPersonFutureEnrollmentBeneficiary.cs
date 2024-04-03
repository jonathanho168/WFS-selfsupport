using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptPersonFutureEnrollmentBeneficiary
{
    [Column("PersonFutureEnrollmentGUID")]
    public Guid PersonFutureEnrollmentGuid { get; set; }

    public int? IterationsNum { get; set; }
}
