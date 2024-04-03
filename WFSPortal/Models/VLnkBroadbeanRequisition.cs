using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkBroadbeanRequisition
{
    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    public string? RequisitionDescription { get; set; }

    [StringLength(15)]
    public string StatusCategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    public string? BroadbeanJobPostingSkills { get; set; }

    public string? BroadbeanJobPostingDescription { get; set; }

    [StringLength(125)]
    public string? ContactName { get; set; }

    [StringLength(255)]
    public string? ContactEmail { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ContactTelephone { get; set; }

    [StringLength(334)]
    public string? ContactAddress { get; set; }
}
