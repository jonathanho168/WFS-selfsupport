using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonFutureEnrollmentStatus")]
[Index("BenefitOpenEnrollmentGroupCode", "PersonGuid", Name = "AK_tPersonFutureEnrollmentStatus", IsUnique = true)]
public partial class TPersonFutureEnrollmentStatus
{
    [Key]
    [Column("PersonFutureEnrollmentStatusGUID")]
    public Guid PersonFutureEnrollmentStatusGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string BenefitOpenEnrollmentGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitFutureEnrollmentPersonStatusCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PersonFutureEnrollmentStatusDate { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnrollmentPeriodExpirationDate { get; set; }

    public bool EmailNotificationSentFlag { get; set; }

    [ForeignKey("BenefitFutureEnrollmentPersonStatusCode")]
    [InverseProperty("TPersonFutureEnrollmentStatuses")]
    public virtual TBenefitFutureEnrollmentPersonStatus BenefitFutureEnrollmentPersonStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("BenefitOpenEnrollmentGroupCode")]
    [InverseProperty("TPersonFutureEnrollmentStatuses")]
    public virtual TBenefitOpenEnrollmentGroup BenefitOpenEnrollmentGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonFutureEnrollmentStatuses")]
    public virtual TPerson Person { get; set; } = null!;

    [InverseProperty("PersonFutureEnrollmentStatus")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollments { get; set; } = new List<TPersonFutureEnrollment>();

    [InverseProperty("PersonFutureEnrollmentStatus")]
    public virtual ICollection<UsysChecklistInstanceStep> UsysChecklistInstanceSteps { get; set; } = new List<UsysChecklistInstanceStep>();
}
