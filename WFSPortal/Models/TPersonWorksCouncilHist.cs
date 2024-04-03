using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonWorksCouncilHist")]
public partial class TPersonWorksCouncilHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonWorksCouncilStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonWorksCouncilEndDate { get; set; }

    public bool PersonWorksCouncilCurrentFlag { get; set; }

    [StringLength(15)]
    public string WorksCouncilCode { get; set; } = null!;

    [StringLength(15)]
    public string WorksCouncilRoleCode { get; set; } = null!;

    [Key]
    [Column("PersonWorksCouncilGUID")]
    public Guid PersonWorksCouncilGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonWorksCouncilHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("WorksCouncilCode")]
    [InverseProperty("TPersonWorksCouncilHists")]
    public virtual TWorksCouncil WorksCouncilCodeNavigation { get; set; } = null!;

    [ForeignKey("WorksCouncilRoleCode")]
    [InverseProperty("TPersonWorksCouncilHists")]
    public virtual TWorksCouncilRole WorksCouncilRoleCodeNavigation { get; set; } = null!;
}
