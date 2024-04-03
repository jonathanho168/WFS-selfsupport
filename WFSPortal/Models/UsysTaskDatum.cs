using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysTaskData")]
public partial class UsysTaskDatum
{
    [Key]
    public Guid TaskDataGuid { get; set; }

    [Column(TypeName = "xml")]
    public string? TaskXml { get; set; }

    [StringLength(50)]
    public string? EntityName { get; set; }

    [StringLength(150)]
    public string Name { get; set; } = null!;

    [StringLength(80)]
    public string Description { get; set; } = null!;

    public int Type { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    [ForeignKey("EntityName")]
    [InverseProperty("UsysTaskData")]
    public virtual UsysEntity? EntityNameNavigation { get; set; }

    [InverseProperty("ExternalTaskData")]
    public virtual ICollection<TRequisition> TRequisitionExternalTaskData { get; set; } = new List<TRequisition>();

    [InverseProperty("InternalTaskData")]
    public virtual ICollection<TRequisition> TRequisitionInternalTaskData { get; set; } = new List<TRequisition>();

    [InverseProperty("TaskData")]
    public virtual ICollection<TRequisition> TRequisitionTaskData { get; set; } = new List<TRequisition>();

    [InverseProperty("TaskData")]
    public virtual ICollection<UsysTaskDataLog> UsysTaskDataLogs { get; set; } = new List<UsysTaskDataLog>();
}
