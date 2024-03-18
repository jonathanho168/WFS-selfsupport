using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkMobilePhone
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public int PhoneSequence { get; set; }

    [StringLength(15)]
    public string PhoneTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [StringLength(5)]
    public string? Extension { get; set; }

    [Column("PersonPhoneGUID")]
    public Guid PersonPhoneGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public Guid? PersonAddressGuid { get; set; }
}
