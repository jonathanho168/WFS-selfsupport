using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRequisitionEmployeesReplaced")]
[Index("RequisitionCode", "ReplacedPersonGuid", Name = "AK_tRequisitionEmployeesReplaced", IsUnique = true)]
public partial class TRequisitionEmployeesReplaced
{
    [Key]
    public Guid RequisitionEmployeesReplacedGuid { get; set; }

    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    public Guid ReplacedPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReplacedDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ReplacedPersonGuid")]
    [InverseProperty("TRequisitionEmployeesReplaceds")]
    public virtual TPerson ReplacedPerson { get; set; } = null!;

    [ForeignKey("RequisitionCode")]
    [InverseProperty("TRequisitionEmployeesReplaceds")]
    public virtual TRequisition RequisitionCodeNavigation { get; set; } = null!;
}
