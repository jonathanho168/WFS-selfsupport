using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMassChange")]
public partial class TMassChange
{
    [Key]
    [Column("MassChangeGUID")]
    public Guid MassChangeGuid { get; set; }

    [StringLength(125)]
    public string UserFullName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MassChangeDateTime { get; set; }

    [StringLength(15)]
    public string MassChangeReasonCode { get; set; } = null!;

    [StringLength(1)]
    public string ChangeType { get; set; } = null!;

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    public string? MassChangeDescription { get; set; }

    [ForeignKey("MassChangeReasonCode")]
    [InverseProperty("TMassChanges")]
    public virtual TMassChangeReason MassChangeReasonCodeNavigation { get; set; } = null!;

    [InverseProperty("MassChange")]
    public virtual ICollection<TMassChangeOperation> TMassChangeOperations { get; set; } = new List<TMassChangeOperation>();

    [InverseProperty("MassChangeInstance")]
    public virtual ICollection<UsysMassChangeError> UsysMassChangeErrors { get; set; } = new List<UsysMassChangeError>();

    [InverseProperty("MassChangeInstance")]
    public virtual ICollection<UsysMassChangeSql> UsysMassChangeSqls { get; set; } = new List<UsysMassChangeSql>();
}
