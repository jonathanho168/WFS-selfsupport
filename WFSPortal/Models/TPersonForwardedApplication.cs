using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonForwardedApplication")]
public partial class TPersonForwardedApplication
{
    [Key]
    [Column("PersonForwardedApplicationGUID")]
    public Guid PersonForwardedApplicationGuid { get; set; }

    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    [Column("ForwardedToPersonGUID")]
    public Guid ForwardedToPersonGuid { get; set; }

    [Column("ForwardedByPersonGUID")]
    public Guid? ForwardedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ForwardedDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ForwardedByPersonGuid")]
    [InverseProperty("TPersonForwardedApplicationForwardedByPeople")]
    public virtual TPerson? ForwardedByPerson { get; set; }

    [ForeignKey("ForwardedToPersonGuid")]
    [InverseProperty("TPersonForwardedApplicationForwardedToPeople")]
    public virtual TPerson ForwardedToPerson { get; set; } = null!;

    [ForeignKey("PersonApplicationGuid")]
    [InverseProperty("TPersonForwardedApplications")]
    public virtual TPersonApplication PersonApplication { get; set; } = null!;

    [ForeignKey("RequisitionCode")]
    [InverseProperty("TPersonForwardedApplications")]
    public virtual TRequisition RequisitionCodeNavigation { get; set; } = null!;
}
