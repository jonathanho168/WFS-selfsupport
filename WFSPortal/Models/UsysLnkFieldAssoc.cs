using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkFieldAssoc")]
public partial class UsysLnkFieldAssoc
{
    [Column("LnkFieldDefGUID")]
    public Guid LnkFieldDefGuid { get; set; }

    [Column("AssocLnkFieldDefGUID")]
    public Guid AssocLnkFieldDefGuid { get; set; }

    [Key]
    [Column("LnkFieldAssocGUID")]
    public Guid LnkFieldAssocGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("AssocLnkFieldDefGuid")]
    [InverseProperty("UsysLnkFieldAssocAssocLnkFieldDefs")]
    public virtual UsysLnkFieldDef AssocLnkFieldDef { get; set; } = null!;

    [ForeignKey("LnkFieldDefGuid")]
    [InverseProperty("UsysLnkFieldAssocLnkFieldDefs")]
    public virtual UsysLnkFieldDef LnkFieldDef { get; set; } = null!;
}
