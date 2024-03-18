using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcWorkersComp")]
public partial class DcWorkersComp
{
    [StringLength(50)]
    [Unicode(false)]
    public string? WorkersCompensationCategoryCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? WorkersCompensationCategoryDescription { get; set; }
}
