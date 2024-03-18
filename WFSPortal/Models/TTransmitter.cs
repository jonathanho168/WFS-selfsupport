using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTransmitter")]
[Index("TransmitterGuid", Name = "RG_tTransmitter", IsUnique = true)]
public partial class TTransmitter
{
    [Key]
    [StringLength(15)]
    public string TransmitterCode { get; set; } = null!;

    public string? TransmitterDescription { get; set; }

    [Column("TransmitterEIN")]
    [StringLength(10)]
    public string? TransmitterEin { get; set; }

    public bool ForeignEntityFlag { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ControlCode { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("TransmitterGUID")]
    public Guid TransmitterGuid { get; set; }

    public int RowVersion { get; set; }
}
