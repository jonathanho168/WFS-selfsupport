using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonVeteran")]
public partial class TPersonVeteran
{
    [Key]
    [Column("PersonVeteranGUID")]
    public Guid PersonVeteranGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string VeteranCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonVeterans")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("VeteranCode")]
    [InverseProperty("TPersonVeterans")]
    public virtual TVeteran VeteranCodeNavigation { get; set; } = null!;
}
