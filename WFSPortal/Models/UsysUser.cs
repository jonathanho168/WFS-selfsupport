using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysUser")]
[Index("ActiveFlag", "AccountLockoutFlag", "AllowMobileAccessFlag", Name = "WFS_USysUser_active")]
public partial class UsysUser
{
    [Key]
    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    [StringLength(256)]
    public string UserName { get; set; } = null!;

    [StringLength(256)]
    public string Password { get; set; } = null!;

    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    public bool CanSeeMeFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PasswordExpirationDate { get; set; }

    public bool AccountLockoutFlag { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "xml")]
    public string? UserPreferences { get; set; }

    [StringLength(256)]
    public string? DomainIdentity { get; set; }

    public bool? HasCustomizedHomePageFlag { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(15)]
    public string LanguageCode { get; set; } = null!;

    public bool AllowMobileAccessFlag { get; set; }

    public bool IsManagerUserFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PasswordResetExpirationDate { get; set; }

    [Column("PasswordResetExpirationGUID")]
    public Guid? PasswordResetExpirationGuid { get; set; }

    [ForeignKey("LanguageCode")]
    [InverseProperty("UsysUsers")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysUsers")]
    public virtual TPerson? Person { get; set; }

    [InverseProperty("CreatedByUser")]
    public virtual ICollection<TPersonApplicationStatusHist> TPersonApplicationStatusHists { get; set; } = new List<TPersonApplicationStatusHist>();

    [InverseProperty("LastModifiedByUserNavigation")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();

    [InverseProperty("CreatedByUser")]
    public virtual ICollection<UsysAnnouncement> UsysAnnouncements { get; set; } = new List<UsysAnnouncement>();

    [InverseProperty("User")]
    public virtual ICollection<UsysCsfuser> UsysCsfusers { get; set; } = new List<UsysCsfuser>();

    [InverseProperty("User")]
    public virtual ICollection<UsysDatabaseChange> UsysDatabaseChanges { get; set; } = new List<UsysDatabaseChange>();

    [InverseProperty("User")]
    public virtual ICollection<UsysDraft> UsysDrafts { get; set; } = new List<UsysDraft>();

    [InverseProperty("CreatedByUser")]
    public virtual ICollection<UsysLink> UsysLinks { get; set; } = new List<UsysLink>();

    [InverseProperty("User")]
    public virtual ICollection<UsysLnkExportLog> UsysLnkExportLogs { get; set; } = new List<UsysLnkExportLog>();

    [InverseProperty("User")]
    public virtual ICollection<UsysLnkImportLog> UsysLnkImportLogs { get; set; } = new List<UsysLnkImportLog>();

    [InverseProperty("User")]
    public virtual ICollection<UsysOrgChart> UsysOrgCharts { get; set; } = new List<UsysOrgChart>();

    [InverseProperty("User")]
    public virtual ICollection<UsysReportParameter> UsysReportParameters { get; set; } = new List<UsysReportParameter>();

    [InverseProperty("User")]
    public virtual ICollection<UsysResumeSearch> UsysResumeSearches { get; set; } = new List<UsysResumeSearch>();

    [InverseProperty("User")]
    public virtual ICollection<UsysRowSecurity> UsysRowSecurities { get; set; } = new List<UsysRowSecurity>();

    [InverseProperty("LoggedByUser")]
    public virtual ICollection<UsysTaskDataLog> UsysTaskDataLogs { get; set; } = new List<UsysTaskDataLog>();

    [InverseProperty("User")]
    public virtual ICollection<UsysUserAccessLog> UsysUserAccessLogs { get; set; } = new List<UsysUserAccessLog>();

    [InverseProperty("User")]
    public virtual ICollection<UsysUserHomePageModule> UsysUserHomePageModules { get; set; } = new List<UsysUserHomePageModule>();

    [InverseProperty("User")]
    public virtual ICollection<UsysUserRole> UsysUserRoles { get; set; } = new List<UsysUserRole>();

    [InverseProperty("User")]
    public virtual ICollection<UsysUserSignatureAnswer> UsysUserSignatureAnswers { get; set; } = new List<UsysUserSignatureAnswer>();
}
