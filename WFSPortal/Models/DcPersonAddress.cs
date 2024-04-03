using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonAddress")]
public partial class DcPersonAddress
{
    [Column("Last Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("First Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrimaryAddress { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AddressTypeCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? County { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StateProvinceCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CountryCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PostalCode { get; set; }
}
