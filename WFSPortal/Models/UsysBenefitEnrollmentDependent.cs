using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBenefitEnrollmentDependent")]
public partial class UsysBenefitEnrollmentDependent
{
    [StringLength(128)]
    public string UserName { get; set; } = null!;

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("DependentPersonGUID")]
    public Guid DependentPersonGuid { get; set; }

    public bool SpousalEquivalencyFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [Key]
    [Column("BenefitEnrollmentDependentGUID")]
    public Guid BenefitEnrollmentDependentGuid { get; set; }

    public int RowVersion { get; set; }

    public byte? DependentAge { get; set; }

    [StringLength(15)]
    public string? RelationshipCode { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysBenefitEnrollmentDependents")]
    public virtual TPerson Person { get; set; } = null!;
}
