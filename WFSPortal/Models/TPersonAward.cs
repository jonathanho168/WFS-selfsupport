using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAward")]
public partial class TPersonAward
{
    [Key]
    [Column("PersonAwardGUID")]
    public Guid PersonAwardGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(80)]
    public string Award { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ReceivedDate { get; set; }

    [StringLength(80)]
    public string? AwardedBy { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonAwards")]
    public virtual TPerson Person { get; set; } = null!;
}
