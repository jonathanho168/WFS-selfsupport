using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcDependents")]
public partial class DcDependent
{
    [Column("Employee SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeSsn { get; set; }

    [Column("Employee FirstName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeFirstName { get; set; }

    [Column("Employee LastName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeLastName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Relationship { get; set; }

    [Column("DependentSSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DependentSsn { get; set; }

    [Column("Dep First Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DepFirstName { get; set; }

    [Column("Dep Last Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DepLastName { get; set; }

    [Column("Dep DOB", TypeName = "datetime")]
    public DateTime? DepDob { get; set; }

    [Column("Dep Gender")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DepGender { get; set; }

    [Column("Dep Smoker")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DepSmoker { get; set; }

    [Column("Benefit Plan Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BenefitPlanCode { get; set; }

    [Column("Benefit Plan Option Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BenefitPlanOptionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BenefitWaiveReasonCode { get; set; }

    [Column("Effective date", TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column("Coverage Amt")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CoverageAmt { get; set; }

    [Column("End date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }
}
