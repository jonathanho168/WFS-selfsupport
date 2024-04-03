using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tLifeEventType")]
[Index("LifeEventTypeGuid", Name = "RG_tLifeEventType", IsUnique = true)]
public partial class TLifeEventType
{
    [Key]
    [StringLength(15)]
    public string LifeEventTypeCode { get; set; } = null!;

    [Column("LifeEventTypeGUID")]
    public Guid LifeEventTypeGuid { get; set; }

    public bool PersonnelActionFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string? BenefitOpenEnrollmentGroupTemplate { get; set; }

    public string? LifeEventTypeDescription { get; set; }

    [ForeignKey("BenefitOpenEnrollmentGroupTemplate")]
    [InverseProperty("TLifeEventTypes")]
    public virtual TBenefitOpenEnrollmentGroup? BenefitOpenEnrollmentGroupTemplateNavigation { get; set; }

    [InverseProperty("LifeEventTypeCodeNavigation")]
    public virtual ICollection<TPersonLifeEvent> TPersonLifeEvents { get; set; } = new List<TPersonLifeEvent>();
}
