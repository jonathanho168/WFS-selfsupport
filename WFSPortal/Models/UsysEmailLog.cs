using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysEmailLog")]
public partial class UsysEmailLog
{
    [Key]
    [Column("EmailLogGUID")]
    public Guid EmailLogGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SentDateTime { get; set; }

    [StringLength(80)]
    public string? EmailFrom { get; set; }

    [StringLength(80)]
    public string? EmailSubject { get; set; }

    public string? EmailRecipient { get; set; }

    public string? EmailBody { get; set; }

    [Column("EMailProfileName")]
    [StringLength(128)]
    public string? EmailProfileName { get; set; }

    public int RowVersion { get; set; }

    public int Result { get; set; }
}
