using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysEMailProfile")]
[Index("UsysEmailProfileGuid", Name = "RG_USysEmailProfile", IsUnique = true)]
public partial class UsysEmailProfile
{
    [Key]
    [StringLength(15)]
    public string EmailProfileCode { get; set; } = null!;

    [StringLength(128)]
    public string EmailProfileDescription { get; set; } = null!;

    [Column("USysEmailProfileGUID")]
    public Guid UsysEmailProfileGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string SmtpServer { get; set; } = null!;

    [StringLength(128)]
    [Unicode(false)]
    public string SmtpUsername { get; set; } = null!;

    [StringLength(128)]
    [Unicode(false)]
    public string SmtpPassword { get; set; } = null!;

    [StringLength(128)]
    [Unicode(false)]
    public string EmailFromAddress { get; set; } = null!;

    public bool AdminProfileFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int SmtpPort { get; set; }

    [Column("SmtpIsSSL")]
    public bool SmtpIsSsl { get; set; }

    [InverseProperty("EmailProfileCodeNavigation")]
    public virtual ICollection<UsysCommunicationTemplate> UsysCommunicationTemplates { get; set; } = new List<UsysCommunicationTemplate>();
}
