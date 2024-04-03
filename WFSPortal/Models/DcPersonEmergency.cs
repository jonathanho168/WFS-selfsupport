using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonEmergency")]
public partial class DcPersonEmergency
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column("EE FirstName")]
    [StringLength(500)]
    [Unicode(false)]
    public string? EeFirstName { get; set; }

    [Column("EE LastName")]
    [StringLength(500)]
    [Unicode(false)]
    public string? EeLastName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ContactLastName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ContactFirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Salutation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Priority { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RelationshipCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DayAreaCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DayPhone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HomeAreaCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HomePhone { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StateProvinceCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CountryCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PostalCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Extension { get; set; }
}
