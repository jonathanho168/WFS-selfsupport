using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkNationalId
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [Column("NationalID")]
    [StringLength(50)]
    public string? NationalId { get; set; }

    [Column("PersonNationalIDGUID")]
    public Guid PersonNationalIdguid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Column("PrimaryIDFlag")]
    public bool? PrimaryIdflag { get; set; }
}
