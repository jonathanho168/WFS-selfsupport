using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysResumeSearch")]
public partial class UsysResumeSearch
{
    [Key]
    [Column("SysResumeSearchGUID")]
    public Guid SysResumeSearchGuid { get; set; }

    [Column("UserGUID")]
    public Guid? UserGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SearchDateTime { get; set; }

    [Column("ResultPersonApplicationGUIDs")]
    public string? ResultPersonApplicationGuids { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysResumeSearches")]
    public virtual UsysUser? User { get; set; }

    [InverseProperty("SysResumeSearch")]
    public virtual ICollection<UsysResumeSearchParameter> UsysResumeSearchParameters { get; set; } = new List<UsysResumeSearchParameter>();
}
