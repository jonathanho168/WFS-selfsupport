using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcJobCategory")]
public partial class DcJobCategory
{
    [StringLength(50)]
    [Unicode(false)]
    public string? JobCategoryCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? JobCategoryDescription { get; set; }
}
