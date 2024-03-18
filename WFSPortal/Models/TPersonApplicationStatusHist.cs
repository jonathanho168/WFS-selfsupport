using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonApplicationStatusHist")]
public partial class TPersonApplicationStatusHist
{
    [Key]
    [Column("PersonApplicationStatusGUID")]
    public Guid PersonApplicationStatusGuid { get; set; }

    [StringLength(15)]
    public string ApplicationStatusCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonApplicationStatusStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonApplicationStatusEndDate { get; set; }

    [Column("CreatedByUserGUID")]
    public Guid? CreatedByUserGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    public string? PersonApplicationStatusComments { get; set; }

    public bool PersonApplicationStatusCurrentFlag { get; set; }

    [ForeignKey("ApplicationStatusCode")]
    [InverseProperty("TPersonApplicationStatusHists")]
    public virtual TApplicationStatus ApplicationStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("CreatedByUserGuid")]
    [InverseProperty("TPersonApplicationStatusHists")]
    public virtual UsysUser? CreatedByUser { get; set; }

    [ForeignKey("PersonApplicationGuid")]
    [InverseProperty("TPersonApplicationStatusHists")]
    public virtual TPersonApplication PersonApplication { get; set; } = null!;

    [InverseProperty("PersonApplicationStatus")]
    public virtual ICollection<TPersonApplicationEvaluation> TPersonApplicationEvaluations { get; set; } = new List<TPersonApplicationEvaluation>();

    [InverseProperty("PersonApplicationStatus")]
    public virtual ICollection<TPersonApplicationOffer> TPersonApplicationOffers { get; set; } = new List<TPersonApplicationOffer>();
}
