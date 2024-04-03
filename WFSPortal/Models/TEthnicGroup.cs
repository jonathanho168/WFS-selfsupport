using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEthnicGroup")]
[Index("EthnicGroupGuid", Name = "RG_tEthnicGroup", IsUnique = true)]
public partial class TEthnicGroup
{
    [Key]
    [StringLength(15)]
    public string EthnicGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string? ReportValue { get; set; }

    [Column("EthnicGroupGUID")]
    public Guid EthnicGroupGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool MinorityFlag { get; set; }

    public string? EthnicGroupDescription { get; set; }

    [InverseProperty("EthnicGroupCodeNavigation")]
    public virtual ICollection<TPersonal> TPersonals { get; set; } = new List<TPersonal>();
}
