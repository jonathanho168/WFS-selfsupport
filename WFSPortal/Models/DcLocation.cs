using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcLocation")]
public partial class DcLocation
{
    [StringLength(50)]
    [Unicode(false)]
    public string? LocationCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LocationDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AreaCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? LeaveWeeks { get; set; }

    [Column("MFMLAWeeks")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Mfmlaweeks { get; set; }

    [Column("FMLAContactPerson")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FmlacontactPerson { get; set; }

    [Column("FMLAPosterLocation")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FmlaposterLocation { get; set; }

    [Column("FMLAContactLocation")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FmlacontactLocation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CensusMetropolitanAreaCode { get; set; }
}
