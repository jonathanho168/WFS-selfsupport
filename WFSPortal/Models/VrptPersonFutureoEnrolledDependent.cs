using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptPersonFutureoEnrolledDependent
{
    [Column("PersonFutureEnrollmentStatusGUID")]
    public Guid? PersonFutureEnrollmentStatusGuid { get; set; }

    public Guid? BenefitPlanOptionGuid { get; set; }

    [Column("ResponsiblePersonGUID")]
    public Guid? ResponsiblePersonGuid { get; set; }

    [Column("ORD")]
    public int? Ord { get; set; }

    [Column("enrolled_list")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? EnrolledList { get; set; }
}
