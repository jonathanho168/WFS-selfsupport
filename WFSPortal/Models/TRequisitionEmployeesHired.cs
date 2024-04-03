using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRequisitionEmployeesHired")]
[Index("RequisitionCode", "HiredPersonGuid", Name = "AK_tRequisitionEmployeesHired", IsUnique = true)]
public partial class TRequisitionEmployeesHired
{
    [Key]
    public Guid RequisitionEmployeesHiredGuid { get; set; }

    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    public Guid HiredPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HiredDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("HiredPersonGuid")]
    [InverseProperty("TRequisitionEmployeesHireds")]
    public virtual TPerson HiredPerson { get; set; } = null!;

    [ForeignKey("RequisitionCode")]
    [InverseProperty("TRequisitionEmployeesHireds")]
    public virtual TRequisition RequisitionCodeNavigation { get; set; } = null!;
}
