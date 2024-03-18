using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPerson")]
public partial class DcPerson
{
    [Column("PersonID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PersonId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Salutation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nickname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FormerLastName { get; set; }

    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column("SSN Country Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SsnCountryCode { get; set; }

    [Column("EmployeeID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeId { get; set; }

    [Column("BadgeID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BadgeId { get; set; }

    [Column("PayrollID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PayrollId { get; set; }

    [Column("TimeClockID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TimeClockId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CompanyEmailAddress { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PersonalEmailAddress { get; set; }
}
