using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcFSWPjobcodes")]
public partial class DcFswpjobcode
{
    [Column("id")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Id { get; set; }

    [Column("Job Title Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? JobTitleCode { get; set; }

    [Column("epicorjob")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Epicorjob { get; set; }
}
