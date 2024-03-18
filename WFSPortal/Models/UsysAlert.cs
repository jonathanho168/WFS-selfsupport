using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAlert")]
public partial class UsysAlert
{
    [StringLength(30)]
    public string? AlertCode { get; set; }

    public bool InactiveFlag { get; set; }

    [Key]
    [Column("AlertGUID")]
    public Guid AlertGuid { get; set; }

    public int RowVersion { get; set; }

    public int AlertType { get; set; }

    [StringLength(50)]
    public string? TableEntity { get; set; }

    [StringLength(4000)]
    public string? FilterSql { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? KeyField { get; set; }

    [Column("CommunicationTemplateGUID")]
    public Guid? CommunicationTemplateGuid { get; set; }

    public bool CreateToDoFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReminderDate { get; set; }

    public bool UsePersonalEmailAddressIfNoCompanyEmailAddressFlag { get; set; }

    public int LicenseFlags { get; set; }

    public string? AlertDescription { get; set; }

    [ForeignKey("CommunicationTemplateGuid")]
    [InverseProperty("UsysAlerts")]
    public virtual UsysCommunicationTemplate? CommunicationTemplate { get; set; }

    [ForeignKey("TableEntity")]
    [InverseProperty("UsysAlerts")]
    public virtual UsysEntity? TableEntityNavigation { get; set; }

    [InverseProperty("Alert")]
    public virtual ICollection<UsysAlertInstance> UsysAlertInstances { get; set; } = new List<UsysAlertInstance>();

    [InverseProperty("Alert")]
    public virtual ICollection<UsysAlertRecipient> UsysAlertRecipients { get; set; } = new List<UsysAlertRecipient>();

    [InverseProperty("Alert")]
    public virtual ICollection<UsysAlertSchedule> UsysAlertSchedules { get; set; } = new List<UsysAlertSchedule>();
}
