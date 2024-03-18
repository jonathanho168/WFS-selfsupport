using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLanguageUser")]
public partial class UsysLanguageUser
{
    [Key]
    [Column("LanguageUserGUID")]
    public Guid LanguageUserGuid { get; set; }

    [StringLength(256)]
    public string UserName { get; set; } = null!;

    [StringLength(256)]
    public string Password { get; set; } = null!;

    [StringLength(15)]
    public string LanguageCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public bool AllowUserLanguageFlag { get; set; }

    [StringLength(12)]
    public string SystemLanguageCode { get; set; } = null!;

    public bool UseAsSystemDefaultFlag { get; set; }

    [ForeignKey("LanguageCode")]
    [InverseProperty("UsysLanguageUsers")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;
}
