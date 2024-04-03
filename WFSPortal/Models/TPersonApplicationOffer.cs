using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonApplicationOffer")]
public partial class TPersonApplicationOffer
{
    [Key]
    [Column("PersonApplicationOfferGUID")]
    public Guid PersonApplicationOfferGuid { get; set; }

    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    [StringLength(15)]
    public string OfferTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime OfferDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? OfferAmount { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MinimumAmount { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MaximumAmount { get; set; }

    [StringLength(15)]
    public string AmountCurrencyCode { get; set; } = null!;

    [StringLength(15)]
    public string AmountFrequencyCode { get; set; } = null!;

    public string? PayTerms { get; set; }

    [StringLength(15)]
    public string DeliveryMethodCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ProposedEmploymentStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AgreedEmploymentStartDate { get; set; }

    [Column("OfferedByPersonGUID")]
    public Guid? OfferedByPersonGuid { get; set; }

    [Column("ApprovedByPersonGUID")]
    public Guid? ApprovedByPersonGuid { get; set; }

    public string? Results { get; set; }

    public string? Comments { get; set; }

    public bool AcceptedFlag { get; set; }

    public bool RejectedFlag { get; set; }

    public int RowVersion { get; set; }

    public bool? WorkScheduleMonday { get; set; }

    public bool PendingFlag { get; set; }

    [Column("PersonApplicationStatusGUID")]
    public Guid? PersonApplicationStatusGuid { get; set; }

    public bool? GasCard { get; set; }

    public bool? WorkScheduleTuesday { get; set; }

    public bool? WorkScheduleWednesday { get; set; }

    public bool? WorkScheduleThursday { get; set; }

    public bool? WorkScheduleFriday { get; set; }

    public bool? WorkScheduleSaturday { get; set; }

    public bool? WorkScheduleSunday { get; set; }

    public bool? WorkScheduleVariable { get; set; }

    [StringLength(80)]
    public string? BuddyName { get; set; }

    public bool? FullTime { get; set; }

    public bool? PartTime { get; set; }

    [Column("SubOrPRN")]
    public bool? SubOrPrn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TempEndDate { get; set; }

    public bool? Academic { get; set; }

    public bool? NonAcademic { get; set; }

    [Column("ESY")]
    public bool? Esy { get; set; }

    [ForeignKey("AmountCurrencyCode")]
    [InverseProperty("TPersonApplicationOffers")]
    public virtual TCurrency AmountCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("AmountFrequencyCode")]
    [InverseProperty("TPersonApplicationOffers")]
    public virtual TFrequency AmountFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("ApprovedByPersonGuid")]
    [InverseProperty("TPersonApplicationOfferApprovedByPeople")]
    public virtual TPerson? ApprovedByPerson { get; set; }

    [ForeignKey("DeliveryMethodCode")]
    [InverseProperty("TPersonApplicationOffers")]
    public virtual TDeliveryMethod DeliveryMethodCodeNavigation { get; set; } = null!;

    [ForeignKey("OfferTypeCode")]
    [InverseProperty("TPersonApplicationOffers")]
    public virtual TOfferType OfferTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("OfferedByPersonGuid")]
    [InverseProperty("TPersonApplicationOfferOfferedByPeople")]
    public virtual TPerson? OfferedByPerson { get; set; }

    [ForeignKey("PersonApplicationGuid")]
    [InverseProperty("TPersonApplicationOffers")]
    public virtual TPersonApplication PersonApplication { get; set; } = null!;

    [ForeignKey("PersonApplicationStatusGuid")]
    [InverseProperty("TPersonApplicationOffers")]
    public virtual TPersonApplicationStatusHist? PersonApplicationStatus { get; set; }

    [InverseProperty("PersonApplicationOffer")]
    public virtual ICollection<TPersonApplicationCommunication> TPersonApplicationCommunications { get; set; } = new List<TPersonApplicationCommunication>();
}
