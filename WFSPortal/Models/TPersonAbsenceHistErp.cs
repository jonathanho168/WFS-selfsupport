using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAbsenceHistERP")]
public partial class TPersonAbsenceHistErp
{
    [Key]
    [Column("PersonAbsenceHistERPGUID")]
    public Guid PersonAbsenceHistErpguid { get; set; }

    [Column("PersonAbsenceGUID")]
    public Guid PersonAbsenceGuid { get; set; }

    public int LaborHedSeq { get; set; }

    public int LaborDtlSeq { get; set; }

    public int PersonAbsenceRowVersion { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonAbsencePlanPersonGUID")]
    public Guid? PersonAbsencePlanPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedDate { get; set; }
}
