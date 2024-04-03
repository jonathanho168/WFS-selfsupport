using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonSpecialAccommodation")]
public partial class TPersonSpecialAccommodation
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [StringLength(1000)]
    public string? ConditionDescription { get; set; }

    [StringLength(1000)]
    public string? Request { get; set; }

    [StringLength(1000)]
    public string? Resolution { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResolutionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewDate { get; set; }

    public string? Comments { get; set; }

    [Key]
    [Column("PersonSpecialAccommodationGUID")]
    public Guid PersonSpecialAccommodationGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonSpecialAccommodations")]
    public virtual TPerson Person { get; set; } = null!;
}
