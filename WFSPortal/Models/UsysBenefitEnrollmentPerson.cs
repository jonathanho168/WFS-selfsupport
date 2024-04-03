using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBenefitEnrollmentPerson")]
public partial class UsysBenefitEnrollmentPerson
{
    [StringLength(200)]
    public string UserName { get; set; } = null!;

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [Key]
    [Column("BenefitEnrollmentPersonGUID")]
    public Guid BenefitEnrollmentPersonGuid { get; set; }

    public int RowVersion { get; set; }
}
