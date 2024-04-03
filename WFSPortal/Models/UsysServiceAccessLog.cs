using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysServiceAccessLog")]
[Index("Token", "RequestQueryString", Name = "IX_USysServiceAccessLog_Token_RequestQueryString")]
public partial class UsysServiceAccessLog
{
    [Key]
    [Column("ServiceAccessLogGUID")]
    public Guid ServiceAccessLogGuid { get; set; }

    [StringLength(128)]
    public string? Token { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AccessDateTime { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? RequestQueryString { get; set; }

    [StringLength(40)]
    public string RequestingIpAddress { get; set; } = null!;

    public bool SuccessFlag { get; set; }

    public int RowVersion { get; set; }
}
