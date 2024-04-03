using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportTriggerPerson")]
public partial class UsysLnkExportTriggerPerson
{
    [Key]
    [Column("LnkExportTriggerPersonGUID")]
    public Guid LnkExportTriggerPersonGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ChangeDateTime { get; set; }

    public int RowVersion { get; set; }

    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [ForeignKey("ExportId")]
    [InverseProperty("UsysLnkExportTriggerPeople")]
    public virtual UsysLnkExportMaster Export { get; set; } = null!;
}
