using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLinks")]
public partial class UsysLink
{
    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(250)]
    public string? Url { get; set; }

    public int? ViewOrder { get; set; }

    [StringLength(2000)]
    public string? Description { get; set; }

    public bool? PrivateFlag { get; set; }

    [Key]
    [Column("LinksGUID")]
    public Guid LinksGuid { get; set; }

    public int RowVersion { get; set; }

    public Guid CreatedByUserGuid { get; set; }

    public string? Title { get; set; }

    [ForeignKey("CreatedByUserGuid")]
    [InverseProperty("UsysLinks")]
    public virtual UsysUser CreatedByUser { get; set; } = null!;
}
