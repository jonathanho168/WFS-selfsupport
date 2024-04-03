using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkAddress
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public bool PrimaryAddress { get; set; }

    [StringLength(15)]
    public string AddressTypeCode { get; set; } = null!;

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [StringLength(255)]
    public string? Address3 { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(25)]
    public string? County { get; set; }

    [StringLength(15)]
    public string? StateProvinceCode { get; set; }

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [Column("PersonAddressGUID")]
    public Guid PersonAddressGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }
}
