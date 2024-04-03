using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_VBA_w_5010_2000_N4")]
public partial class LnkVbaW50102000N4
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("CityName-N401")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CityNameN401 { get; set; }

    [Column("StateProvinceCode-N402")]
    [StringLength(2)]
    [Unicode(false)]
    public string? StateProvinceCodeN402 { get; set; }

    [Column("PostalCode-N403")]
    [StringLength(9)]
    [Unicode(false)]
    public string? PostalCodeN403 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }
}
