using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonApplicationCommunication")]
[Index("PersonApplicationOfferGuid", Name = "IX_tPersonApplicationCommunication_PersonApplicationOfferGUID")]
public partial class TPersonApplicationCommunication
{
    [Key]
    [Column("PersonApplicationCommunicationGUID")]
    public Guid PersonApplicationCommunicationGuid { get; set; }

    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    [Column("PersonApplicationOfferGUID")]
    public Guid? PersonApplicationOfferGuid { get; set; }

    [StringLength(512)]
    public string? EmailSubject { get; set; }

    [Column("SentByPersonGUID")]
    public Guid? SentByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SentDate { get; set; }

    [StringLength(4000)]
    public string? SentText { get; set; }

    public int RowVersion { get; set; }

    [Column("CommunicationTemplateGUID")]
    public Guid? CommunicationTemplateGuid { get; set; }

    public string? Comments { get; set; }

    public byte[]? FileAttachment { get; set; }

    public string? CandidateActivityNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityDate { get; set; }

    [ForeignKey("CommunicationTemplateGuid")]
    [InverseProperty("TPersonApplicationCommunications")]
    public virtual UsysCommunicationTemplate? CommunicationTemplate { get; set; }

    [ForeignKey("PersonApplicationGuid")]
    [InverseProperty("TPersonApplicationCommunications")]
    public virtual TPersonApplication PersonApplication { get; set; } = null!;

    [ForeignKey("PersonApplicationOfferGuid")]
    [InverseProperty("TPersonApplicationCommunications")]
    public virtual TPersonApplicationOffer? PersonApplicationOffer { get; set; }

    [ForeignKey("SentByPersonGuid")]
    [InverseProperty("TPersonApplicationCommunications")]
    public virtual TPerson? SentByPerson { get; set; }
}
