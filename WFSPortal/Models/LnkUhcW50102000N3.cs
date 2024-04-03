using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_UHC_w_5010_2000_N3")]
public partial class LnkUhcW50102000N3
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("AddressInformation-N301")]
    [StringLength(35)]
    [Unicode(false)]
    public string? AddressInformationN301 { get; set; }

    [Column("AddressInformation-N302")]
    [StringLength(35)]
    [Unicode(false)]
    public string? AddressInformationN302 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }
}
