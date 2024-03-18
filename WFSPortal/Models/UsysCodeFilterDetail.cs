using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCodeFilterDetail")]
public partial class UsysCodeFilterDetail
{
    [Column("AllowedRowGUID")]
    public Guid AllowedRowGuid { get; set; }

    [Key]
    [Column("CodeFilterDetailGUID")]
    public Guid CodeFilterDetailGuid { get; set; }

    public int RowVersion { get; set; }

    public Guid CodeFilterTableGuid { get; set; }

    [ForeignKey("CodeFilterTableGuid")]
    [InverseProperty("UsysCodeFilterDetails")]
    public virtual UsysCodeFilterTable CodeFilterTable { get; set; } = null!;
}
