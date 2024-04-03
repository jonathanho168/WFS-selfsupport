using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonProfessionalAffiliation")]
public partial class TPersonProfessionalAffiliation
{
    [Key]
    [Column("PersonProfessionalAffiliationGUID")]
    public Guid PersonProfessionalAffiliationGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(80)]
    public string Organization { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(80)]
    public string? Role { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonProfessionalAffiliations")]
    public virtual TPerson Person { get; set; } = null!;
}
